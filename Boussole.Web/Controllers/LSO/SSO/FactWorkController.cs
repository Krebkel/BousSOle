using Boussole.Core.Controllers.LSO.SSO.Requests;
using Boussole.Core.Extensions;
using Boussole.LSO.Services.SSO;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.LSO.SSO;

[ApiController]
[Route("api/factworks")]
public class FactWorkController : ControllerBase
{
    private readonly ILogger<FactWorkController> _logger;
    private readonly IFactWorkService _factWorkService;

    public FactWorkController(ILogger<FactWorkController> logger, IFactWorkService factWorkService)
    {
        _logger = logger;
        _factWorkService = factWorkService;
    }

    [HttpPost]
    public async Task<IActionResult> AddFactWork([FromBody] AddFactWorkRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта FactWork из данных request
            var factWork = request.ToFactWork();

            // Создание выполненного вида работ
            var createdFactWork = await _factWorkService.CreateFactWorkAsync(factWork);

            _logger.LogInformation("Выполненный вид работ успешно добавлен: {@Date} {@WorkName}",
                createdFactWork.Date, createdFactWork.WorkName);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении выполненного вида работ");
            return BadRequest("Ошибка при добавлении выполненного вида работ");
        }
    }

    [HttpPut("{factWorkId}")]
    public async Task<IActionResult> UpdateFactWork(int factWorkId, [FromBody] UpdateFactWorkRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Получение существующего выполненного вида работа по идентификатору
            var existingFactWork = await _factWorkService.GetFactWorkByIdAsync(factWorkId);

            if (existingFactWork == null)
            {
                return NotFound("Выполненный вид работ не найден");
            }

            // Обновление объекта FactWork из данных request
            var updatedFactWork = request.ToUpdateFactWork(existingFactWork);

            // Обновление выполненного вида работ
            await _factWorkService.UpdateFactWorkAsync(updatedFactWork);

            _logger.LogInformation("Выполненный вид работ успешно обновлен: {@Date} {@WorkName}",
                updatedFactWork.Date, updatedFactWork.WorkName);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при обновлении выполненного вида работ");
            return BadRequest("Ошибка при обновлении выполненного вида работ");
        }
    }
}