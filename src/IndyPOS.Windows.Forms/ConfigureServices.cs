using IndyPOS.CashFlow.Windows.Forms;
using IndyPOS.CashFlow.Windows.Forms.Interfaces;
using IndyPOS.CashFlow.Windows.Forms.UI;
using System.Runtime.Versioning;

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

[type: SupportedOSPlatform("windows")]
internal static class ConfigureServices
{
	internal static IServiceCollection AddUIServices(this IServiceCollection services)
	{
		services.AddSingleton<MainForm>();

		services.AddSingleton<IMachine, Machine>();

		return services;
    }
}