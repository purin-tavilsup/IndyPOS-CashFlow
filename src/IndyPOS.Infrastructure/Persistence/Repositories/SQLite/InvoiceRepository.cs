﻿using Dapper;
using IndyPOS.CashFlow.Application.Common.Exceptions;
using IndyPOS.CashFlow.Application.Common.Interfaces;
using IndyPOS.CashFlow.Domain.Entities;
using IndyPOS.CashFlow.Infrastructure.Extensions;

namespace IndyPOS.CashFlow.Infrastructure.Persistence.Repositories.SQLite;

public class InvoiceRepository : IInvoiceRepository
{
    private readonly IDbConnectionProvider _dbConnectionProvider;

    public InvoiceRepository(IDbConnectionProvider dbConnectionProvider)
    {
        _dbConnectionProvider = dbConnectionProvider;
    }

    public int Add(Invoice invoice)
    {
        using var connection = _dbConnectionProvider.GetDbConnection();
        connection.Open();

        const string sqlCommand = @"INSERT INTO Invoices
                (
                    Total,
                    CustomerId,
                    UserId,
                    DateCreated
                )
                VALUES
                (
                    @Total,
                    @CustomerId,
                    @UserId,
                    datetime('now','localtime')
                );
                SELECT last_insert_rowid()";

        var sqlParameters = new
        {
            Total = invoice.Total.ToMoneyString(),
            invoice.CustomerId,
            invoice.UserId
        };

        var invoiceId = connection.Query<int>(sqlCommand, sqlParameters)
                                  .FirstOrDefault();

        return invoiceId;
    }

    public Invoice GetById(int id)
    {
        using var connection = _dbConnectionProvider.GetDbConnection();
        connection.Open();

        const string sqlCommand = @"SELECT * FROM Invoices WHERE InvoiceId = @invoiceId";

        var sqlParameters = new
        {
            invoiceId = id
        };

        var result = connection.Query(sqlCommand, sqlParameters)
                               .FirstOrDefault();

		if (result is null)
		{
			throw new InvoiceNotFoundException($"Could not find Invoice by ID: {id}");
		}

        return MapInvoice(result);
    }

    public IEnumerable<Invoice> GetByDateRange(DateOnly start, DateOnly end)
    {
        using var connection = _dbConnectionProvider.GetDbConnection();
        connection.Open();

        const string sqlCommand = @"SELECT * FROM Invoices WHERE DateCreated BETWEEN @startDate AND @endDate";

        var sqlParameters = new
        {
            startDate = start.ToStartDateString(),
            endDate = end.ToEndDateString()
        };

        var results = connection.Query(sqlCommand, sqlParameters);

        return results is null ? Enumerable.Empty<Invoice>() : MapInvoices(results);
    }

    public IEnumerable<Invoice> GetByDate(DateOnly date)
    {
        return GetByDateRange(date, date);
    }

	public bool RemoveById(int id)
	{
		return RemoveByIdInternal(id);
	}

	private bool RemoveByIdInternal(int id)
	{
		using var connection = _dbConnectionProvider.GetDbConnection();
		connection.Open();

		const string sqlCommand = @"DELETE FROM Invoices WHERE InvoiceId = @InvoiceId";

		var sqlParameters = new
		{
			InvoiceId = id
		};

		var affectedRowsCount = connection.Execute(sqlCommand, sqlParameters);

		return affectedRowsCount == 1;
	}

    private static Invoice MapInvoice(dynamic result)
    {
        var invoice = new Invoice
        {
            InvoiceId = (int)result.InvoiceId,
            Total = ((string)result.Total).ToMoney(),
            CustomerId = (int?)result.CustomerId,
            UserId = (int)result.UserId,
            DateCreated = result.DateCreated
        };

        return invoice;
    }

    private static IEnumerable<Invoice> MapInvoices(IEnumerable<dynamic> results)
    {
        return results.Select(MapInvoice);
    }
}