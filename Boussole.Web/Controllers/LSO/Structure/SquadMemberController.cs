using Boussole.Web.Controllers.LSO.Structure.Requests;
using Boussole.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Web.Controllers.LSO.Structure;

[Authorize]
[ApiController]
[Route("api/squadmembers")]
public class SquadMemberController : ControllerBase
{
    private readonly ILogger<SquadMemberController> _logger;

    public SquadMemberController(ILogger<SquadMemberController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult AddSquadMember([FromBody] AddSquadMemberRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта SquadMember из данных request
            var squadMember = request.ToSquadMember();
            //
            // // Добавление бойца в отряд
            // var squadMemberId = _squadMemberService.CreateSquadMember(squadMember);
            //
            // _logger.LogInformation("Боец успешно добавлен: {@Surname} {@Name} {@Patronymic}",
            //     squadMember.Person.Surname, squadMember.Person.Name, squadMember.Person.Patronymic);

            // Возвращение результата
            return Ok();
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
            // _squadMemberService.UpdateSquadMember(squadMember);

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