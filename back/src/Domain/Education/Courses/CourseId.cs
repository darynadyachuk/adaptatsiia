using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Courses
{
    public record CourseId(Guid Value)
    {
        public static CourseId New() => new(Guid.NewGuid());
        public static CourseId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
