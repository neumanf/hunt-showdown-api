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

    public List<Weapon> GetAll()
    {
        return _context.Weapons.ToList();
    }
}