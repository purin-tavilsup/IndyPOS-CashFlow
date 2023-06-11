using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InventoryProducts.Queries.GetInventoryProductByBarcode;

public record GetInventoryProductByBarcodeQuery(string Barcode) : IQuery<InventoryProductDto>;