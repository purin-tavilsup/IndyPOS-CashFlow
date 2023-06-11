using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.PayLaterPayments;

internal static class PayLaterPaymentExtensions
{
	internal static PayLaterPaymentDto ToDto(this PayLaterPayment entity)
	{
		var dto = new PayLaterPaymentDto
		{
			PaymentId = entity.PaymentId,
			Description = entity.Description,
			InvoiceId = entity.InvoiceId,
			ReceivableAmount = entity.ReceivableAmount,
			PaidAmount = entity.PaidAmount,
			IsCompleted = entity.IsCompleted,
			DateCreated = entity.DateCreated,
			DateUpdated = entity.DateUpdated
		};

		return dto;
	}
}