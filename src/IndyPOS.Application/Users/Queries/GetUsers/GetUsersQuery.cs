using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.Users.Queries.GetUsers;

public record GetUsersQuery() : IQuery<IEnumerable<UserDto>>;