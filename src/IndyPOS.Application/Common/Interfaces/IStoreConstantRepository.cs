using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IStoreConstantRepository
{
	IEnumerable<UserRole> GetUserRoles();

	IEnumerable<PaymentType> GetPaymentTypes();

	IEnumerable<ProductCategory> GetProductCategories();
}