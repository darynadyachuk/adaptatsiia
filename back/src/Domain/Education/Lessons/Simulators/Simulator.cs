using Domain.Education.Lessons.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Education.Lessons.Simulators
{
    internal class Simulator
    {
        public SimulatorId SimulatorId { get; }
        public LessonId LessonId { get; }
        public int StepNumber { get; private set; }
        public string InstructionText { get; private set; }
        public string BgImageUrl { get; private set; }
        public string HotspotJson {  get; private set; }// 4 координати
        public string HintText { get; private set; }
        private Simulator(SimulatorId simulatorId, LessonId lessonId, int stepNumber, string instructionText, string bgImageUrl, string hotspotJson, string hintText)
        {
            SimulatorId = simulatorId;
            LessonId = lessonId;
            StepNumber = stepNumber;
            InstructionText = instructionText;
            BgImageUrl = bgImageUrl;
            HotspotJson = hotspotJson;
            HintText = hintText;
        }

        public static Simulator New(SimulatorId simulatorId, LessonId lessonId, int stepNumber, string instructionText, string bgImageUrl, string hotspotJson, string hintText)
        {
            return new Simulator(
                simulatorId,
                lessonId,
                stepNumber,
                instructionText,
                bgImageUrl,
                hotspotJson,
                hintText);
        }

        public void UpdateSimulator(int stepNumber, string instructionText, string bgImageUrl, string hotspotJson, string hintText)
        {
            StepNumber = stepNumber;
            InstructionText = instructionText;
            BgImageUrl = bgImageUrl;
            HotspotJson = hotspotJson;
            HintText = hintText;
        }
    }
}
