using Boussole.Data;
using LSO.Contracts.Structure;

namespace LSO.Services.Structure;

public class SquadsService : ISquadsService
{
    private readonly BousSOleDbContext _dbContext;

    public SquadsService(BousSOleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Squad CreateSquad(Squad squad)
    {
        // Проверка, существует ли уже отряд с таким ID
        if (_dbContext.Squads.Any(s => s.Id == squad.Id))
        {
            throw new InvalidOperationException("Отряд с указанным ID уже существует.");
        }

        // Проверка на заполненность данных
        if (string.IsNullOrEmpty(squad.Name) || string.IsNullOrEmpty(squad.Region))
        {
            throw new InvalidOperationException("Не все обязательные поля отряда заполнены.");
        }

        // Создание уникального ID для отряда, если не было указано значение
        if (squad.Id == 0)
        {
            squad.Id = GenerateUniqueId();
        }

        _dbContext.Squads.Add(squad);
        _dbContext.SaveChanges();

        return squad;
    }

    public void UpdateSquad(Squad squad)
    {
        // Проверка, существует ли отряд с указанным ID
        var existingSquad = _dbContext.Squads.FirstOrDefault(s => s.Id == squad.Id);
        if (existingSquad == null)
        {
            throw new InvalidOperationException("Отряд с указанным ID не найден.");
        }

        // Проверка на заполненность данных
        if (string.IsNullOrEmpty(squad.Name) || string.IsNullOrEmpty(squad.Region))
        {
            throw new InvalidOperationException("Не все обязательные поля отряда заполнены.");
        }

        // Обновление свойств отряда
        existingSquad.Name = squad.Name;
        existingSquad.Region = squad.Region;
        existingSquad.VkUrl = squad.VkUrl;
        existingSquad.InstitutionId = squad.InstitutionId;
        existingSquad.SquadType = squad.SquadType;

        _dbContext.SaveChanges();
    }

    private int GenerateUniqueId()
    {
        var now = DateTimeOffset.UtcNow;
        var ticks = now.Ticks;
        var uniqueId = (int)(ticks & 0x00000000FFFFFFFF);

        return uniqueId;
    }
}
