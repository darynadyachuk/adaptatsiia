using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons.Simulators
{
    public record SimulatorId(Guid Value)
    {
        public static SimulatorId New() => new(Guid.NewGuid());
        public static SimulatorId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
