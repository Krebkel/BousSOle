namespace Boussole.Web.Controllers.Persons.Requests;

public class AddPersonApiRequest
{
    public int PersonInn { get; set; }
    
    public required string Surname { get; set; }
    
    public required string Name { get; set; }
    
    public required string Patronymic { get; set; }
    
    public required string PhoneNumber { get; set; }
    
    public required string EMail { get; set; }
}