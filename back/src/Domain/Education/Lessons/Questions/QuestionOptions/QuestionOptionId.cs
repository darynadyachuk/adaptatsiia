using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons.Questions.QuestionOptions
{
    public record QuestionOptionId(Guid Value)
    {
        public static QuestionOptionId New() => new(Guid.NewGuid());
        public static QuestionOptionId Empty() => new(Guid.Empty);
        public override string ToString() => Value.ToString();
    }
}
