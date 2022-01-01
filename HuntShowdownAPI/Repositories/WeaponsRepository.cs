using HuntShowdownAPI.Data;
using HuntShowdownAPI.Models;

namespace HuntShowdownAPI.Repositories;

public class WeaponsRepository
{
    private readonly AppDbContext _context;
    
    public WeaponsRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Weapon> GetAll()
    {
        return _context.Weapons.ToList();
    }
    
    public List<Weapon> SearchByName(string name)
    {
        return _context.Weapons.Where(weapon => weapon.Name.ToLower().Contains(name.ToLower())).ToList();
    }

    public Weapon? GetBySlug(string slug)
    {
        return _context.Weapons.FirstOrDefault(weapon => weapon.Slug == slug);
    }

}