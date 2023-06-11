namespace Boussole.Web.Controllers.Institutions.Requests;

public class UpdateInstitutionRequest
{
    public int InstitutionId { get; set; }
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string AdministratorTitle { get; set; }
    public string AdministratorSurname { get; set; }
    public string AdministratorName { get; set; }
    public string AdministratorPatronymic { get; set; }
    public string StructWebsite { get; set; }
}