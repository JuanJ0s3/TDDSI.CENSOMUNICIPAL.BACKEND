using MediatR;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
where TCommand : ICommand {

}

public interface ICommandHandler<TCommand, TResponse>
: IRequestHandler<TCommand, Result<TResponse>>
where TCommand : ICommand<TResponse> {

}