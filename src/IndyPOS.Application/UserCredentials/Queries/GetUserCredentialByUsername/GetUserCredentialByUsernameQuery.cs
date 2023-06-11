using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.UserCredentials.Queries.GetUserCredentialByUsername;

public record GetUserCredentialByUsernameQuery(string Username) : IQuery<UserCredentialDto>;