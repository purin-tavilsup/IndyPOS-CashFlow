using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.UserCredentials.Queries.GetUserCredentialById;

public record GetUserCredentialByIdQuery(int Id) : IQuery<UserCredentialDto>;