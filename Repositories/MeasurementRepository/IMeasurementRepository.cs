using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.MeasurementRepository
{
    public interface IMeasurementRepository
    {
        Task<IReadOnlyList<Measurement>> GetMeasurementList();
        Task<Measurement> GetMeasurement(int id);
        Task UpdateMeasurement(Measurement measurement);
        Task DeleteMeasurement(int id);
        Task AddMeasurement(Measurement measurement);
    }
}
