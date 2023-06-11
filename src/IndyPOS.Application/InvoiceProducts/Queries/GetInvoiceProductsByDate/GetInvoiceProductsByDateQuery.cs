using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoiceProducts.Queries.GetInvoiceProductsByDate;

public record GetInvoiceProductsByDateQuery(DateOnly Date) : IQuery<IEnumerable<InvoiceProductDto>>;