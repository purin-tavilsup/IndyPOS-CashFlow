using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.PayLaterPayments;

internal static class PayLaterPaymentExtensions
{
	internal static PayLaterPaymentDto ToDto(this PayLaterPayment entity)
	{
		var dto = new PayLaterPaymentDto(entity.PaymentId,
										 entity.Description,
										 entity.InvoiceId,
										 entity.PayLaterAmount,
										 entity.PaidAmount,
										 entity.IsCompleted,
										 entity.DateCreated,
										 entity.DateUpdated);
		return dto;
	}
}