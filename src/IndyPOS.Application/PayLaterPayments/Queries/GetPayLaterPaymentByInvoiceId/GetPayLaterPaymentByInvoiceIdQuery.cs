using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.PayLaterPayments.Queries.GetPayLaterPaymentByInvoiceId;

public record GetPayLaterPaymentByInvoiceIdQuery(int InvoiceId) : IQuery<PayLaterPaymentDto>;