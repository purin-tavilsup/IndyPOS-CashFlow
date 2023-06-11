namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class UserNotLoggedInException : Exception
{
    public UserNotLoggedInException(string message) : base(message) { }
}