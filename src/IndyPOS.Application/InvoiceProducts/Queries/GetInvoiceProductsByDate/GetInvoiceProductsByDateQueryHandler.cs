using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.InvoiceProducts.Queries.GetInvoiceProductsByDate;

public class GetInvoiceProductsByDateQueryHandler : IQueryHandler<GetInvoiceProductsByDateQuery, IEnumerable<InvoiceProductDto>>
{
	private readonly IInvoiceProductRepository _invoiceProductRepository;

	public GetInvoiceProductsByDateQueryHandler(IInvoiceProductRepository invoiceProductRepository)
	{
		_invoiceProductRepository = invoiceProductRepository;
	}

	public Task<IEnumerable<InvoiceProductDto>> Handle(GetInvoiceProductsByDateQuery query, CancellationToken cancellationToken)
	{
		var results = _invoiceProductRepository.GetByDate(query.Date);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}