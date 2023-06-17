using Boussole.LSO.Services.Structure;
using Boussole.Web.Controllers.LSO.Structure.Requests;
using Boussole.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Web.Controllers.LSO.Structure;

[Authorize]
[ApiController]
[Route("api/squads")]
public class SquadController : ControllerBase
{
    private readonly ILogger<SquadController> _logger;
    private readonly ISquadService _squadService;

    public SquadController(ILogger<SquadController> logger, ISquadService squadService)
    {
        _logger = logger;
        _squadService = squadService;
    }

    [HttpPost]
    public async Task<IActionResult> AddSquad([FromBody] AddSquadRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта Squad из данных request
            var squad = request.ToSquad();

            // Создание отряда
            var createdSquad = await _squadService.CreateSquadAsync(squad);

            _logger.LogInformation("Отряд успешно добавлен: {@Name} {@Region}", createdSquad.Name, createdSquad.Shtab.Region);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении отряда");
            return BadRequest("Ошибка при добавлении отряда");
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdateSquad([FromBody] UpdateSquadRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Получение существующего отряда из базы данных, например по его идентификатору
            var existingSquad = await _squadService.GetSquadByIdAsync(request.SquadId);

            if (existingSquad == null)
            {
                // Возвращение ошибки, если отряд не найден
                return NotFound();
            }

            // Обновление объекта Squad из данных request
            var updatedSquad = request.ToUpdateSquad(existingSquad);

            // Обновление отряда
            await _squadService.UpdateSquadAsync(updatedSquad);

            _logger.LogInformation("Отряд успешно обновлен: {@Name} {@Region}", updatedSquad.Name, updatedSquad.Shtab.Region);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при обновлении отряда");
            return BadRequest("Ошибка при обновлении отряда");
        }
    }
}