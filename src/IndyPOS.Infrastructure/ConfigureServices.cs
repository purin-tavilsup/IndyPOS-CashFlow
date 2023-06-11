using IndyPOS.CashFlow.Application.Common.Interfaces;
using IndyPOS.CashFlow.Infrastructure.Constants;
using IndyPOS.CashFlow.Infrastructure.Persistence.Repositories.SQLite;
using IndyPOS.CashFlow.Infrastructure.Services;
using Prism.Events;
using System.Runtime.Versioning;

// ReSharper disable CheckNamespace
namespace Microsoft.Extensions.DependencyInjection;

[type: SupportedOSPlatform("windows")]
public static class ConfigureServices
{
	public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        // Persistence
        services.AddSingleton<IDbConnectionProvider, DbConnectionProvider>()
                .AddSingleton<IInvoiceRepository, InvoiceRepository>()
                .AddSingleton<IInvoiceProductRepository, InvoiceProductRepository>()
                .AddSingleton<IInvoicePaymentRepository, InvoicePaymentRepository>()
                .AddSingleton<IInventoryProductRepository, InventoryProductRepository>()
                .AddSingleton<IStoreConstantRepository, StoreConstantRepository>()
                .AddSingleton<IUserRepository, UserRepository>()
				.AddSingleton<IUserCredentialRepository, UserCredentialRepository>()
                .AddSingleton<IPayLaterPaymentRepository, PayLaterRepository>();

        services.AddSingleton<IStoreConstants, StoreConstants>()
				.AddSingleton<IStoreConfigurationService, StoreConfigurationService>()
				.AddSingleton<IEventAggregator, EventAggregator>()
				.AddSingleton<HttpClient, HttpClient>()
				.AddSingleton<IReportService, ReportService>();

		services.AddTransient<IJsonService, JsonService>()
				.AddTransient<IDateTimeService, DateTimeService>()
				.AddTransient<ICsvService, CsvService>();

		return services;
    }
}