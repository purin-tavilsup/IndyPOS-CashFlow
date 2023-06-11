namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class ProductNotFoundException : Exception
{
    public ProductNotFoundException(string message) : base(message) { }
}