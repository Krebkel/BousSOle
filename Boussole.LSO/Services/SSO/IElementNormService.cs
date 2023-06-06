using Boussole.LSO.Contracts.SSO;

namespace Boussole.LSO.Services.SSO;

public interface IElementNormService
{
    Task<ElementNorm> CreateElementNormAsync(ElementNorm elementNorm);
    Task UpdateElementNormAsync(ElementNorm elementNorm);
    Task<ElementNorm> GetElementNormByIdAsync(int elementNormId);
}