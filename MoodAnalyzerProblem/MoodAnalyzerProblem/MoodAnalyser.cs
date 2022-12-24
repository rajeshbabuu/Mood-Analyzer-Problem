using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    internal class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            // string messeage = "I am in Sad Mood";
            bool result = message.Contains("Sad");
            if (result)
            {
                return "Sad";
            }
            else
            {
                return "";
            }
        }
    }
}

