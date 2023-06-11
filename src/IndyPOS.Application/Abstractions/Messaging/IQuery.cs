using MediatR;

namespace IndyPOS.CashFlow.Application.Abstractions.Messaging;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}