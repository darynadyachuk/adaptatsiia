using Domain.Identify.Users;
using Domain.Education.Modules;

namespace Domain.Education.Courses
{
    internal class Course
    {
        public CourseId CourseId { get; }
        public string Title { get; private set; }
        public string? Description { get; private set; }
        public string CoverImageUrl { get; private set; }
        public bool IsPublished { get; private set; }
        public DateTime CreatedAt { get; }
        public UserId CreatedBy { get; }
        public DateTime? LastUpdatedAt { get; private set; }
        public ICollection<Module> Modules { get; private set; } = new List<Module>();
        private Course(
            CourseId courseId,
            string title,
            string? description,
            string coverImageUrl,
            bool isPublished,
            DateTime createdAt,
            UserId createdBy,
            DateTime? lastUpdatedAt)
        {
            CourseId = courseId;
            Title = title;
            Description = description;
            CoverImageUrl = coverImageUrl;
            IsPublished = isPublished;
            CreatedAt = createdAt;
            CreatedBy = createdBy;
            LastUpdatedAt = lastUpdatedAt;
        }

        public static Course New(
            CourseId courseId,
            string title,
            string? description,
            string coverImageUrl,
            UserId createdBy,
            ICollection<Module>? modules = null)
        {
            return new Course(
                courseId,
                title,
                description,
                coverImageUrl,
                isPublished: false,
                createdAt: DateTime.UtcNow,
                createdBy: createdBy,
                lastUpdatedAt: null)
            {
                Modules = modules ?? new List<Module>()
            };

        }
        public void UpdateCourse(string title, string? description, string coverImageUrl)
        {
            Title = title;
            Description = description;
            CoverImageUrl = coverImageUrl;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public void Publish()
        {
            IsPublished = true;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public void Unpublish()
        {
            IsPublished = false;
            LastUpdatedAt = DateTime.UtcNow;
        }
    }
}
