﻿namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IDateRange
{
	public DateOnly StartDate { get; }

	public DateOnly EndDate { get; }
}