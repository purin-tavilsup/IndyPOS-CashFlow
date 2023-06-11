using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.Users.Queries.GetUsers;

public class GetUsersQueryHandler : IQueryHandler<GetUsersQuery, IEnumerable<UserDto>>
{
	private readonly IUserRepository _userRepository;

	public GetUsersQueryHandler(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public Task<IEnumerable<UserDto>> Handle(GetUsersQuery query, CancellationToken cancellationToken)
	{
		var results = _userRepository.GetAll();

		return Task.FromResult(results.Select(x => x.ToDto()));
	}
}