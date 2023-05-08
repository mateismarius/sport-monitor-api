using Microsoft.EntityFrameworkCore;
using SportMonitorAPI.AppContext;
using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.MeasurementTakenRepository
{
    public class MeasurementTakenRepository : IMeasurementTakenRepository
    {
        private readonly ApplicationContext _context;

        public MeasurementTakenRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task AddMeasurement(MeasurementTaken measurement)
        {
            Player pl = await _context.Players.SingleOrDefaultAsync(x => x.Id == measurement.PlayerId);
            Measurement msr = await _context.Measurements.SingleOrDefaultAsync(x => x.Id == measurement.MeasurementId);
            measurement.Measurement = msr;
            measurement.Player = pl;
            await _context.MeasurementTakens.AddAsync(measurement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMeasurement(int id)
        {
            var measurement = await _context.MeasurementTakens.FindAsync(id);
            if (measurement != null)
                _context.MeasurementTakens.Remove(measurement);
            await _context.SaveChangesAsync();
        }

        public async Task<MeasurementTaken> GetMeasurement(int id)
        {
            return await _context.MeasurementTakens.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IReadOnlyList<MeasurementTaken>> GetMeasurementList()
        {
            return await _context.MeasurementTakens.Include(x => x.Player).Include(x => x.Measurement).ToListAsync();
        }

        public async Task UpdateMeasurement(MeasurementTaken measurement)
        {
            var dbObj = await _context.MeasurementTakens.FirstOrDefaultAsync(p => p.Id == measurement.Id);
            if (dbObj != null)
            {
                dbObj.MeasurementId = measurement.Id;
                dbObj.PlayerId = measurement.PlayerId;
                dbObj.Result = measurement.Result;
                dbObj.TakenAt = measurement.TakenAt;
                await _context.SaveChangesAsync();
            }
        }
    }
}
