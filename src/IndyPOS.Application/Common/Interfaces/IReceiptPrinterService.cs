namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IReceiptPrinterService
{
    void PrintReceipt(IInvoiceInfo invoiceInfo);
}