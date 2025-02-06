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
                .AllReadOnly<Vehicle>()
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

        public async Task<IEnumerable<ManufacturerServiceModel>> AllManufacturersAsync()
        {
            return await repository.AllReadOnly<Manufacturer>()
                .Select(m => new ManufacturerServiceModel()
                {
                    Id = m.Id,
                    Name = m.Name
                })
                .ToListAsync();
        }

        public async Task<bool> ManufacturerExistsAsync(int manufacturerId)
        {
            return await repository.AllReadOnly<Manufacturer>()
                .AnyAsync(m => m.Id == manufacturerId);
        }

        public async Task<int> CreateAsync(VehicleFormModel model)
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
                EngineType = model.EngineType,
                Displacement = model.Displacement,
                Power = model.Power
            };

            await repository.AddAsync(vehicle);
            await repository.SaveChangesAsync();

            return vehicle.Id;
        }
    }

}

