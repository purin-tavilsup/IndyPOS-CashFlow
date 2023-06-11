using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoiceProducts.Queries.GetInvoiceProductsByDateRange;

public record GetInvoiceProductsByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<InvoiceProductDto>>;