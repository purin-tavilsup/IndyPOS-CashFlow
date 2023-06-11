namespace IndyPOS.CashFlow.Application.Common.Exceptions;

public class PayLaterPaymentNotFoundException : Exception
{
    public PayLaterPaymentNotFoundException(string message) : base(message) { }
}