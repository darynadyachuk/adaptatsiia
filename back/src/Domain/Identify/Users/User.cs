using Domain.Analytics.UserProgresses;
using Domain.Analytics.UserSkillStates;
using Domain.Identify.Roles;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identify.Users
{
    internal class User
    {
        public UserId UserId { get; private set; }
        public string Email { get; private set; }
        public string ClerkId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string? AvatarUrl { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public RoleId RoleId { get; private set; }
        public ICollection<UserLessonProgress> LessonProgresses { get; private set; } = new List<UserLessonProgress>();
        public ICollection<UserSkillState> SkillStates { get; private set; } = new List<UserSkillState>();

        private User(
            UserId userId,
            string email,
            string clerkId,
            string firstName,
            string lastName,
            string? avatarUrl,
            bool isActive,
            DateTime createdAt,
            RoleId roleId)
        {
            UserId = userId;
            Email = email;
            ClerkId = clerkId;
            FirstName = firstName;
            LastName = lastName;
            AvatarUrl = avatarUrl;
            IsActive = isActive;
            CreatedAt = createdAt;
            RoleId = roleId;
        }
        public static User New(
            UserId userId,
            string email,
            string clerkId,
            string firstName,
            string lastName,
            RoleId roleId,
            string? avatarUrl = null,
            ICollection<UserLessonProgress>? lessonProgresses = null,
            ICollection<UserSkillState>? skillStates = null)
        {
            return new User(
                userId,
                email,
                clerkId,
                firstName,
                lastName,
                avatarUrl,
                isActive: true,
                createdAt: DateTime.UtcNow,
                roleId: roleId)
            {
                LessonProgresses = lessonProgresses ?? new List<UserLessonProgress>(),
                SkillStates = skillStates ?? new List<UserSkillState>()
            };

        }
        public void UpdateProfile(string firstName, string lastName, string? avatarUrl)
        {
            FirstName = firstName;
            LastName = lastName;
            AvatarUrl = avatarUrl;
        }

        public void ChangeRole(RoleId roleId)
        {
            RoleId = roleId;
        }

        public void Deactivate()
        {
            IsActive = false;
        }

        public void Activate()
        {
            IsActive = true;
        }
    }
}
