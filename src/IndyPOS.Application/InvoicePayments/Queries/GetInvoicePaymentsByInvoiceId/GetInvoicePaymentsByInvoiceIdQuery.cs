using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoicePayments.Queries.GetInvoicePaymentsByInvoiceId;

public record GetInvoicePaymentsByInvoiceIdQuery(int InvoiceId) : IQuery<IEnumerable<InvoicePaymentDto>>;