using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.UserCredentials;

internal static class UserCredentialExtensions
{
	internal static UserCredentialDto ToDto(this UserCredential entity)
	{
		var dto = new UserCredentialDto
		{
			UserId = entity.UserId,
			Username = entity.Username,
			Password = entity.Password,
			DateCreated = entity.DateCreated,
			DateUpdated = entity.DateUpdated
		};

		return dto;
	}
}