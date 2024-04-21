using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.UserCredentials;

internal static class UserCredentialExtensions
{
	internal static UserCredentialDto ToDto(this UserCredential entity)
	{
		var dto = new UserCredentialDto(entity.UserId,
										entity.Username,
										entity.Password,
										entity.DateCreated,
										entity.DateUpdated);
		return dto;
	}
}