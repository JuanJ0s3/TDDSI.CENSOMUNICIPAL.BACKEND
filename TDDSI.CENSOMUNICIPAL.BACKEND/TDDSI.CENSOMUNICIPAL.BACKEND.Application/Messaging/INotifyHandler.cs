using MediatR;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Application.Messaging;
public interface INotifyHandler<TCommand> : INotificationHandler<TCommand>
where TCommand : INotify {

}
