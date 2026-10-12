using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Analytics.SimulatorStepLogs
{
    public record SimulatorStepLogId(Guid Value)
    {
        public static SimulatorStepLogId New() => new(Guid.NewGuid());
        public static SimulatorStepLogId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
