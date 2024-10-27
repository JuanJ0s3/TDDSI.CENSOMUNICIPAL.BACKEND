using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.DomainService;
using TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Ports;

namespace TDDSI.CENSOMUNICIPAL.BACKEND.Domain.Users;
[DomainService]
public class UserService(
    IUnitOfWork unitOfWork
) {

    public async Task<Guid> CreateUserAsync(
        User user,
        CancellationToken cancellationToken
    ) {
        ArgumentNullException.ThrowIfNull( nameof( user ) );

        await unitOfWork.Repository<User>()
            .AddAsync( user, cancellationToken );

        return user.Id;
    }
}
