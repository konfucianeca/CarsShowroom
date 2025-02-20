using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Home;
using CarsShowroom.Core.Models.Manufacturer;
using CarsShowroom.Core.Models.Vehicle;
using CarsShowroom.Infrastructure.Data.Common;
using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsShowroom.Core.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository repository;
        public VehicleService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<VehicleIndexServiceModel>> LastThreeVehiclesAsync()
        {
            return await repository
                .AllReadOnlyAsync<Vehicle>()
                .OrderByDescending(v => v.Id)
                .Take(3)
                .Select(v => new VehicleIndexServiceModel()
                {
                    Id = v.Id,
                    ImageUrl = v.ImageUrl,
                    Maker = v.Manufacturer.Name,
                    Model = v.Model,
                    YearOfProduction = v.YearOfProduction,
                    EngineType = v.EngineType.ToString(),
                    Price = v.Price
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<AllVehiclesQueryModel>> AllVehiclesAsync()
        {
            return await repository
                .AllReadOnlyAsync<Vehicle>()
                .Select(v => new AllVehiclesQueryModel()
                {
                    Id = v.Id,
                    ImageUrl = v.ImageUrl,
                    Maker = v.Manufacturer.Name,
                    Model = v.Model,
                    YearOfProduction = v.YearOfProduction,
                    EngineType = v.EngineType.ToString(),
                    Price = v.Price,
                    Region = v.Region,
                    Mileage = v.Mileage
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ManufacturerServiceModel>> AllManufacturersAsync()
        {
            return await repository.AllReadOnlyAsync<Manufacturer>()
                .Select(m => new ManufacturerServiceModel()
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToListAsync();
        }

        public async Task<bool> ManufacturerExistsAsync(int manufacturerId)
        {
            return await repository.AllReadOnlyAsync<Manufacturer>()
                .AnyAsync(m => m.Id == manufacturerId);
        }

        public async Task<int> CreateAsync(VehicleFormModel model, int customerId)
        {
            Vehicle vehicle = new Vehicle()
            {
                Model = model.Model,
                Condition = model.Condition,
                YearOfProduction = model.YearOfProduction,
                Region = model.Region,
                Gearbox = model.Gearbox,
                Color = model.Color,
                Mileage = model.Mileage,
                Features = model.Features,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                ManufacturerId = model.ManufacturerId,
                CustomerId = customerId,
                EngineType = model.EngineType,
                Displacement = model.Displacement,
                Power = model.Power
            };

            await repository.AddAsync(vehicle);
            await repository.SaveChangesAsync();

            return vehicle.Id;
        }

        public async Task<bool> VehicleExistsAsync(int vehicleId)
        {
            return await repository.AllReadOnlyAsync<Vehicle>()
                .AnyAsync(v => v.Id == vehicleId);
        }
        public async Task<VehicleDetailsViewModel> VehiclesDetailsById(int vehicleId)
        {
            var vehicleDetails = await repository.AllReadOnlyAsync<Vehicle>()
                .Where(v => v.Id == vehicleId)
                .Select(v => new VehicleDetailsViewModel()
                {
                    Id = v.Id,
                    Maker = v.Manufacturer.Name,
                    Model = v.Model,
                    ImageUrl = v.ImageUrl,
                    YearOfProduction = v.YearOfProduction,
                    EngineType = v.EngineType.ToString(),
                    Condition = v.Condition.ToString(),
                    Price = v.Price,
                    Region = v.Region,
                    Gearbox = v.Gearbox.ToString(),
                    Color = v.Color,
                    Mileage = v.Mileage,
                    Features = v.Features,
                    ManufacturerId = v.ManufacturerId,
                    Displacement = v.Displacement,
                    Power = v.Power,
                    Customer = v.Customer.Name
                })
                .FirstAsync();

            return vehicleDetails;
        }

        public async Task<bool> HasCustomerAsync(int vehicleId, string userId)
        {
            return await repository.AllReadOnlyAsync<Vehicle>()
                .AnyAsync(v => v.Id == vehicleId && v.Customer.UserId == userId);
        }

        public async Task<VehicleFormModel?> GetVehicleFormModelByIdAsync(int vehicleId)
        {
            var vehicle = await repository.AllReadOnlyAsync<Vehicle>()
                .Where(v => v.Id == vehicleId)
                .Select(v => new VehicleFormModel()
                {
                    Model = v.Model,
                    Condition = v.Condition,
                    Price = v.Price,
                    Region = v.Region,
                    YearOfProduction = v.YearOfProduction,
                    Gearbox = v.Gearbox,
                    Color = v.Color,
                    Mileage = v.Mileage,
                    Features = v.Features,
                    ManufacturerId = v.ManufacturerId,
                    ImageUrl = v.ImageUrl,
                    Power = v.Power,
                    Displacement = v.Displacement,
                    EngineType = v.EngineType
                })
                .FirstOrDefaultAsync();

            return vehicle;
        }

        public async Task EditAsync(VehicleFormModel model, int vehicleId)
        {
            var vehicle = await repository.GetByIdAsync<Vehicle>(vehicleId);

            if (vehicle != null)
            {
                vehicle.Model = model.Model;
                vehicle.Condition = model.Condition;
                vehicle.Price = model.Price;
                vehicle.Region = model.Region;
                vehicle.Features = model.Features;
                vehicle.ManufacturerId = model.ManufacturerId;
                vehicle.ImageUrl = model.ImageUrl;
                vehicle.Power = model.Power;
                vehicle.Displacement = model.Displacement;
                vehicle.EngineType = model.EngineType;
                vehicle.Color = model.Color;
                vehicle.Mileage = model.Mileage;
                vehicle.Gearbox = model.Gearbox;
                vehicle.YearOfProduction = model.YearOfProduction;

                await repository.SaveChangesAsync();
            }
        }
    }

}

