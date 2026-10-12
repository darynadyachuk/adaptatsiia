using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons.Questions.QuestionOptions
{
    internal class QuestionOption
    {
        public QuestionOptionId QuestionOptionId { get; }
        public QuestionId QuestionId { get; }
        public string OptionText { get; private set; }
        public bool IsCorrect { get; private set; }

        private QuestionOption(QuestionOptionId questionOptionId, QuestionId questionId, string optionText, bool isCorrect)
        {
            QuestionOptionId = questionOptionId;
            QuestionId = questionId;
            OptionText = optionText;
            IsCorrect = isCorrect;
        }

        public static QuestionOption New(QuestionOptionId questionOptionId, QuestionId questionId, string optionText, bool isCorrect)
        {
            return new QuestionOption(questionOptionId, questionId, optionText, isCorrect);
        }

        public void UpdateOption(string optionText, bool isCorrect)
        {
            OptionText = optionText;
            IsCorrect = isCorrect;
        }
    }
}
