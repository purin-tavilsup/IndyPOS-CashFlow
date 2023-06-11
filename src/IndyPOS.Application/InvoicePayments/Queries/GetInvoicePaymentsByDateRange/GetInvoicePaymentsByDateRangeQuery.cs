using IndyPOS.CashFlow.Application.Abstractions.Messaging;

namespace IndyPOS.CashFlow.Application.InvoicePayments.Queries.GetInvoicePaymentsByDateRange;

public record GetInvoicePaymentsByDateRangeQuery(DateOnly StartDate, DateOnly EndDate) : IQuery<IEnumerable<InvoicePaymentDto>>;