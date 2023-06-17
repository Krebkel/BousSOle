using Boussole.Institutions.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Boussole.Institutions.Repositories;

internal class InstitutionRepository : IInstitutionRepository
{
    private readonly DbContext _dbContext;

    public InstitutionRepository(DbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Institution> GetInstitutionByIdAsync(int institutionId)
    {
        // Ищем учебное заведение по идентификатору в базе данных
        var institution = await _dbContext.Set<Institution>().FindAsync(institutionId);

        // Возвращаем найденное учебное заведение
        return institution;
    }
}