using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InventoryProducts.Queries.GetInventoryProductsByCategoryId;

public record GetInventoryProductsByCategoryIdQuery(int CategoryId) : IQuery<IEnumerable<InventoryProductDto>>;