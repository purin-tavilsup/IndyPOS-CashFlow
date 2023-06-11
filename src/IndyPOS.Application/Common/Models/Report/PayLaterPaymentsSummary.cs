using System.Diagnostics.CodeAnalysis;

namespace IndyPOS.CashFlow.Application.Common.Models.Report;

[ExcludeFromCodeCoverage]
public class PayLaterPaymentsSummary
{
    public double Total { get; set; }
    public double CompletedPaymentsTotal { get; set; }
    public double IncompletePaymentsTotal { get; set; }
}