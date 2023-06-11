using IndyPOS.CashFlow.Application.Common.Interfaces;
using Prism.Events;

namespace IndyPOS.CashFlow.Application.Events;

/// <summary>
/// Event for notifying a user has logged in.
/// </summary>
public class UserLoggedInEvent : PubSubEvent<ILoggedInUser>
{
}