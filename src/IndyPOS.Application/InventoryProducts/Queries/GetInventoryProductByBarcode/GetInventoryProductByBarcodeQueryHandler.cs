using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.InventoryProducts.Queries.GetInventoryProductByBarcode;

public class GetInventoryProductByBarcodeQueryHandler : IQueryHandler<GetInventoryProductByBarcodeQuery, InventoryProductDto>
{
	private readonly IInventoryProductRepository _productRepository;

	public GetInventoryProductByBarcodeQueryHandler(IInventoryProductRepository productRepository)
	{
		_productRepository = productRepository;
	}

	public Task<InventoryProductDto> Handle(GetInventoryProductByBarcodeQuery query, CancellationToken cancellationToken)
	{
		var barcode = query.Barcode;
		var result = _productRepository.GetByBarcode(barcode);

		return Task.FromResult(result.ToDto());
	}
}