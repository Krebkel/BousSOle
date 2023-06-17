using Boussole.LSO.Contracts.SSO;

namespace Boussole.LSO.Services.SSO;

public interface IFactWorkService
{
    Task<FactWork> CreateFactWorkAsync(FactWork factWork);
    Task UpdateFactWorkAsync(FactWork factWork);
    Task<FactWork> GetFactWorkByIdAsync(int factWorkId);
}