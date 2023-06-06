using Boussole.LSO.Contracts.SSO;

namespace Boussole.LSO.Repositories.SSO;

public interface IFactWorkRepository
{
    Task<FactWork> GetFactWorkByIdAsync(int factWorkId);
}
