namespace BousSOle.Postgres.Productivity;

/// <summary>
/// Сервис, получающий из базы данных записи WorkHoursReport на конкретный отряд, 
/// суммирует количество рабочих часов, получая плановую выработку (sumWorkHours), 
/// находит длину смены (maxWorkHours), 
/// количество работающих бойцов отряда (squadMemberCount)
/// </summary>
public class PlanWorkService
{
    private readonly BousSOleDbContext _dbContext;

    public PlanWorkService(BousSOleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void GetWorkHoursReport(DateTime date, int squadId)
    {
        var sumWorkHours = _dbContext.PlanWorks
            .Where(w => w.Date == date && w.SquadMember.SquadID == squadId)
            .Sum(w => w.WorkHours);

        var maxWorkHours = _dbContext.PlanWorks
            .Where(w => w.Date == date && w.SquadMember.SquadID == squadId)
            .Max(w => w.WorkHours);

        var squadMemberCount = _dbContext.PlanWorks
            .Count(w => w.Date == date && w.SquadMember.SquadID == squadId);

        // Console.WriteLine($"Sum of WorkHours: {sumWorkHours}");
        // Console.WriteLine($"Max WorkHours: {maxWorkHours}");
        // Console.WriteLine($"SquadMember Count: {squadMemberCount}");
        // var workHoursReportService = new WorkHoursReportService(BousSOleDbContext);
        // workHoursReportService.GetWorkHoursReport(new DateTime(YYYY, M, DD), squadId);
    }
}