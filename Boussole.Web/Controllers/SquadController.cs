using Boussole.LSO.Contracts.Structure;
using Boussole.LSO.Services.Structure;
using Boussole.Web.Controllers.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.LSO.Controllers;

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
    public IActionResult AddSquad([FromBody] AddSquadRequest request)
    {
        // Проверка и валидация данных request

        // Создание объекта Squad из данных request
        var squad = new Squad
        {
            Id = request.Id,
            Name = request.Name,
            Region = request.Region,
            VkUrl = request.VkUrl,
            InstitutionId = request.InstitutionId,
            SquadType = request.SquadType
        };

        // Создание отряда
        var squadId = _squadService.CreateSquad(squad);

        _logger.LogInformation("Отряд успешно добавлен: {@Squad}", squad.Id);

        // Возвращение результата
        return Ok(new { SquadId = squadId });
    }

    [HttpPost]
    public IActionResult UpdateSquad([FromBody] UpdateSquadRequest request)
    {
        // Проверка и валидация данных request

        // Обновление объекта Squad из данных request
        var squad = new Squad
        {
            Name = request.Name,
            Region = request.Region,
            VkUrl = request.VkUrl,
            Institution = request.Institution,
            SquadType = request.SquadType
        };

        // Обновление отряда
        _squadService.UpdateSquad(squad);

        _logger.LogInformation("Отряд успешно обновлен: {@Squad}", squad.Id);

        // Возвращение результата
        return Ok();
    }
}