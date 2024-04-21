using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Invoices;

internal static class InvoiceExtensions
{
	internal static InvoiceDto ToDto(this Invoice entity)
	{
		var dto = new InvoiceDto(entity.InvoiceId,
								 entity.Total,
								 entity.CustomerId,
								 entity.UserId,
								 entity.DateCreated);
		return dto;
	}
}