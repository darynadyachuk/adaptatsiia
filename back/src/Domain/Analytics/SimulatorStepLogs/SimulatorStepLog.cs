using Domain.Analytics.UserProgresses;
using Domain.Education.Lessons;
using Domain.Education.Lessons.Simulators;
using Domain.Identify.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Analytics.SimulatorStepLogs
{
    internal class SimulatorStepLog
    {
        public SimulatorStepLogId SimulatorStepLogId { get; }
        public UserId UserId { get; }
        public SimulatorId SimulatorId { get; private set; }
        public int SimulatorStepId { get; private set; }
        public double IsSuccess { get; private set; }
        public int ErrorsCount { get; private set; }
        public int TimeSpentSeconds { get; private set; }
        public bool UsedHint {  get; private set; }
        public DateTime Timestamp { get; private set; }

        private SimulatorStepLog(
            SimulatorStepLogId simulatorStepLogId,
            UserId userId,
            SimulatorId simulatorId,
            double isSuccess,
            int errorsCount,
            int timeSpentSeconds,
            bool usedHint,
            DateTime timestamp)
        {
            SimulatorStepLogId = simulatorStepLogId;
            UserId = userId;
            SimulatorId = simulatorId;
            IsSuccess = isSuccess;
            ErrorsCount = errorsCount;
            TimeSpentSeconds = timeSpentSeconds;
            UsedHint = usedHint;
            Timestamp = timestamp;
        }
        public static SimulatorStepLog New(
            SimulatorStepLogId simulatorStepLogId,
            UserId userId,
            SimulatorId simulatorId,
            double isSuccess,
            int errorsCount,
            int timeSpentSeconds,
            bool usedHint)
        {
            return new SimulatorStepLog(
                simulatorStepLogId,
                userId,
                simulatorId,
                isSuccess,
                errorsCount,
                timeSpentSeconds,
                usedHint,
                DateTime.UtcNow);
        }
    }
}
