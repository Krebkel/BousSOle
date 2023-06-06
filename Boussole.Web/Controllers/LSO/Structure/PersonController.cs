using Boussole.Core.Controllers.LSO.Structure.Requests;
using Boussole.Core.Extensions;
using Boussole.LSO.Services.Structure;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.LSO.Structure;

 [ApiController]
[Route("api/persons")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonService _personService;

    public PersonController(ILogger<PersonController> logger, IPersonService personService)
    {
        _logger = logger;
        _personService = personService;
    }

    [HttpPost]
    public async Task<IActionResult> AddPerson([FromBody] AddPersonRequest request)
    {
        // Проверка и валидация данных request

        // Создание объекта Person из данных request
        var person = request.ToPerson();

        // Создание физического лица
        var createdPerson = await _personService.CreatePersonAsync(person);

        _logger.LogInformation("Физическое лицо успешно добавлено: {@Surname} {@Name} {@Patronymic}", createdPerson.Surname, createdPerson.Name, createdPerson.Patronymic);

        // Возвращение результата
        return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> UpdatePerson([FromBody] UpdatePersonRequest request)
    {
        // Проверка и валидация данных request

        // Получение существующего физического лица из базы данных, например по его идентификатору
        var existingPerson = await _personService.GetPersonByIdAsync(request.PersonInn);

        if (existingPerson == null)
        {
            // Возвращение ошибки, если физическое лицо не найдено
            return NotFound();
        }

        // Обновление объекта Person из данных request
        var updatedPerson = request.ToUpdatePerson(existingPerson);

        // Обновление физического лица
        await _personService.UpdatePersonAsync(updatedPerson);

        _logger.LogInformation("Физическое лицо успешно обновлено: {@Surname} {@Name} {@Patronymic}", updatedPerson.Surname, updatedPerson.Name, updatedPerson.Patronymic);

        // Возвращение результата
        return Ok();
    }
}