namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class ProductNotDeletedException : Exception
{
    public ProductNotDeletedException(string message) : base(message) { }
}