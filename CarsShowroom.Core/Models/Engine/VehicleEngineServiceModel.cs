﻿using CarsShowroom.Infrastructure.Data.Models.Enums;

namespace CarsShowroom.Core.Models.Engine
{
    public class VehicleEngineServiceModel
    {
        public int Id { get; set; }
        public EngineType EngineType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
    }
}
