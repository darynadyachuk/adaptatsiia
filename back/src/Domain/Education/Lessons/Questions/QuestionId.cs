using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons.Questions
{
    public record QuestionId(Guid Value)
    {
        public static QuestionId New() => new(Guid.NewGuid());
        public static QuestionId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
