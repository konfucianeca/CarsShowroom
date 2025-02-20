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
        Task<int> CreateAsync(VehicleFormModel model,int customerId);
        Task<IEnumerable<AllVehiclesQueryModel>> AllVehiclesAsync();
        Task<bool> VehicleExistsAsync(int vehicleId);
        Task<VehicleDetailsViewModel> VehiclesDetailsById(int vehicleId);
        Task<bool> HasCustomerAsync(int vehicleId, string userId);
        Task<VehicleFormModel?> GetVehicleFormModelByIdAsync(int vehicleId);
        Task EditAsync(VehicleFormModel model, int vehicleId);
    }
}
