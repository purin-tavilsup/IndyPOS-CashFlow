﻿using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IInvoicePaymentRepository
{
	int Add(Payment payment);

	bool RemoveById(int id);

	bool RemoveByInvoiceId(int id);

	IEnumerable<Payment> GetByInvoiceId(int id);

	IEnumerable<Payment> GetByDateRange(DateOnly start, DateOnly end);

	IEnumerable<Payment> GetByDate(DateOnly date);

	IEnumerable<Payment> GetByPaymentTypeId(int id);
}