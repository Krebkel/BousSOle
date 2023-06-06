using Boussole.Core.Controllers.LSO.SSO.Requests;
using Boussole.Core.Extensions;
using Boussole.LSO.Services.SSO;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.LSO.SSO;

[ApiController]
[Route("api/elementnorms")]
public class ElementNormController : ControllerBase
{
    private readonly ILogger<ElementNormController> _logger;
    private readonly IElementNormService _elementNormService;

    public ElementNormController(ILogger<ElementNormController> logger, IElementNormService elementNormService)
    {
        _logger = logger;
        _elementNormService = elementNormService;
    }

    [HttpPost]
    public async Task<IActionResult> AddElementNorm([FromBody] AddElementNormRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта ElementNorm из данных request
            var elementNorm = request.ToElementNorm();

            // Создание элементной нормы
            var createdElementNorm = await _elementNormService.CreateElementNormAsync(elementNorm);

            _logger.LogInformation("Элементная норма успешно добавлена: {@NormCollection} {@NormCode} {@NormName}",
                createdElementNorm.NormCollection, createdElementNorm.NormCode, createdElementNorm.NormName);

            // Возвращение результата
            return Ok(new { ElementNormId = createdElementNorm.Id });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении элементной нормы");
            return BadRequest("Ошибка при добавлении элементной нормы");
        }
    }

    [HttpPut("{elementNormId}")]
    public async Task<IActionResult> UpdateElementNorm(int elementNormId, [FromBody] UpdateElementNormRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Получение существующей элементной нормы по идентификатору
            var existingElementNorm = await _elementNormService.GetElementNormByIdAsync(elementNormId);

            if (existingElementNorm == null)
            {
                return NotFound("Элементная норма не найдена");
            }

            // Обновление объекта ElementNorm из данных request
            var updatedElementNorm = request.ToUpdateElementNorm(existingElementNorm);

            // Обновление элементной нормы
            await _elementNormService.UpdateElementNormAsync(updatedElementNorm);

            _logger.LogInformation("Элементная норма успешно обновлена: {@NormCollection} {@NormCode} {@NormName}",
                updatedElementNorm.NormCollection, updatedElementNorm.NormCode, updatedElementNorm.NormName);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при обновлении элементной нормы");
            return BadRequest("Ошибка при обновлении элементной нормы");
        }
    }
}