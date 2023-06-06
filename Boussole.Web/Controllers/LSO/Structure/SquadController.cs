using Boussole.Core.Controllers.LSO.Structure.Requests;
using Boussole.Core.Extensions;
using Boussole.LSO.Services.Structure;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.LSO.Structure;

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
        // Проверка и валидация данных request

        // Создание объекта Squad из данных request
        var squad = request.ToSquad();

        // Создание отряда
        var createdSquad = await _squadService.CreateSquadAsync(squad);

        _logger.LogInformation("Отряд успешно добавлен: {@Name} {@Region}", createdSquad.Name, createdSquad.Region);

        // Возвращение результата
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> UpdateSquad([FromBody] UpdateSquadRequest request)
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

        _logger.LogInformation("Отряд успешно обновлен: {@Name} {@Region}", updatedSquad.Name, updatedSquad.Region);

        // Возвращение результата
        return Ok();
    }
}