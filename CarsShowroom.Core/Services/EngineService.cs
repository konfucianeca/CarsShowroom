using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Engine;
using CarsShowroom.Infrastructure.Data.Common;
using CarsShowroom.Infrastructure.Data.Models;

namespace CarsShowroom.Core.Services
{
    public class EngineService : IEngineService
    {
        private readonly IRepository repository;
        public EngineService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<int> CreateAsync(EngineFormModel model)
        {
            Engine engine = new Engine()
            {
                EngineType = model.EngineType,
                Displacement = model.Displacement,
                Power = model.Power
            };

            await repository.AddAsync(engine);
            await repository.SaveChangesAsync();

            return engine.Id;
        }
    }
}
