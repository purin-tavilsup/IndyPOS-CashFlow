using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.Invoices.Queries.GetInvoicesByDate;

public record GetInvoicesByDateQuery(DateOnly Date) : IQuery<IEnumerable<InvoiceDto>>;