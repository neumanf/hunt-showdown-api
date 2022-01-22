using HuntShowdownAPI.Interfaces.Repositories;
using HuntShowdownAPI.Interfaces.Services;
using HuntShowdownAPI.Models;

namespace HuntShowdownAPI.Services;

public class WeaponsService : IWeaponsService
{
    private readonly IWeaponsRepository _weaponsRepository;
    
    public WeaponsService(IWeaponsRepository weaponsRepository)
    {
        _weaponsRepository = weaponsRepository;
    }

    public async Task<List<Weapon>> GetAll(string? search)
    {
        if(search == null) return await _weaponsRepository.GetAll();
        
        return await _weaponsRepository.SearchByName(search);
    }
    
    public async Task<Weapon?> GetBySlug(string slug)
    {
        return await _weaponsRepository.GetBySlug(slug);
    }
}