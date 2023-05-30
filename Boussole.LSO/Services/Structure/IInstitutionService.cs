using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public interface IInstitutionService
{
    Institution CreateInstitution(Institution institution);
    void UpdateInstitution(Institution institution);
}