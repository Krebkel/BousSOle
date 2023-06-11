namespace Boussole.Users;

public interface IUserService
{ 
    public Task<User?> FindUser(string eMail, CancellationToken ct);
}