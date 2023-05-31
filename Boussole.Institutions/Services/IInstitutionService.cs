using Boussole.Institutions.Contracts;

namespace Boussole.Institutions.Services;

public interface IInstitutionService
{
    Institution CreateInstitution(Institution institution);
    void UpdateInstitution(Institution institution);
}