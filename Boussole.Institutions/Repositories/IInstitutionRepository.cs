using Boussole.Institutions.Contracts;

namespace Boussole.Institutions.Repositories;

public interface IInstitutionRepository
{
    Task<Institution> GetInstitutionByIdAsync(int institutionId);
}