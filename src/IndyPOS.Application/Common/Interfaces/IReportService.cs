using IndyPOS.CashFlow.Application.Common.Enums;
using IndyPOS.CashFlow.Application.InvoicePayments;
using IndyPOS.CashFlow.Application.InvoiceProducts;
using IndyPOS.CashFlow.Application.Invoices;
using IndyPOS.CashFlow.Application.PayLaterPayments;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IReportService
{
	Task<ISalesReport> CreateSalesReportByPeriodAsync(TimePeriod period);

	Task<IPaymentsReport> CreatePaymentsReportByPeriodAsync(TimePeriod period);

	Task<IEnumerable<InvoiceDto>> GetInvoicesByPeriodAsync(TimePeriod period);

	Task<IEnumerable<PayLaterPaymentDto>> GetPayLaterPaymentsByPeriodAsync(TimePeriod period);

	Task<IEnumerable<InvoiceDto>> GetInvoicesByDateRangeAsync(DateOnly startDate, DateOnly endDate);

	Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByDateAsync(DateOnly date);

	Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByDateRangeAsync(DateOnly startDate, DateOnly endDate);

	Task<IEnumerable<InvoiceProductDto>> GetInvoiceProductsByInvoiceIdAsync(int invoiceId);

	Task<IEnumerable<InvoicePaymentDto>> GetPaymentsByInvoiceIdAsync(int invoiceId);

	Task<IEnumerable<PayLaterPaymentDto>> GetPayLaterPaymentsAsync();
}