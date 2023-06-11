using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.Invoices.Queries.GetInvoiceById;

public record GetInvoiceByIdQuery(int Id) : IQuery<InvoiceDto>;