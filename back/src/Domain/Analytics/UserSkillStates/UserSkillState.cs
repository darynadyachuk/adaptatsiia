using Domain.Analytics.UserProgresses;
using Domain.Education.Lessons;
using Domain.Identify.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Analytics.UserSkillStates
{
    internal class UserSkillState
    {
        public UserSkillStateId UserSkillStateId { get; }
        public UserId UserId { get; }
        public string SkillTag { get; private set; }
        public double MasteryProbability { get; private set; }//
        public DateTime? LastUpdate { get; private set; }

        private UserSkillState(
            UserSkillStateId userSkillStateId,
            UserId userId,
            string skillTag,
            double masteryProbability,
            DateTime lastUpdate)
        {
            UserSkillStateId = userSkillStateId;
            UserId = userId;
            SkillTag = skillTag;
            MasteryProbability = masteryProbability;
            LastUpdate = lastUpdate;
        }
        public static UserSkillState New(
            UserSkillStateId userSkillStateId,
            UserId userId,
            string skillTag,
            double initialMasteryProbability = 0.1)
        {
            return new UserSkillState(
                userSkillStateId,
                userId,
                skillTag,
                initialMasteryProbability,
                DateTime.UtcNow);
        }
        public void UpdateMastery(double newMasteryProbability)
        {
            MasteryProbability = newMasteryProbability;
            LastUpdate = DateTime.UtcNow;
        }
    }
}
