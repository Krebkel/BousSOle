namespace Boussole.Web.Controllers.Tokens;

public class UserCredentialsRequest
{
    public required string EMail { get; set; }
    
    public required string Password { get; set; }
}