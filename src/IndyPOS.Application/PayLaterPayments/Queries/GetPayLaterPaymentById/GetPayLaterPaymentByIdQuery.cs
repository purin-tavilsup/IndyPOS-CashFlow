using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.PayLaterPayments.Queries.GetPayLaterPaymentById;

public record GetPayLaterPaymentByIdQuery(int Id) : IQuery<PayLaterPaymentDto>;