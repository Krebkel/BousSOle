using Boussole.Institutions.Contracts;
using Boussole.Web.Controllers.Institutions.Requests;

namespace Boussole.Web.Extensions;

internal static class InstitutionMappingExtensions
{
    public static Institution ToInstitution(this AddInstitutionRequest request)
    {
        var institution = new Institution
        {
            ShortName = request.ShortName,
            FullName = request.FullName,
            AdministratorTitle = request.AdministratorTitle,
            AdministratorSurname = request.AdministratorSurname,
            AdministratorName = request.AdministratorName,
            AdministratorPatronymic = request.AdministratorPatronymic,
            StructWebsite = request.StructWebsite
        };

        return institution;
    }

    public static Institution ToUpdateInstitution(this UpdateInstitutionRequest request, Institution existingInstitution)
    {
        existingInstitution.ShortName = request.ShortName;
        existingInstitution.FullName = request.FullName;
        existingInstitution.AdministratorTitle = request.AdministratorTitle;
        existingInstitution.AdministratorSurname = request.AdministratorSurname;
        existingInstitution.AdministratorName = request.AdministratorName;
        existingInstitution.AdministratorPatronymic = request.AdministratorPatronymic;
        existingInstitution.StructWebsite = request.StructWebsite;

        return existingInstitution;
    }
}