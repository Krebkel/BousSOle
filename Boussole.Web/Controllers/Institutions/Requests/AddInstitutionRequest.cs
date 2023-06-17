using Boussole.Command.Contracts;
using Boussole.Institutions.Contracts;

namespace Boussole.Web.Controllers.Institutions.Requests;

public class AddInstitutionRequest
{
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string AdministratorTitle { get; set; }
    public string AdministratorSurname { get; set; }
    public string AdministratorName { get; set; }
    public string AdministratorPatronymic { get; set; }
    public string StructWebsite { get; set; }
    public Shtab Shtab { get; set; }
}