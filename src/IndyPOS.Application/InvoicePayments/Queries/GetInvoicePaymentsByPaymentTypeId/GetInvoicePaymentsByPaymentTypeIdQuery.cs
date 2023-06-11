using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoicePayments.Queries.GetInvoicePaymentsByPaymentTypeId;

public record GetInvoicePaymentsByPaymentTypeIdQuery(int PaymentTypeId) : IQuery<IEnumerable<InvoicePaymentDto>>;