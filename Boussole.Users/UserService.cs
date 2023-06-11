using Boussole.DataContracts;
using Microsoft.EntityFrameworkCore;

namespace Boussole.Users;

internal class UserService : IUserService
{
    private readonly IRepository<User> _users;

    public UserService(IRepository<User> users)
    {
        _users = users;
    }

    public async Task<User?> FindUser(string eMail, CancellationToken ct)
    {
        return await _users.GetAll()
            .Include(u => u.Person)
            .Where(u => u.Person.EMail == eMail)
            .FirstOrDefaultAsync(ct);
    }
}