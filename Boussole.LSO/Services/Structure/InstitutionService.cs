using Boussole.LSO.Contracts.Structure;

namespace Boussole.LSO.Services.Structure;

public class InstitutionService : IInstitutionService
{
    public Institution CreateInstitution(Institution institution)
    {
        return institution;
    }

    public void UpdateInstitution(Institution institution)
    {
        
    }

    private int GenerateUniqueId()
    {
        var now = DateTimeOffset.UtcNow;
        var ticks = now.Ticks;
        var uniqueId = (int)(ticks & 0x00000000FFFFFFFF);

        return uniqueId;
    }
}