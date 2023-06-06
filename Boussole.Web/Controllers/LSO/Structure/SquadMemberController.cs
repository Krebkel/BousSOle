using Boussole.Core.Controllers.LSO.Structure.Requests;
using Boussole.Core.Extensions;
using Boussole.LSO.Services.Structure;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.LSO.Structure;

[ApiController]
[Route("api/squadmembers")]
public class SquadMemberController : ControllerBase
{
    private readonly ILogger<SquadMemberController> _logger;
    private readonly ISquadMemberService _squadMemberService;

    public SquadMemberController(ILogger<SquadMemberController> logger, ISquadMemberService squadMemberService)
    {
        _logger = logger;
        _squadMemberService = squadMemberService;
    }

    [HttpPost]
    public IActionResult AddSquadMember([FromBody] AddSquadMemberRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта SquadMember из данных request
            var squadMember = request.ToSquadMember();

            // Добавление бойца в отряд
            var squadMemberId = _squadMemberService.CreateSquadMember(squadMember);

            _logger.LogInformation("Боец успешно добавлен: {@Surname} {@Name} {@Patronymic}",
                squadMember.Person.Surname, squadMember.Person.Name, squadMember.Person.Patronymic);

            // Возвращение результата
            return Ok(new { SquadMemberId = squadMemberId });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении бойца в отряд");
            return BadRequest("Ошибка при добавлении бойца в отряд");
        }
    }

    [HttpPut]
    public IActionResult UpdateSquadMember([FromBody] UpdateSquadMemberRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Обновление объекта SquadMember из данных request
            var squadMember = request.ToSquadMember();

            // Обновление информации о бойце отряда
            _squadMemberService.UpdateSquadMember(squadMember);

            _logger.LogInformation("Боец успешно обновлен: {@Surname} {@Name} {@Patronymic}",
                squadMember.Person.Surname, squadMember.Person.Name, squadMember.Person.Patronymic);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при обновлении информации о бойце отряда");
            return BadRequest("Ошибка при обновлении информации о бойце отряда");
        }
    }
}