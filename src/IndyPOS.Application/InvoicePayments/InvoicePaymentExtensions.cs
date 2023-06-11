using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.InvoicePayments;

internal static class InvoicePaymentExtensions
{
	internal static InvoicePaymentDto ToDto(this Payment entity)
	{
		var dto = new InvoicePaymentDto
		{
			PaymentId = entity.PaymentId,
			InvoiceId = entity.InvoiceId,
			PaymentTypeId = entity.PaymentTypeId,
			Amount = entity.Amount,
			DateCreated = entity.DateCreated,
			Note = entity.Note
		};

		return dto;
	}
}