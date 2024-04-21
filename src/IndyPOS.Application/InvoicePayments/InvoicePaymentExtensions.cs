using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.InvoicePayments;

internal static class InvoicePaymentExtensions
{
	internal static InvoicePaymentDto ToDto(this Payment entity)
	{
		var dto = new InvoicePaymentDto(entity.PaymentId,
										entity.InvoiceId,
										entity.PaymentTypeId,
										entity.Amount,
										entity.DateCreated,
										entity.Note);
		return dto;
	}
}