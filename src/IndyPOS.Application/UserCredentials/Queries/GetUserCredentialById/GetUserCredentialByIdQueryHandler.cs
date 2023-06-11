using IndyPOS.CashFlow.Application.Abstractions.Messaging;
using IndyPOS.CashFlow.Application.Common.Interfaces;

namespace IndyPOS.CashFlow.Application.UserCredentials.Queries.GetUserCredentialById;

public class GetUserCredentialByIdQueryHandler : IQueryHandler<GetUserCredentialByIdQuery, UserCredentialDto>
{
	private readonly IUserCredentialRepository _userCredentialRepository;

	public GetUserCredentialByIdQueryHandler(IUserCredentialRepository userCredentialRepository)
	{
		_userCredentialRepository = userCredentialRepository;
	}

	public Task<UserCredentialDto> Handle(GetUserCredentialByIdQuery query, CancellationToken cancellationToken)
	{
		var result = _userCredentialRepository.GetById(query.Id);

		return Task.FromResult(result.ToDto());
	}
}