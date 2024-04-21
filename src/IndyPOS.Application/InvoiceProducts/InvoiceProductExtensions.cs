using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.InvoiceProducts;

internal static class InvoiceProductExtensions
{
	internal static InvoiceProductDto ToDto(this InvoiceProduct entity)
	{
		var dto = new InvoiceProductDto(entity.InvoiceProductId,
										entity.Priority,
										entity.InvoiceId,
										entity.InventoryProductId,
										entity.Barcode,
										entity.Description,
										entity.Manufacturer,
										entity.Brand,
										entity.Category,
										entity.UnitPrice,
										entity.Quantity,
										entity.DateCreated,
										entity.Note,
										entity.GroupPrice,
										entity.IsGroupProduct);
		return dto;
	}
}