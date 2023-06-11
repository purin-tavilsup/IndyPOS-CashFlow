using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.InventoryProducts;

internal static class InventoryProductExtensions
{
	internal static InventoryProductDto ToDto(this InventoryProduct entity)
    {
        var dto = new InventoryProductDto
        {
            InventoryProductId = entity.InventoryProductId,
            Barcode = entity.Barcode,
            Description = entity.Description,
            Manufacturer = entity.Manufacturer,
            Brand = entity.Brand,
            Category = entity.Category,
            UnitPrice = entity.UnitPrice,
            QuantityInStock = entity.QuantityInStock,
            GroupPrice = entity.GroupPrice,
            GroupPriceQuantity = entity.GroupPriceQuantity,
			IsTrackable = entity.IsTrackable,
            DateCreated = entity.DateCreated,
            DateUpdated = entity.DateUpdated
        };

        return dto;
    }
}