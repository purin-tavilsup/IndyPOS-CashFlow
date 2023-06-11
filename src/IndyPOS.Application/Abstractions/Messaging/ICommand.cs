using MediatR;

namespace IndyPOS.CashFlow.Application.Abstractions.Messaging;

public interface ICommand : IRequest
{
}

public interface ICommand<out TResponse> : IRequest<TResponse>
{
}