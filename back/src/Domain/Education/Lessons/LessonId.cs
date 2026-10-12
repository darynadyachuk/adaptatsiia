using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons
{
    public record LessonId(Guid Value)
    {
        public static LessonId New() => new(Guid.NewGuid());
        public static LessonId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
