using HuntShowdownAPI.Models;

namespace HuntShowdownAPI.Repositories;

public interface IWeaponsRepository
{
    public Task<List<Weapon>> GetAll();
    
    public Task<List<Weapon>> SearchByName(string name);
    
    public Task<Weapon?> GetBySlug(string slug);
}