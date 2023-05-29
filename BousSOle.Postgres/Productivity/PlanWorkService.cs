namespace BousSOle.Postgres.Productivity;

/// <summary>
/// Сервис, получающий из базы данных записи PlanWork на конкретный отряд, 
/// суммирует количество рабочих часов, получая плановую выработку (sumWorkHours), 
/// находит длину смены (maxWorkHours), 
/// количество работающих бойцов отряда (squadMemberCount)
/// </summary>
internal class PlanWorkService
{
    private readonly BousSOleDbContext _dbContext;

    public PlanWorkService(BousSOleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void GetPlanWork(DateTime date, int squadId)
    {
        var sumWorkHours = _dbContext.PlanWorks
            .Where(w => w.Date == date && w.SquadMember.SquadId == squadId)
            .Sum(w => w.WorkHours);

        var maxWorkHours = _dbContext.PlanWorks
            .Where(w => w.Date == date && w.SquadMember.SquadId == squadId)
            .Max(w => w.WorkHours);

        var squadMemberCount = _dbContext.PlanWorks
            .Count(w => w.Date == date && w.SquadMember.SquadId == squadId);

        // Console.WriteLine($"Sum of WorkHours: {sumWorkHours}");
        // Console.WriteLine($"Max WorkHours: {maxWorkHours}");
        // Console.WriteLine($"SquadMember Count: {squadMemberCount}");
        // var workHoursReportService = new WorkHoursReportService(BousSOleDbContext);
        // workHoursReportService.GetWorkHoursReport(new DateTime(YYYY, M, DD), squadId);
    }
}