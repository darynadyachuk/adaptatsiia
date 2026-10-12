using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Analytics.UserSkillStates
{
    public record UserSkillStateId(Guid Value)
    {
        public static UserSkillStateId New() => new(Guid.NewGuid());
        public static UserSkillStateId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
