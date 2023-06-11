using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.InvoicePayments.Queries.GetInvoicePaymentsByInvoiceId;

public class GetInvoicePaymentsByInvoiceIdQueryHandler : IQueryHandler<GetInvoicePaymentsByInvoiceIdQuery, IEnumerable<InvoicePaymentDto>>
{
	private readonly IInvoicePaymentRepository _invoicePaymentRepository;

	public GetInvoicePaymentsByInvoiceIdQueryHandler(IInvoicePaymentRepository invoicePaymentRepository)
	{
		_invoicePaymentRepository = invoicePaymentRepository;
	}

	public Task<IEnumerable<InvoicePaymentDto>> Handle(GetInvoicePaymentsByInvoiceIdQuery query, CancellationToken cancellationToken)
	{
		var results = _invoicePaymentRepository.GetByInvoiceId(query.InvoiceId);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}