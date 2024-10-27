using MediatR;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
public interface ICommand : IRequest<Result>, IBaseCommand {

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand {

}