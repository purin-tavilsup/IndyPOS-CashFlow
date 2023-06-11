using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.Invoices.Queries.GetInvoicesByDateRange;

public record GetInvoicesByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<InvoiceDto>>;