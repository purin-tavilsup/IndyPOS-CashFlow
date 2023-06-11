using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Invoices;

internal static class InvoiceExtensions
{
	internal static InvoiceDto ToDto(this Invoice entity)
	{
		var dto = new InvoiceDto
		{
			InvoiceId = entity.InvoiceId,
			Total = entity.Total,
			CustomerId = entity.CustomerId,
			UserId = entity.UserId,
			DateCreated = entity.DateCreated
		};

		return dto;
	}
}