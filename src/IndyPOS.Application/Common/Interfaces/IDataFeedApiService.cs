using IndyPOS.CashFlow.Application.Common.Models.Report;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IDataFeedApiService
{
	Task PushInvoice(Invoice invoice);

	Task PushReport(SalesReport report);
}