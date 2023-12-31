﻿using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IInventoryProductRepository
{
	int Add(InventoryProduct product);

	InventoryProduct GetById(int id);

	InventoryProduct GetByBarcode(string barcode);

	IEnumerable<InventoryProduct> GetProductsByCategoryId(int id);

	bool Update(InventoryProduct product);

	bool UpdateProductQuantityById(int id, int quantity);

	bool RemoveById(int id);

	bool Remove(InventoryProduct product);

	int GetProductBarcodeCounter();

	bool UpdateProductBarcodeCounter(int counter);
}