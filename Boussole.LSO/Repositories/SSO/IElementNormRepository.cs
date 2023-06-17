using Boussole.LSO.Contracts.SSO;

namespace Boussole.LSO.Repositories.SSO;

public interface IElementNormRepository
{
    Task<ElementNorm> GetElementNormByIdAsync(int elementNormId);
}