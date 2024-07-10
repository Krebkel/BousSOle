using Boussole.Web.Controllers.LSO.SSO.Requests;
using Boussole.Web.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Boussole.Web.Controllers.LSO.SSO;

[Authorize]
[ApiController]
[Route("api/planworks")]
public class PlanWorkController : ControllerBase
{
    private readonly ILogger<PlanWorkController> _logger;

    public PlanWorkController(ILogger<PlanWorkController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public async Task<IActionResult> AddPlanWork([FromBody] AddPlanWorkRequest request)
    {
        try
        {
            // Проверка и валидация данных request

            // Создание объекта PlanWork из данных request
            var planWork = request.ToPlanWork();
            //
            // // Добавление учета рабочего времени
            // var createdPlanWork = await _planWorkService.CreatePlanWorkAsync(planWork);
            //
            // _logger.LogInformation("Учет рабочего времени успешно добавлен: {@Date} {@WorkerActivityStatus}",
            //     createdPlanWork.Date, createdPlanWork.WorkerActivityStatus);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при добавлении учета рабочего времени");
            return BadRequest("Ошибка при добавлении учета рабочего времени");
        }
    }

    [HttpPut("{planWorkId}")]
    public async Task<IActionResult> UpdatePlanWork(int planWorkId, [FromBody] UpdatePlanWorkRequest request)
    {
        try
        {
            // Проверка и валидация данных request
            //
            // // Получение существующего учета рабочего времени по идентификатору
            // var existingPlanWork = await _planWorkService.GetPlanWorkByIdAsync(planWorkId);
            //
            // if (existingPlanWork == null)
            // {
            //     return NotFound("Учет рабочего времени не найден");
            // }
            //
            // // Обновление объекта PlanWork из данных request
            // var updatedPlanWork = request.ToUpdatePlanWork(existingPlanWork);
            //
            // // Обновление учета рабочего времени
            // await _planWorkService.UpdatePlanWorkAsync(updatedPlanWork);

            // _logger.LogInformation("Учет рабочего времени успешно обновлен: {@Date} {@WorkerActivityStatus}",
                // updatedPlanWork.Date, updatedPlanWork.WorkerActivityStatus);

            // Возвращение результата
            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при обновлении учета рабочего времени");
            return BadRequest("Ошибка при обновлении учета рабочего времени");
        }
    }
}