using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.InventoryProducts;

internal static class InventoryProductExtensions
{
    internal static InventoryProductDto ToDto(this InventoryProduct entity)
    {
        var dto = new InventoryProductDto(entity.InventoryProductId,
                                          entity.Barcode,
                                          entity.Description,
                                          entity.Manufacturer,
                                          entity.Brand,
                                          entity.Category,
                                          entity.UnitPrice,
                                          entity.QuantityInStock,
                                          entity.GroupPrice,
                                          entity.GroupPriceQuantity,
                                          entity.IsTrackable,
                                          entity.DateCreated,
                                          entity.DateUpdated);
        return dto;
    }
}