using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.InvoiceProducts;

internal static class InvoiceProductExtensions
{
	internal static InvoiceProductDto ToDto(this InvoiceProduct entity)
	{
		var dto = new InvoiceProductDto
		{
			InvoiceProductId = entity.InvoiceProductId,
			Priority = entity.Priority,
			InvoiceId = entity.InvoiceId,
			InventoryProductId = entity.InventoryProductId,
			Barcode = entity.Barcode,
			Description = entity.Description,
			Manufacturer = entity.Manufacturer,
			Brand = entity.Brand,
			Category = entity.Category,
			UnitPrice = entity.UnitPrice,
			Quantity = entity.Quantity,
			DateCreated = entity.DateCreated,
			Note = entity.Note
		};

		return dto;
	}
}