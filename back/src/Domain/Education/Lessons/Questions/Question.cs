using Domain.Education.Lessons.Questions.QuestionOptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons.Questions
{
    internal class Question
    {
        public QuestionId QuestionId { get; }
        public LessonId LessonId { get; }
        public string QuestionText { get; private set; }
        public QuestionType QuestionType { get; private set; }
        public int OrderIndex {  get; private set; }
        public ICollection<QuestionOption> Options { get; private set; } = new List<QuestionOption>();
        private Question(QuestionId questionId, LessonId lessonId, string questionText, QuestionType questionType, int orderIndex)
        {
            QuestionId = questionId;
            LessonId = lessonId;
            QuestionText = questionText;
            QuestionType = questionType;
            OrderIndex = orderIndex;
        }

        public static Question New(QuestionId questionId, LessonId lessonId, string questionText, QuestionType questionType, int orderIndex, ICollection<QuestionOption>? options = null)
        {
            return new Question(
                questionId,
                lessonId,
                questionText,
                questionType,
                orderIndex)
            {
                Options = options
            };
        }

            public void UpdateQuestion(string questionText, QuestionType questionType, int orderIndex)
        {
            QuestionText = questionText;
            QuestionType = questionType;
            OrderIndex = orderIndex;
        }
    }
}
