using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InventoryProducts.Queries.GetInventoryProductBarcodeCounter;

public record GetInventoryProductBarcodeCounterQuery() : IQuery<int>;