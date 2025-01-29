using CarsShowroom.Core.Models.Home;

namespace CarsShowroom.Core.Contracts
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleIndexServiceModel>> LastThreeVehiclesAsync();
    }
}
