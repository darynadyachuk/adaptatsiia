using Domain.Education.Courses;
using Domain.Identify.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Education.Lessons;

namespace Domain.Analytics.UserProgresses
{
    internal class UserLessonProgress
    {
        public UserLessonProgressId UserLessonProgressId { get; }
        public UserId UserId { get; }
        public LessonId LessonId { get; }
        public bool IsComplete { get; private set; }
        public double? Score { get; private set; }//
        public DateTime? CompleteAt { get; private set; }
        private UserLessonProgress(
            UserLessonProgressId userLessonProgressId,
            UserId userId,
            LessonId lessonId,
            bool isComplete,
            double? score,
            DateTime? completeAt)
        {
            UserLessonProgressId = userLessonProgressId;
            UserId = userId;
            LessonId = lessonId;
            IsComplete = isComplete;
            Score = score;
            CompleteAt = completeAt;
        }
        public static UserLessonProgress New(
            UserLessonProgressId userLessonProgressId,
            UserId userId,
            LessonId lessonId)
        {
            return new UserLessonProgress(
                userLessonProgressId,
                userId,
                lessonId,
                isComplete: false,
                score: null,
                completeAt: null);
        }
        public void CompleteLesson(double? score = null)
        {
            IsComplete = true;
            Score = score;
            CompleteAt = DateTime.UtcNow;
        }

        public void UpdateScore(double score)
        {
            Score = score;
        }
    }
}
