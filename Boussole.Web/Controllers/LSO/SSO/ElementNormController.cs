using Boussole.Web.Controllers.LSO.SSO.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Web.Controllers.LSO.SSO;

[Authorize]
[ApiController]
[Route("api/elementnorms")]
public class ElementNormController : ControllerBase
{
    private readonly ILogger<ElementNormController> _logger;

    public ElementNormController(ILogger<ElementNormController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> AddElementNorm([FromBody] AddElementNormRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта ElementNorm из данных request
            // var elementNorm = request.ToElementNorm();
            //
            // // Создание элементной нормы
            // var createdElementNorm = await _elementNormService.CreateElementNormAsync(elementNorm);
            //
            // _logger.LogInformation("Элементная норма успешно добавлена: {@NormCollection} {@NormCode} {@NormName}",
            //     createdElementNorm.NormCollection, createdElementNorm.NormCode, createdElementNorm.NormName);

            // Возвращение результата
            return Ok();
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
            // var existingElementNorm = await _elementNormService.GetElementNormByIdAsync(elementNormId);
            //
            // if (existingElementNorm == null)
            // {
            //     return NotFound("Элементная норма не найдена");
            // }
            //
            // // Обновление объекта ElementNorm из данных request
            // var updatedElementNorm = request.ToUpdateElementNorm(existingElementNorm);
            //
            // // Обновление элементной нормы
            // await _elementNormService.UpdateElementNormAsync(updatedElementNorm);
            //
            // _logger.LogInformation("Элементная норма успешно обновлена: {@NormCollection} {@NormCode} {@NormName}",
            //     updatedElementNorm.NormCollection, updatedElementNorm.NormCode, updatedElementNorm.NormName);

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