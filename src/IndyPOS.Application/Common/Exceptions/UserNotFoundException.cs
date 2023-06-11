namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class UserNotFoundException : Exception
{
    public UserNotFoundException(string message) : base(message) { }
}