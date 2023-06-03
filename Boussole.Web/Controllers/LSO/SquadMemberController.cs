using Boussole.Core.Controllers.LSO.Requests;
using Boussole.LSO.Contracts.Structure;
using Boussole.LSO.Services.Structure;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.LSO;

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
        // Проверка и валидация данных request

        // Создание объекта SquadMember из данных request
        var squadMember = new SquadMember
        {
            PersonId = request.PersonId,
            MemberRank = request.MemberRank,
            YearEnlisted = request.YearEnlisted,
            IsActive = request.IsActive,
            SquadId = request.SquadId
        };

        // Добавление бойца в отряд
        var squadMemberId = _squadMemberService.CreateSquadMember(squadMember);

        _logger.LogInformation("Боец успешно добавлен: {@SquadMember}", squadMember.Id);

        // Возвращение результата
        return Ok(new { SquadMemberId = squadMemberId });
    }

    [HttpPost]
    public IActionResult UpdateSquadMember([FromBody] UpdateSquadMemberRequest request)
    {
        // Проверка и валидация данных request

        // Обновление объекта SquadMember из данных request
        var squadMember = new SquadMember
        {
            PersonId = request.PersonId,
            MemberRank = request.MemberRank,
            YearEnlisted = request.YearEnlisted,
            IsActive = request.IsActive,
            SquadId = request.SquadId
        };

        // Обновление информации о бойце отряда
        _squadMemberService.UpdateSquadMember(squadMember);

        _logger.LogInformation("Боец успешно обновлен: {@SquadMember}", squadMember.Id);

        // Возвращение результата
        return Ok();
    }
}