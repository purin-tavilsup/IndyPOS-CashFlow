using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.InvoiceProducts.Queries.GetInvoiceProductsByDateRange;

public class GetInvoiceProductsByDateRangeQueryHandler : IQueryHandler<GetInvoiceProductsByDateRangeQuery, IEnumerable<InvoiceProductDto>>
{
	private readonly IInvoiceProductRepository _invoiceProductRepository;

	public GetInvoiceProductsByDateRangeQueryHandler(IInvoiceProductRepository invoiceProductRepository)
	{
		_invoiceProductRepository = invoiceProductRepository;
	}

	public Task<IEnumerable<InvoiceProductDto>> Handle(GetInvoiceProductsByDateRangeQuery query, CancellationToken cancellationToken)
	{
		var results = _invoiceProductRepository.GetByDateRange(query.StartDate, query.EndDate);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}