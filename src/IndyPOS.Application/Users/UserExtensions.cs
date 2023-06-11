using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Users;

internal static class UserExtensions
{
	internal static UserDto ToDto(this UserAccount entity)
	{
		var dto = new UserDto
		{
			UserId = entity.UserId,
			FirstName = entity.FirstName,
			LastName = entity.LastName,
			RoleId = entity.RoleId,
			DateCreated = entity.DateCreated,
			DateUpdated = entity.DateUpdated
		};

		return dto;
	}
}