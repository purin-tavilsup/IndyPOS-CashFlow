using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.InvoicePayments.Queries.GetInvoicePaymentsByDateRange;

public class GetInvoicePaymentsByDateRangeQueryHandler : IQueryHandler<GetInvoicePaymentsByDateRangeQuery, IEnumerable<InvoicePaymentDto>>
{
	private readonly IInvoicePaymentRepository _invoicePaymentRepository;

	public GetInvoicePaymentsByDateRangeQueryHandler(IInvoicePaymentRepository invoicePaymentRepository)
	{
		_invoicePaymentRepository = invoicePaymentRepository;
	}

	public Task<IEnumerable<InvoicePaymentDto>> Handle(GetInvoicePaymentsByDateRangeQuery query, CancellationToken cancellationToken)
	{
		var results = _invoicePaymentRepository.GetByDateRange(query.StartDate, query.EndDate);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}