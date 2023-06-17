using Boussole.Institutions.Contracts;
using Boussole.Institutions.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Boussole.Institutions.Services;

internal class InstitutionService : IInstitutionService
{
    private readonly IInstitutionRepository _institutionRepository;
    private readonly DbContext _dbContext;

    public InstitutionService(IInstitutionRepository institutionRepository, DbContext dbContext)
    {
        _institutionRepository = institutionRepository;
        _dbContext = dbContext;
    }

    public async Task<Institution> CreateInstitutionAsync(Institution institution)
    {
        await _dbContext.Set<Institution>().AddAsync(institution);
        await _dbContext.SaveChangesAsync();
        return institution;
    }

    public async Task UpdateInstitutionAsync(Institution institution)
    {
        _dbContext.Set<Institution>().Update(institution);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Institution> GetInstitutionByIdAsync(int institutionId)
    {
        // Ищем учебное заведение по идентификатору в базе данных
        var institution = await _institutionRepository.GetInstitutionByIdAsync(institutionId);

        // Возвращаем найденное учебное заведение
        return institution;
    }
}