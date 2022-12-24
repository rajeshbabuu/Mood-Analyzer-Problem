using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string message;
        static MoodAnalyser() 
        {

        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                bool result = this.message.Contains("Sad");

                if (result)
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }
        }
    }
}