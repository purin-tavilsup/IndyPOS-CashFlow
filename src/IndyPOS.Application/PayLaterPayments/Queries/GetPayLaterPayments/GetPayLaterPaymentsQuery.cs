using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.PayLaterPayments.Queries.GetPayLaterPayments;

public record GetPayLaterPaymentsQuery() : IQuery<IEnumerable<PayLaterPaymentDto>>;