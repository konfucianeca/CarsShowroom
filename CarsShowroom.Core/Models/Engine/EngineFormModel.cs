using CarsShowroom.Infrastructure.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShowroom.Core.Models.Engine
{
    public class EngineFormModel
    {
        public EngineType EngineType { get; set; }
        public int Displacement { get; set; }
        public int Power { get; set; }
    }
}
