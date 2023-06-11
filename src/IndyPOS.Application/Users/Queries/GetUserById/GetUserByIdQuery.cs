using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.Users.Queries.GetUserById;

public record GetUserByIdQuery(int Id) : IQuery<UserDto>;