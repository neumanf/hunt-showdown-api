using HuntShowdownAPI.Data;
using HuntShowdownAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HuntShowdownAPI.Repositories;

public class WeaponsRepository : IWeaponsRepository
{
    private readonly AppDbContext _context;
    
    public WeaponsRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Weapon>> GetAll()
    {
        return await _context.Weapons.ToListAsync();
    }
    
    public async Task<List<Weapon>> SearchByName(string name)
    {
        return await _context.Weapons.Where(weapon => weapon.Name.ToLower().Contains(name.ToLower())).ToListAsync();
    }

    public async Task<Weapon?> GetBySlug(string slug)
    {
        return await _context.Weapons.FirstOrDefaultAsync(weapon => weapon.Slug == slug);
    }
}