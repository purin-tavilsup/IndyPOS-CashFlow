using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InventoryProducts.Queries.GetInventoryProductById;

public record GetInventoryProductByIdQuery(int Id) : IQuery<InventoryProductDto>;