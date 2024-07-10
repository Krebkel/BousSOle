using Boussole.Web.Controllers.Institutions.Requests;
using Boussole.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Web.Controllers.Institutions;

[Authorize]
[ApiController]
[Route("api/institutions")]
public class InstitutionController : ControllerBase
{
    private readonly ILogger<InstitutionController> _logger;

    public InstitutionController(ILogger<InstitutionController> logger)
    {
        _logger = logger;
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddInstitution([FromBody] AddInstitutionRequest request)
    {
        // Проверка и валидация данных request

        // Создание объекта Institution из данных request
        var institution = request.ToInstitution();

        // Создание учебного заведения
        // var createdInstitution = await _institutionService.CreateInstitutionAsync(institution);
        //
        // _logger.LogInformation("Учебное заведение успешно добавлено: {@ShortName}", createdInstitution.ShortName);

        // Возвращение результата
        return Ok();
    }

    [HttpPut("update")]
    public async Task<IActionResult> UpdateInstitution([FromBody] UpdateInstitutionRequest request)
    {
        // Проверка и валидация данных request

        // Получение существующего учебного заведения из базы данных, например по его идентификатору
        // var existingInstitution = await _institutionService.GetInstitutionByIdAsync(request.InstitutionId);
        //
        // if (existingInstitution == null)
        // {
        //     // Возвращение ошибки, если учебное заведение не найдено
        //     return NotFound();
        // }
        //
        // // Обновление объекта Institution из данных request
        // var updatedInstitution = request.ToUpdateInstitution(existingInstitution);
        //
        // // Обновление учебного заведения
        // await _institutionService.UpdateInstitutionAsync(updatedInstitution);

        // _logger.LogInformation("Учебное заведение успешно обновлено: {@ShortName}", updatedInstitution.ShortName);

        // Возвращение результата
        return Ok();
    }
}