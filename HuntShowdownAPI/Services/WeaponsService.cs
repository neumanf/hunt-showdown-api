using HuntShowdownAPI.Data;
using HuntShowdownAPI.Models;

namespace HuntShowdownAPI.Services;

public class WeaponsService
{
    private readonly AppDbContext _context;
    
    public WeaponsService(AppDbContext context)
    {
        _context = context;
    }

    public List<Weapon> GetAll(string? search)
    {
        if(search == null) return _context.Weapons.ToList();
        
        return _context.Weapons.Where(weapon => weapon.Name.ToLower().Contains(search.ToLower())).ToList();
    }
    
    public Weapon? GetBySlug(string slug)
    {
        return _context.Weapons.FirstOrDefault(weapon => weapon.Slug == slug);
    }
}