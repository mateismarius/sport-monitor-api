using SportMonitorAPI.Entities;

namespace SportMonitorAPI.Repositories.MeasurementTakenRepository
{
    public interface IMeasurementTakenRepository
    {
        Task<IReadOnlyList<MeasurementTaken>> GetMeasurementList();
        Task<MeasurementTaken> GetMeasurement(int id);
        Task UpdateMeasurement(MeasurementTaken measurement);
        Task DeleteMeasurement(int id);
        Task AddMeasurement(MeasurementTaken measurement);
    }
}
