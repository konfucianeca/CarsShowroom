using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Home;
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
                    Model = v.Model,
                    YearOfProduction = v.YearOfProduction,
                    EngineType = v.Engine.EngineType.ToString(),
                    Price = v.Price
                })
                .ToListAsync();
        }
    }

}

