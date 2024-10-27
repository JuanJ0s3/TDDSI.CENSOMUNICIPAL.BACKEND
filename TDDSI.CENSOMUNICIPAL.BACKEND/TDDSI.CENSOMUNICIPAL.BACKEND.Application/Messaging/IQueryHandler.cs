using MediatR;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
public interface IQueryHandler<TQuery, TResponse>
: IRequestHandler<TQuery, Result<TResponse>>
where TQuery : IQuery<TResponse> {

}
