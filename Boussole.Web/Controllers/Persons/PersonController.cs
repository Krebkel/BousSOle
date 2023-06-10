using Boussole.Core.Controllers.Persons.Requests;
using Boussole.Persons;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Core.Controllers.Persons;

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
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Person))]
    public async Task<IActionResult> AddPerson([FromBody] AddPersonApiRequest request, CancellationToken ct)
    {
        // TODO: возвращать результат действия и не завязываться на ексепшн. Ексепшн ловить только в случае ошибок
        try
        {
            var addPersonRequest = request.ToAddPersonRequest();
            var createdPerson = await _personService.CreatePersonAsync(addPersonRequest, ct);
            return Ok(createdPerson);
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Ошибка при добавлении физического лица");
            return BadRequest($"Ошибка при добавлении физического лица {e.Message}");
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdatePerson([FromBody] UpdatePersonApiRequest request, CancellationToken ct)
    {
        try
        {
            var updatePersonRequest = request.ToUpdatePersonRequest();
            await _personService.UpdatePersonAsync(updatePersonRequest, ct);
            return Ok();
        }
        catch (Exception e)
        {
            _logger.LogError(e, "Ошибка при обновлении физического лица");
            return BadRequest($"Ошибка при обновлении физического лица {e.Message}");
        }
    }
}