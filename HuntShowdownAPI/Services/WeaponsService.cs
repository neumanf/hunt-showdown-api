using HuntShowdownAPI.Data;
using HuntShowdownAPI.Models;
using HuntShowdownAPI.Repositories;

namespace HuntShowdownAPI.Services;

public class WeaponsService
{
    private readonly WeaponsRepository _weaponsRepository;
    
    public WeaponsService(WeaponsRepository weaponsRepository)
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