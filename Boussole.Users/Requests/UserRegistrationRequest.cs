using System.ComponentModel.DataAnnotations;

namespace Boussole.Users.Requests;

public class UserRegistrationRequest
{
    public required string PersonInn { get; set; }
    public required string Surname { get; set; }
    public required string Name { get; set; }
    public required string Patronymic { get; set; }
    public string? PhoneNumber { get; set; }
    public required string EMail { get; set; }
    
    [MinLength(8)]
    public required string Password { get; set; }
}