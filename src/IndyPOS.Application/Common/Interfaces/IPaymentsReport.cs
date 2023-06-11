namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IPaymentsReport
{
	public decimal Cash { get; set; }

	public decimal MoneyTransferTotal { get; set; }

	public decimal FiftyFiftyTotal { get; set; }

	public decimal M33WeLoveTotal { get; set; }

	public decimal WeWinTotal { get; set; }

	public decimal WelfareCardTotal { get; set; }

	public decimal PayLaterTotal { get; set; }
}