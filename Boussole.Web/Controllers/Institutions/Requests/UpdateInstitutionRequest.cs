namespace Boussole.Core.Controllers.Institutions.Requests;

public class UpdateInstitutionRequest
{
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string AdministratorTitle { get; set; }
    public string AdministratorName { get; set; }
    public string StructWebsite { get; set; }
}