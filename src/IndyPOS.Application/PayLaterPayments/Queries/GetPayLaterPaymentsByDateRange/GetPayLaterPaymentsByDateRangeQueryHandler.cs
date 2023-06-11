using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.PayLaterPayments.Queries.GetPayLaterPaymentsByDateRange;

public class GetPayLaterPaymentsByDateRangeQueryHandler : IQueryHandler<GetPayLaterPaymentsByDateRangeQuery, IEnumerable<PayLaterPaymentDto>>
{
	private readonly IPayLaterPaymentRepository _paymentRepository;

	public GetPayLaterPaymentsByDateRangeQueryHandler(IPayLaterPaymentRepository paymentRepository)
	{
		_paymentRepository = paymentRepository;
	}

	public Task<IEnumerable<PayLaterPaymentDto>> Handle(GetPayLaterPaymentsByDateRangeQuery query, CancellationToken cancellationToken)
	{
		var results = _paymentRepository.GetPayLaterPaymentsByDateRange(query.StartDate, query.EndDate);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}