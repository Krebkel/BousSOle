using Boussole.Core.Controllers.Institutions.Requests;
using Boussole.Institutions.Contracts;
using Boussole.Institutions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.Institutions;

[ApiController]
[Route("api/Institutions")]
public class InstitutionController : ControllerBase
{
    private readonly ILogger<InstitutionController> _logger;
    private readonly IInstitutionService _InstitutionService;

    public InstitutionController(ILogger<InstitutionController> logger, IInstitutionService InstitutionService)
    {
        _logger = logger;
        _InstitutionService = InstitutionService;
    }

    [HttpPost]
    public IActionResult AddInstitution([FromBody] AddInstitutionRequest request)
    {
        // Проверка и валидация данных request

        // Создание объекта Institution из данных request
        var Institution = new Institution
        {
            ShortName = request.ShortName,
            FullName = request.FullName,
            AdministratorTitle = request.AdministratorTitle,
            AdministratorName = request.AdministratorName,
            StructWebsite = request.StructWebsite
        };

        // Создание отряда
        var InstitutionId = _InstitutionService.CreateInstitution(Institution);

        _logger.LogInformation("Учебное заведение успешно добавлено: {@Institution}", Institution.Id);

        // Возвращение результата
        return Ok(new { InstitutionId = InstitutionId });
    }

    [HttpPost]
    public IActionResult UpdateInstitution([FromBody] UpdateInstitutionRequest request)
    {
        // Проверка и валидация данных request

        // Обновление объекта Institution из данных request
        var Institution = new Institution
        {
            ShortName = request.ShortName,
            FullName = request.FullName,
            AdministratorTitle = request.AdministratorTitle,
            AdministratorName = request.AdministratorName,
            StructWebsite = request.StructWebsite
        };

        // Обновление отряда
        _InstitutionService.UpdateInstitution(Institution);

        _logger.LogInformation("Учебное заведение успешно обновлено: {@Institution}", Institution.Id);

        // Возвращение результата
        return Ok();
    }
}