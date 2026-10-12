using Domain.Education.Courses;
using Domain.Education.Lessons.Questions;
using Domain.Education.Lessons.Simulators;
using Domain.Education.Modules;
using Domain.Identify.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons
{
    internal class Lesson
    {
        public LessonId LessonId { get; }
        public ModuleId ModuleId { get; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public LessonType LessonType { get; private set; }
        public int OrderIndex { get; private set; }
        public string? Content { get; private set; }
        public string? SkillTag { get; private set; }
        public ICollection<Question> Questions { get; private set; } = new List<Question>();
        public ICollection<Simulator> SimulatorSteps { get; private set; } = new List<Simulator>();
        private Lesson(
            LessonId lessonId,
            ModuleId moduleId,
            string title,
            string? description,
            LessonType lessonType,
            int orderIndex,
            string? content,
            string? skillTag)
        {
            LessonId = lessonId;
            ModuleId = moduleId;
            Title = title;
            Description = description;
            LessonType = lessonType;
            OrderIndex = orderIndex;
            Content = content;
            SkillTag = skillTag;
        }

        public static Lesson New(
            LessonId lessonId,
            ModuleId moduleId,
            string title,
            string? description,
            LessonType lessonType,
            int orderIndex,
            string? content = null,
            string? skillTag = null,
            ICollection<Question>? questions = null,
            ICollection<Simulator>? simulatorSteps = null)
        {
            return new Lesson(
                lessonId,
                moduleId,
                title,
                description,
                lessonType,
                orderIndex,
                content,
                skillTag)
            {
                Questions = questions ?? new List<Question>(),
                SimulatorSteps = simulatorSteps ?? new List<Simulator>()
            };
        }
            public void UpdateLesson(
            string title,
            string? description,
            LessonType lessonType,
            int orderIndex,
            string? content,
            string? skillTag)
        {
            Title = title;
            Description = description;
            LessonType = lessonType;
            OrderIndex = orderIndex;
            Content = content;
            SkillTag = skillTag;
        }
    }
    
}
