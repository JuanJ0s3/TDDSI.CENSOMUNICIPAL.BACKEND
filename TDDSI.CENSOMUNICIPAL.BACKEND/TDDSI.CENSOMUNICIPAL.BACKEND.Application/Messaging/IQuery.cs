using MediatR;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Abstractions;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>> {

}