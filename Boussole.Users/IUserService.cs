using Boussole.Users.Requests;

namespace Boussole.Users;

public interface IUserService
{
    Task<User?> FindUser(string email, CancellationToken cancellationToken);
    
    Task Register(UserRegistrationRequest request, CancellationToken cancellationToken);

}