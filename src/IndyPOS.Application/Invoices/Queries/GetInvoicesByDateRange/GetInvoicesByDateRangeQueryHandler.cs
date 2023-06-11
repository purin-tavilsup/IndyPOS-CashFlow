using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.Invoices.Queries.GetInvoicesByDateRange;

public class GetInvoicesByDateRangeQueryHandler : IQueryHandler<GetInvoicesByDateRangeQuery, IEnumerable<InvoiceDto>>
{
	private readonly IInvoiceRepository _invoiceRepository;

	public GetInvoicesByDateRangeQueryHandler(IInvoiceRepository invoiceRepository)
	{
		_invoiceRepository = invoiceRepository;
	}

	public Task<IEnumerable<InvoiceDto>> Handle(GetInvoicesByDateRangeQuery query, CancellationToken cancellationToken)
	{
		var results = _invoiceRepository.GetByDateRange(query.StartDate, query.EndDate);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}