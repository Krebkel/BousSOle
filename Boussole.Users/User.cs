using Boussole.DataContracts;
using Boussole.Persons;

namespace Boussole.Users;

/// <summary>
/// Пользователь сервиса
/// </summary>
public class User : DatabaseEntity
{
    /// <summary>
    /// Физ-лицо
    /// </summary>
    public required Person Person { get; set; }

    /// <summary>
    /// Пароль TODO на хеш
    /// </summary>
    public required string Password { get; set; }
}