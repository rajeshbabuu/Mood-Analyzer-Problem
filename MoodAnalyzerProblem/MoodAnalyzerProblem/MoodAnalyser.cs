using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string AnalyseMood(string message)
        {
            bool result = message.Contains("Sad");
            if (result)
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}