using IndyPOS.CashFlow.Application.Common.Models;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IStoreConfigurationService
{
	Task<StoreConfiguration> GetAsync();

	StoreConfiguration Get();

	Task UpdateAsync(StoreConfiguration configuration);
}