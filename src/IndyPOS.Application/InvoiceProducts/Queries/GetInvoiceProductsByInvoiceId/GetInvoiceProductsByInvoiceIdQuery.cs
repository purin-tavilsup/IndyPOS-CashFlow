using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoiceProducts.Queries.GetInvoiceProductsByInvoiceId;

public record GetInvoiceProductsByInvoiceIdQuery(int InvoiceId) : IQuery<IEnumerable<InvoiceProductDto>>;