﻿using IndyPOS.CashFlow.Domain.Entities;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IUserCredentialRepository
{
	bool Add(UserCredential userCredential);

	UserCredential GetById(int id);

	UserCredential GetByUsername(string username);

	bool UpdatePassword(UserCredential userCredential);

	bool RemoveById(int userId);
}