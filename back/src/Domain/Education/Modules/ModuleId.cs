using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Modules
{
    public record ModuleId(Guid Value)
    {
        public static ModuleId New() => new(Guid.NewGuid());
        public static ModuleId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
