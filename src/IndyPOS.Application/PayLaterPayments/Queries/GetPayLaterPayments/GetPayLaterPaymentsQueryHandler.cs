using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.PayLaterPayments.Queries.GetPayLaterPayments;

public class GetPayLaterPaymentsQueryHandler : IQueryHandler<GetPayLaterPaymentsQuery, IEnumerable<PayLaterPaymentDto>>
{
	private readonly IPayLaterPaymentRepository _paymentRepository;

	public GetPayLaterPaymentsQueryHandler(IPayLaterPaymentRepository paymentRepository)
	{
		_paymentRepository = paymentRepository;
	}

	public Task<IEnumerable<PayLaterPaymentDto>> Handle(GetPayLaterPaymentsQuery query, CancellationToken cancellationToken)
	{
		var results = _paymentRepository.GetAll();

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}