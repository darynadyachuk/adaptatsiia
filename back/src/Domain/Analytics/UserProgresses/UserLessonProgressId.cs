using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Analytics.UserProgresses
{
    public record UserLessonProgressId(Guid Value)
    {
        public static UserLessonProgressId New() => new(Guid.NewGuid());
        public static UserLessonProgressId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
