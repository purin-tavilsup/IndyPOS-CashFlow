using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Users;

internal static class UserExtensions
{
	internal static UserDto ToDto(this UserAccount entity)
	{
		var dto = new UserDto(entity.UserId, 
							  entity.FirstName, 
							  entity.LastName, 
							  entity.RoleId, 
							  entity.DateCreated, 
							  entity.DateUpdated);
		return dto;
	}
}