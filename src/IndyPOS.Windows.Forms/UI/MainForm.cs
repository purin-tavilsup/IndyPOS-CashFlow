﻿using IndyPOS.CashFlow.Application.Common.Enums;
using IndyPOS.CashFlow.Application.Common.Interfaces;
using IndyPOS.CashFlow.Application.Common.Models;
using Microsoft.Extensions.Logging;
using System.IO;

namespace IndyPOS.CashFlow.Windows.Forms.UI;

public partial class MainForm : Form
{
    private readonly IReportService _reportService;
    private readonly IJsonService _jsonService;
    private readonly ICsvService _csvService;
    private ISalesReport? _salesReport;
    private IPaymentsReport? _paymentsReport;
	private readonly ILogger<MainForm> _logger;

    private const string DataDirectory = @"C:\\ProgramData\\IndyPOSCashFlow\\Data";
	private const string CsvDirectory = @"C:\\ProgramData\\IndyPOSCashFlow\\CSV";
    private const string SharedDirectory = @"G:\\My Drive\\Rungrat\\Data\\CSV";

    private static string DataFilePath => @$"{DataDirectory}\\CashFlow_{DateTime.Today:yyyy-MMMM-dd}.json";
	private static string CsvFilePath => @$"{CsvDirectory}\\CashFlow_{DateTime.Today:yyyy-MMMM-dd}.csv";
    private static string SharedCsvFilePath => @$"{SharedDirectory}\\CashFlow_{DateTime.Today:yyyy-MMMM-dd}.csv";

    public MainForm(IReportService reportService, 
					IJsonService jsonService,
					ICsvService csvService,
					ILogger<MainForm> logger)
    {
        _reportService = reportService;
        _jsonService = jsonService;
		_csvService = csvService;
        _logger = logger;

        InitializeComponent();
        InitializeChangesListView();
        InitializePayOutListView();
        InitializeReceivedPayLaterPaymentsListView();
        LoadSavedData();

        RemovePayOutButton.Enabled = false;
        RemoveChangeButton.Enabled = false;
        RemoveReceivedPayLaterPaymentButton.Enabled = false;

        DateLabel.Text = $"Date: {DateTime.Today:D}";
	}

    private async Task<ISalesReport> GetSalesReportAsync()
    {
        return await _reportService.CreateSalesReportByPeriodAsync(TimePeriod.Today);
    }

    private async Task<IPaymentsReport> GetPaymentsReportAsync()
    {
        return await _reportService.CreatePaymentsReportByPeriodAsync(TimePeriod.Today);
    }

    private void InitializeChangesListView()
    {
        ChangesListView.View = View.Details;
        ChangesListView.GridLines = true;
        ChangesListView.FullRowSelect = true;

        ChangesListView.Columns.Add("เวลา", 70, HorizontalAlignment.Center);
        ChangesListView.Columns.Add("จำนวน", 130, HorizontalAlignment.Right);
    }

    private void InitializePayOutListView()
    {
        PayoutsListView.View = View.Details;
        PayoutsListView.GridLines = true;
        PayoutsListView.FullRowSelect = true;

        PayoutsListView.Columns.Add("เวลา", 70, HorizontalAlignment.Center);
        PayoutsListView.Columns.Add("รายการ", 120, HorizontalAlignment.Center);
        PayoutsListView.Columns.Add("จำนวน", 100, HorizontalAlignment.Right);
    }

    private void InitializeReceivedPayLaterPaymentsListView()
    {
        ReceivedPayLaterPaymentsListView.View = View.Details;
        ReceivedPayLaterPaymentsListView.GridLines = true;
        ReceivedPayLaterPaymentsListView.FullRowSelect = true;

        ReceivedPayLaterPaymentsListView.Columns.Add("เวลา", 70, HorizontalAlignment.Center);
        ReceivedPayLaterPaymentsListView.Columns.Add("ชื่อ", 100, HorizontalAlignment.Center);
        ReceivedPayLaterPaymentsListView.Columns.Add("จำนวน", 100, HorizontalAlignment.Right);
    }

