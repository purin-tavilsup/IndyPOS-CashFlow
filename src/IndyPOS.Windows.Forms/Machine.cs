using IndyPOS.CashFlow.Windows.Forms.Interfaces;
using IndyPOS.CashFlow.Windows.Forms.UI;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace IndyPOS.CashFlow.Windows.Forms;

[ExcludeFromCodeCoverage]
public class Machine : IMachine
{
	private readonly MainForm _mainForm;

	public Machine(MainForm mainForm)
	{
		_mainForm = mainForm;
	}

	public void Dispose()
	{
		Shutdown();
	}

	public void Launch()
	{
		try
		{
			StartUserInterface();
		}
		catch (Exception ex)
		{
			MessageBox.Show($"Error: {ex.Message}", "Unexpected error has occurred!");
		}
	}

	private static string GetVersion()
	{
		var assembly = System.Reflection.Assembly.GetExecutingAssembly();
		var versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);

		return versionInfo.FileVersion ?? "0.0.0";
	}

	private void Shutdown()
	{
		Console.WriteLine("IndyPOS is shutting down...");
	}

	private void StartUserInterface()
	{
		var version = GetVersion();

		_mainForm.SetFormTitle(version);

		System.Windows.Forms.Application.Run(_mainForm);
	}
}