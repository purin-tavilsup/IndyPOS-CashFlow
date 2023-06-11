namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class UserCredentialNotUpdatedException : Exception
{
    public UserCredentialNotUpdatedException(string message) : base(message) { }
}