    private void LoadSavedData()
    {
        var data = LoadDataFromFile();

        GeneralGoodsSaleLabel.Text = $"{data.GeneralProductsTotal:N2}";
        HardwareSaleLabel.Text = $"{data.HardwareProductsTotal:N2}";

        CashPaymentLabel.Text = $"{data.SalesTotalWithoutPayLaterPayments:N2}";
        MoneyTransferPaymentLabel.Text = $"{data.MoneyTransferTotal:N2}";
        WelfareCardPaymentLabel.Text = $"{data.WelfareCardTotal:N2}";

        AddChangesToListView(data.Changes);
        AddPayoutsToListView(data.Payouts);
        AddReceivedPayLaterPaymentsToListView(data.PayLaterPayments);

        ChangesTotalLabel.Text = $"{data.ChangesTotal:N2}";
        PayoutsTotalLabel.Text = $"{data.PayoutsTotal:N2}";
        ReceivedPayLaterPaymentsTotalLabel.Text = $"{data.ReceivedPayLaterPaymentsTotal:N2}";

        DisplayBankNote1000Total(data);
        DisplayBankNote500Total(data);
        DisplayBankNote100Total(data);
        DisplayBankNote50Total(data);
        DisplayBankNote20Total(data);

        DisplayCoin10Total(data);
        DisplayCoin5Total(data);
        DisplayCoin2Total(data);
        DisplayCoin1Total(data);
    }

    private CashFlowData LoadDataFromFile()
    {
        return File.Exists(DataFilePath) ? _jsonService.ReadFromFile<CashFlowData>(DataFilePath) : new CashFlowData();
    }

    private async Task SaveDataToJsonFileAsync(CashFlowData data)
    {
        if (!Directory.Exists(DataDirectory))
        {
            Directory.CreateDirectory(DataDirectory);
        }

        try
        {
            await _jsonService.SaveToFileAsync(data, DataFilePath);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "บันทึกไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			var message = $"Failed to save data file [{DataFilePath}] to directory [{DataDirectory}]";

			_logger.LogWarning(ex, message);
        }
    }

	private async Task SaveDataToCsvFileAsync(CashFlowData data)
	{
		if (!Directory.Exists(CsvDirectory))
		{
			Directory.CreateDirectory(CsvDirectory);
		}

		try
		{
			var records = new List<CashFlowData> { data };

			await _csvService.WriteToCsvFile(records, CsvFilePath);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "บันทึกไม่สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			var message = $"Failed to save csv file [{CsvFilePath}] to directory [{CsvDirectory}]";

			_logger.LogWarning(ex, message);
		}
	}

    private void CopyCsvFileToSharedDirectory()
    {
		try
		{
            File.Copy(CsvFilePath, SharedCsvFilePath, overwrite: true);
		}
		catch (Exception ex)
		{
            var message = $"Failed to copy file [{CsvFilePath}] to directory [{SharedDirectory}]";

            _logger.LogWarning(ex, message);
		}
    }

    private CashFlowData CreateCashFlowData()
    {
		var now = DateTime.Now;
        var data = new CashFlowData
        {
			Date = $"{now:yyyy MMMM dd}",
			Time = $"{now:h:mm:ss tt}",
            GeneralProductsTotal = _salesReport?.GeneralProductsTotal ?? 0m,
            HardwareProductsTotal = _salesReport?.HardwareProductsTotal ?? 0m,
            SalesTotalWithoutPayLaterPayments = _salesReport?.InvoiceTotalWithoutPayLaterPayments ?? 0m,
            MoneyTransferTotal = _paymentsReport?.MoneyTransferTotal ?? 0m,
            WelfareCardTotal = _paymentsReport?.WelfareCardTotal ?? 0m,

            Changes = GetChangesFromListView(),
            Payouts = GetPayoutsFromListView(),
            PayLaterPayments = GetReceivedPayLaterPaymentsFromListView(),

            BankNote1000Count = GetBankNote1000Count(),
            BankNote500Count = GetBankNote500Count(),
            BankNote100Count = GetBankNote100Count(),
            BankNote50Count = GetBankNote50Count(),
            BankNote20Count = GetBankNote20Count(),

            Coin10Count = GetCoin10Count(),
            Coin5Count = GetCoin5Count(),
            Coin2Count = GetCoin2Count(),
            Coin1Count = GetCoin1Count()
        };

        return data;
    }

    private async void PullLatestDataFromDatabaseButton_Click(object sender, EventArgs e)
    {
        _salesReport = await GetSalesReportAsync();
        _paymentsReport = await GetPaymentsReportAsync();

        UpdateResults();
    }

    private void UpdateResults()
    {
        var data = CreateCashFlowData();

        DisplayResults(data);
    }

