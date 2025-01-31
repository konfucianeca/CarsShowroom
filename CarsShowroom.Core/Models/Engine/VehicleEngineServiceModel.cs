using CarsShowroom.Infrastructure.Data.Models.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
