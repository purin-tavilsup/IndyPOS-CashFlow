namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class InvoiceNotFoundException : Exception
{
    public InvoiceNotFoundException(string message) : base(message) { }
}