    private async void SaveToFileButton_Click(object sender, EventArgs e)
    {
		var data = CreateCashFlowData();

        await SaveDataToJsonFileAsync(data);
		await SaveDataToCsvFileAsync(data);

		CopyCsvFileToSharedDirectory();

		MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "บันทึกข้อมูล", MessageBoxButtons.OK, MessageBoxIcon.None);
	}

    private void DisplayResults(CashFlowData data)
    {
        var expectedCash = CalculateExpectedCash(data);
        var actualCash = CalculateActualCash(data);
        var diffCash = actualCash - expectedCash;

        GeneralGoodsSaleLabel.Text = $"{data.GeneralProductsTotal:N2}";
        HardwareSaleLabel.Text = $"{data.HardwareProductsTotal:N2}";

        CashPaymentLabel.Text = $"{data.SalesTotalWithoutPayLaterPayments:N2}";
        MoneyTransferPaymentLabel.Text = $"{data.MoneyTransferTotal:N2}";
        WelfareCardPaymentLabel.Text = $"{data.WelfareCardTotal:N2}";

        ChangesTotalLabel.Text = $"{data.ChangesTotal:N2}";
        PayoutsTotalLabel.Text = $"{data.PayoutsTotal:N2}";
        ReceivedPayLaterPaymentsTotalLabel.Text = $"{data.ReceivedPayLaterPaymentsTotal:N2}";

        DisplayBankNote1000Total(data);
        DisplayBankNote500Total(data);
        DisplayBankNote100Total(data);
        DisplayBankNote50Total(data);
        DisplayBankNote20Total(data);

        DisplayCoin10Total(data);
        DisplayCoin5Total(data);
        DisplayCoin2Total(data);
        DisplayCoin1Total(data);

        CalculatedCashTotalLabel.Text = $"{expectedCash:N2}";
        ActualCashTotalLabel.Text = $"{actualCash:N2}";
        DiffCashLabel.Text = $"{diffCash:N2}";

        if (diffCash == 0)
        {
            DiffCashDescriptionLabel.Text = "พอดี";
        }
        else
        {
            DiffCashDescriptionLabel.Text = diffCash > 0 ? "เกิน" : "ขาด";
        }
    }

    private static decimal CalculateExpectedCash(CashFlowData data)
    {
        var expectedCash = data.SalesTotalWithoutPayLaterPayments
                         + data.ReceivedPayLaterPaymentsTotal
                         + data.ChangesTotal
                         - data.MoneyTransferTotal
                         - data.WelfareCardTotal
                         - data.PayoutsTotal;

        return expectedCash;
    }

    private static decimal CalculateActualCash(CashFlowData data)
    {
		var actualCash = data.BankNote1000Total
					   + data.BankNote500Total
					   + data.BankNote100Total
					   + data.BankNote50Total
					   + data.BankNote20Total
					   + data.Coin10Total
					   + data.Coin5Count
					   + data.Coin2Count
					   + data.Coin1Count;

        return actualCash;
    }

    private IEnumerable<Change> GetChangesFromListView()
    {
        return ChangesListView.Items.Cast<ListViewItem>().Select(x => new Change
        {
            Date = x.SubItems[0].Text,
            Amount = decimal.Parse(x.SubItems[1].Text)
        });
    }

    private void AddChangesToListView(IEnumerable<Change> changes)
    {
        foreach (var change in changes)
        {
            var rowItem = new[] { change.Date, $"{change.Amount:N2}" };
            var item = new ListViewItem(rowItem);

            ChangesListView.Items.Add(item);
        }
    }

    private IEnumerable<Payout> GetPayoutsFromListView()
    {
        return PayoutsListView.Items.Cast<ListViewItem>().Select(x => new Payout
        {
            Date = x.SubItems[0].Text,
            Description = x.SubItems[1].Text,
            Amount = decimal.Parse(x.SubItems[2].Text)
        });
    }

    private void AddPayoutsToListView(IEnumerable<Payout> payouts)
    {
        foreach (var payout in payouts)
        {
            var rowItem = new[] { payout.Date, payout.Description, $"{payout.Amount:N2}" };
            var item = new ListViewItem(rowItem);

            PayoutsListView.Items.Add(item);
        }
    }

    private IEnumerable<PayLaterPayment> GetReceivedPayLaterPaymentsFromListView()
    {
        return ReceivedPayLaterPaymentsListView.Items.Cast<ListViewItem>().Select(x => new PayLaterPayment
        {
            Date = x.SubItems[0].Text,
            AccountName = x.SubItems[1].Text,
            Amount = decimal.Parse(x.SubItems[2].Text)
        });
    }

    private void AddReceivedPayLaterPaymentsToListView(IEnumerable<PayLaterPayment> payments)
    {
        foreach (var payment in payments)
        {
            var rowItem = new[] { payment.Date, payment.AccountName, $"{payment.Amount:N2}" };
            var item = new ListViewItem(rowItem);

            ReceivedPayLaterPaymentsListView.Items.Add(item);
        }
    }

    private void AddChangeButton_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(ChangeAmountTextBox.Text.Trim(), out var amount))
        {
            MessageBox.Show("จำนวนเงินทอนไม่ถูกต้อง", "เพิ่มเงินทอนไม่สำเร็จ");
            return;
        }

        var rowItem = new[] { $"{DateTime.Now:t}", $"{amount:N2}" };
        var item = new ListViewItem(rowItem);

        ChangesListView.Items.Add(item);

        ChangeAmountTextBox.Text = string.Empty;

        UpdateResults();
    }

    private void AddPayOutItemButton_Click(object sender, EventArgs e)
    {

        if (!decimal.TryParse(PayOutAmountTextBox.Text.Trim(), out var amount))
        {
            MessageBox.Show("จำนวนรายจ่ายไม่ถูกต้อง", "เพิ่มรายจ่ายไม่สำเร็จ");
            return;
        }

        var itemName = PayOutItemTextBox.Text.Trim();

        var rowItem = new[] { $"{DateTime.Now:t}", itemName, $"{amount:N2}" };
        var item = new ListViewItem(rowItem);

        PayoutsListView.Items.Add(item);

        PayOutItemTextBox.Text = string.Empty;
        PayOutAmountTextBox.Text = string.Empty;

        UpdateResults();
    }

    private void AddReceivedPayLaterPaymentButton_Click(object sender, EventArgs e)
    {
        if (!decimal.TryParse(ReceivedPayLaterAmountTextBox.Text.Trim(), out var amount))
        {
            MessageBox.Show("จำนวนเงินชำระหนี้ไม่ถูกต้อง", "เพิ่มรายการชำระหนี้ไม่สำเร็จ");
            return;
        }

        var name = PayLaterAccountNameTextBox.Text.Trim();

        var rowItem = new[] { $"{DateTime.Now:t}", name, $"{amount:N2}" };
        var item = new ListViewItem(rowItem);

        ReceivedPayLaterPaymentsListView.Items.Add(item);

        PayLaterAccountNameTextBox.Text = string.Empty;
        ReceivedPayLaterAmountTextBox.Text = string.Empty;

        UpdateResults();
    }

    private void RemoveChangeButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = ChangesListView.SelectedItems[0];

            ChangesListView.Items.Remove(item);

            RemoveChangeButton.Enabled = false;

            UpdateResults();
        }
        catch
        {
            RemoveChangeButton.Enabled = false;
        }
    }

    private void RemovePayOutItemButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = PayoutsListView.SelectedItems[0];

            PayoutsListView.Items.Remove(item);

            RemovePayOutButton.Enabled = false;

            UpdateResults();
        }
        catch
        {
            RemovePayOutButton.Enabled = false;
        }
    }

    private void RemoveReceivedPayLaterPaymentButton_Click(object sender, EventArgs e)
    {
        try
        {
            var item = ReceivedPayLaterPaymentsListView.SelectedItems[0];

            ReceivedPayLaterPaymentsListView.Items.Remove(item);

            RemoveReceivedPayLaterPaymentButton.Enabled = false;

            UpdateResults();
        }
        catch
        {
            RemoveReceivedPayLaterPaymentButton.Enabled = false;
        }
    }

    private void ChangesListView_Click(object sender, EventArgs e)
    {
        var items = ChangesListView.SelectedItems;

        RemoveChangeButton.Enabled = items.Count == 1;
    }

    private void PayOutListView_Click(object sender, EventArgs e)
    {
        var items = PayoutsListView.SelectedItems;

        RemovePayOutButton.Enabled = items.Count == 1;
    }

    private void ReceivedPayLaterPaymentsListView_Click(object sender, EventArgs e)
    {
        var items = ReceivedPayLaterPaymentsListView.SelectedItems;

        RemoveReceivedPayLaterPaymentButton.Enabled = items.Count == 1;
    }

    private void BankNote1000CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote1000CountTextBox.Text))
        {
            BankNote1000CountTextBox.Text = "0";
        }
    }

    private void BankNote500CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote500CountTextBox.Text))
        {
            BankNote500CountTextBox.Text = "0";
        }
    }

    private void BankNote100CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote100CountTextBox.Text))
        {
            BankNote100CountTextBox.Text = "0";
        }
    }

    private void BankNote50CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote50CountTextBox.Text))
        {
            BankNote50CountTextBox.Text = "0";
        }
    }

    private void BankNote20CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote20CountTextBox.Text))
        {
            BankNote20CountTextBox.Text = "0";
        }
    }

    private void Coin10CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin10CountTextBox.Text))
        {
            Coin10CountTextBox.Text = "0";
        }
    }

    private void Coin5CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin5CountTextBox.Text))
        {
            Coin5CountTextBox.Text = "0";
        }
    }

    private void Coin2CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin2CountTextBox.Text))
        {
            Coin2CountTextBox.Text = "0";
        }
    }

    private void Coin1CountTextBox_Leave(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin1CountTextBox.Text))
        {
            Coin1CountTextBox.Text = "0";
        }
    }

    private void DisplayBankNote1000Total(CashFlowData data)
    {
        BankNote1000CountTotalLabel.Text = $"{data.BankNote1000Total:N2}";
        BankNote1000CountTextBox.Text = data.BankNote1000Count.ToString();
    }

    private void DisplayBankNote500Total(CashFlowData data)
    {
        BankNote500CountTotalLabel.Text = $"{data.BankNote500Total:N2}";
        BankNote500CountTextBox.Text = data.BankNote500Count.ToString();
    }

    private void DisplayBankNote100Total(CashFlowData data)
    {
        BankNote100CountTotalLabel.Text = $"{data.BankNote100Total:N2}";
        BankNote100CountTextBox.Text = data.BankNote100Count.ToString();
    }

    private void DisplayBankNote50Total(CashFlowData data)
    {
        BankNote50CountTotalLabel.Text = $"{data.BankNote50Total:N2}";
        BankNote50CountTextBox.Text = data.BankNote50Count.ToString();
    }

    private void DisplayBankNote20Total(CashFlowData data)
    {
        BankNote20CountTotalLabel.Text = $"{data.BankNote20Total:N2}";
        BankNote20CountTextBox.Text = data.BankNote20Count.ToString();
    }

    private void DisplayCoin10Total(CashFlowData data)
    {
        Coin10CountTotalLabel.Text = $"{data.Coin10Total:N2}";
        Coin10CountTextBox.Text = data.Coin10Count.ToString();
    }

    private void DisplayCoin5Total(CashFlowData data)
    {
        Coin5CountTotalLabel.Text = $"{data.Coin5Total:N2}";
        Coin5CountTextBox.Text = data.Coin5Count.ToString();
    }

    private void DisplayCoin2Total(CashFlowData data)
    {
        Coin2CountTotalLabel.Text = $"{data.Coin2Total:N2}";
        Coin2CountTextBox.Text = data.Coin2Count.ToString();
    }

    private void DisplayCoin1Total(CashFlowData data)
    {
        Coin1CountTotalLabel.Text = $"{data.Coin1Total:N2}";
        Coin1CountTextBox.Text = data.Coin1Count.ToString();
    }

    private int GetBankNote1000Count()
    {
        return int.TryParse(BankNote1000CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetBankNote500Count()
    {
        return int.TryParse(BankNote500CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetBankNote100Count()
    {
        return int.TryParse(BankNote100CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetBankNote50Count()
    {
        return int.TryParse(BankNote50CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetBankNote20Count()
    {
        return int.TryParse(BankNote20CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetCoin10Count()
    {
        return int.TryParse(Coin10CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetCoin5Count()
    {
        return int.TryParse(Coin5CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetCoin2Count()
    {
        return int.TryParse(Coin2CountTextBox.Text, out var count) ? count : 0;
    }

    private int GetCoin1Count()
    {
        return int.TryParse(Coin1CountTextBox.Text, out var count) ? count : 0;
    }

    public void SetFormTitle(string version)
    {
        Text = $"IndyPOS Cash Flow v{version}";
    }

    private static bool IsValidCountNumber(string value)
    {
        return !string.IsNullOrWhiteSpace(value) && int.TryParse(value, out _);
    }

    private void BankNote1000CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote1000CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void BankNote500CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote500CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void BankNote100CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote100CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void BankNote50CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote50CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void BankNote20CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(BankNote20CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void Coin10CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin10CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void Coin5CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin5CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void Coin2CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin2CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void Coin1CountTextBox_TextChanged(object sender, EventArgs e)
    {
        if (!IsValidCountNumber(Coin1CountTextBox.Text)) { return; }

        UpdateResults();
    }

    private void ResetCountingButton_Click(object sender, EventArgs e)
	{
		var data = new CashFlowData();

        DisplayBankNote1000Total(data);
        DisplayBankNote500Total(data);
        DisplayBankNote100Total(data);
        DisplayBankNote50Total(data);
        DisplayBankNote20Total(data);
		DisplayCoin10Total(data);
        DisplayCoin5Total(data);
        DisplayCoin2Total(data);
        DisplayCoin1Total(data);
    }
}