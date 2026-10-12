using Domain.Education.Courses;
using Domain.Education.Lessons;
using Domain.Identify.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Education.Modules
{
    internal class Module
    {
        public ModuleId ModuleId { get; }
        public CourseId CourseId { get; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public int OrderIndex { get; private set; }
        public ICollection<Lesson> Lessons { get; private set; } = new List<Lesson>();

        private Module(
            ModuleId moduleId,
            CourseId courseId,
            string title,
            string? description,
            int orderIndex)
        {
            ModuleId = moduleId;
            CourseId = courseId;
            Title = title;
            Description = description;
            OrderIndex = orderIndex;
        }
        public static Module New(
            ModuleId moduleId,
            CourseId courseId,
            string title,
            string? description,
            int orderIndex,
            ICollection<Lesson>? lessons = null)
        {
            return new Module(
                moduleId,
                courseId,
                title,
                description,
                orderIndex)
            {
                Lessons = lessons ?? new List<Lesson>()
            };

        }
        public void UpdateModule(string title, string? description, int orderIndex)
        {
            Title = title;
            Description = description;
            OrderIndex = orderIndex;
        }
    }
}
