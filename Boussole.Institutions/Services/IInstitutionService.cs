using Boussole.Institutions.Contracts;

namespace Boussole.Institutions.Services;

public interface IInstitutionService
{
    Task<Institution> CreateInstitutionAsync(Institution institution);

    Task UpdateInstitutionAsync(Institution institution);

    Task<Institution> GetInstitutionByIdAsync(int institutionId);
}