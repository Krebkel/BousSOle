namespace Boussole.Web.Controllers.Persons.Requests;

public class UpdatePersonApiRequest
{
    public int PersonInn { get; set; }
    
    public string? Surname { get; set; }
    
    public string? Name { get; set; }
    
    public string? Patronymic { get; set; }
    
    public string? PhoneNumber { get; set; }
    
    public string? EMail { get; set; }
}