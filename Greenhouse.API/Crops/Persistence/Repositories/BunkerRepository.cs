using Greenhouse.API.Crops.Domain.Models;
using Greenhouse.API.Crops.Domain.Repositories;
using Greenhouse.API.Profiles.Domain.Models;
using Greenhouse.API.Shared.Persistence.Contexts;
using Greenhouse.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Greenhouse.API.Crops.Persistence.Repositories;

public class BunkerRepository : BaseRepository, IBunkerRepository
{
    public BunkerRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Bunker>> ListAsync()
    {
        return await _context.Bunkers
            .ToListAsync();
    }

    public async Task AddAsync(Bunker bunker)
    {
        var currentDate = DateTime.Now;
        bunker.Day = currentDate.Day - bunker.Date.Day + 1;
        bunker.AverageThermocouple = (bunker.ThermocoupleOne + bunker.ThermocoupleTwo + bunker.ThermocoupleThree) / 3;
        await _context.Bunkers.AddAsync(bunker);
    }

    public async Task<Bunker> FindByIdAsync(int bunkerId)
    {
        return await _context.Bunkers
            .FirstOrDefaultAsync(p => p.Id == bunkerId);
        
    }

    public async Task<IEnumerable<Bunker>> FindByCropIdAsync(int cropId)
    {
        return await _context.Bunkers
            .Where(p => p.CropId == cropId)
            .ToListAsync();
    }
    
    public async Task<IEnumerable<Bunker>> FindByEmployeeIdAsync(int employeeId)
    {
        return await _context.Bunkers
            .Where(p => p.EmployeeId == employeeId)
            .Include(p => p.Crop)
            .Include(p => p.Employee)
            .ToListAsync();
    }

    public void Update(Bunker bunker)
    {
        _context.Bunkers.Update(bunker);
    }

    public void Remove(Bunker bunker)
    {
        _context.Bunkers.Remove(bunker);
    }
}