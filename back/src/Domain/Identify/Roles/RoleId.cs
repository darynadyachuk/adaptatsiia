using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identify.Roles
{
    public record RoleId(Guid Value)
    {
        public static RoleId Empty() => new(Guid.Empty);
        public static RoleId New() => new(Guid.NewGuid());
        public override string ToString() => Value.ToString();
    }
}
