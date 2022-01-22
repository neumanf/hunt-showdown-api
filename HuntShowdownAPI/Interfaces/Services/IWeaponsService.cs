using HuntShowdownAPI.Models;

namespace HuntShowdownAPI.Interfaces.Services;

public interface IWeaponsService
{
    public Task<List<Weapon>> GetAll(string? search);

    public Task<Weapon?> GetBySlug(string slug);
}