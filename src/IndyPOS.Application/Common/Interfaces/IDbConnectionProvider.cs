using System.Data;

namespace IndyPOS.CashFlow.Application.Common.Interfaces;

public interface IDbConnectionProvider
{
	IDbConnection GetDbConnection();

	void BackupDatabase(string backupDatabaseDirectory);
}