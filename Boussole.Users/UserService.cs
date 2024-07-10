using Boussole.DataContracts;
using Boussole.Persons;
using Boussole.Users.Requests;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Boussole.Users;

internal class UserService : IUserService
{

    private readonly IRepository<User> _userRepository;
    private readonly ILogger<UserService> _logger;
    private readonly IPersonService _personService; 


    public UserService(
        IRepository<User> userRepository,
        ILogger<UserService> logger,
        IPersonService personService)
    {
        _userRepository = userRepository;
        _logger = logger;
        _personService = personService; 
    }

    public async Task<User?> FindUser(string email, CancellationToken cancellationToken)
    {
        return await _userRepository.GetAll()
            .Include(u => u.Person)
            .Where(u => u.Person.EMail == email)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task Register(UserRegistrationRequest request, CancellationToken cancellationToken)
    {
        try
        {
            var createdPerson = await _personService.CreatePersonAsync(new CreatePersonRequest(), cancellationToken);

            var user = new User
            {
                Person = createdPerson,
                Password = request.Password
            };

            await _userRepository.AddAsync(user, cancellationToken);

            _logger.LogInformation("Новый пользователь успешно зарегистрирован: {@User}", user);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при регистрации пользователя");
            throw;
        }
    }
}