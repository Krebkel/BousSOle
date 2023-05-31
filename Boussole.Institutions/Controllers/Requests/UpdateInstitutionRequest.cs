namespace Boussole.Institutions.Controllers.Requests;

public class UpdateInstitutionRequest
{
    public int Id { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string AdministratorTitle { get; set; }
    public string AdministratorName { get; set; }
    public string StructWebsite { get; set; }
}