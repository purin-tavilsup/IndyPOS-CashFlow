﻿using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.Invoices.Queries.GetInvoicesByDate;

public class GetInvoicesByDateQueryHandler : IQueryHandler<GetInvoicesByDateQuery, IEnumerable<InvoiceDto>>
{
	private readonly IInvoiceRepository _invoiceRepository;

	public GetInvoicesByDateQueryHandler(IInvoiceRepository invoiceRepository)
	{
		_invoiceRepository = invoiceRepository;
	}

	public Task<IEnumerable<InvoiceDto>> Handle(GetInvoicesByDateQuery query, CancellationToken cancellationToken)
	{
		var results = _invoiceRepository.GetByDate(query.Date);

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}