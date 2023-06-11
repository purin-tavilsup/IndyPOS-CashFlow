using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.PayLaterPayments.Queries.GetPayLaterPaymentsByDateRange;

public record GetPayLaterPaymentsByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<PayLaterPaymentDto>>;