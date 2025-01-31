using CarsShowroom.Core.Models.Home;
using CarsShowroom.Core.Models.Manufacturer;
using CarsShowroom.Core.Models.Vehicle;

namespace CarsShowroom.Core.Contracts
{
    public interface IVehicleService
    {
        Task<IEnumerable<VehicleIndexServiceModel>> LastThreeVehiclesAsync();
        Task<IEnumerable<ManufacturerServiceModel>> AllManufacturersAsync();
        Task<bool> ManufacturerExistsAsync(int manufacturerId);
        Task<int> CreateAsync(VehicleFormModel model);
    }
}
