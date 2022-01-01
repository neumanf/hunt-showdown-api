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

    public List<Weapon> GetAll(string? search)
    {
        if(search == null) return _weaponsRepository.GetAll();
        
        return _weaponsRepository.SearchByName(search);
    }
    
    public Weapon? GetBySlug(string slug)
    {
        return _weaponsRepository.GetBySlug(slug);
    }
}