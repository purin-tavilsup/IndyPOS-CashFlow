using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoicePayments.Queries.GetInvoicePaymentsByDate;

public record GetInvoicePaymentsByDateQuery(DateOnly Date) : IQuery<IEnumerable<InvoicePaymentDto>>;