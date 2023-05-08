using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace SportMonitorAPI.Repositories.MeasurementRepository
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly ApplicationContext _context;
        public MeasurementRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddMeasurement(Measurement measurement)
        {
            await _context.Measurements.AddAsync(measurement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMeasurement(int id)
        {
            var measurement = await _context.Measurements.FindAsync(id);
            if (measurement != null)
                _context.Measurements.Remove(measurement);
            await _context.SaveChangesAsync();
        }

        public async Task<Measurement> GetMeasurement(int id)
        {
            return await _context.Measurements.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<Measurement>> GetMeasurementList()
        {
            return await _context.Measurements.ToListAsync();
        }

        public async Task UpdateMeasurement(Measurement measurement)
        {
            var dbObj = await _context.Measurements.FirstOrDefaultAsync(p => p.Id == measurement.Id);
            if (dbObj != null)
            {
                dbObj.Name = measurement.Name;
                dbObj.Description = measurement.Description;
                dbObj.Unit = measurement.Unit;
                await _context.SaveChangesAsync();
            }
        }
    }
    
}
