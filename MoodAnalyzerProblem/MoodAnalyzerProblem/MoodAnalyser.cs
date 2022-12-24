using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnayser
    {

        public string message;
        public MoodAnayser() //
        {

        }
        public MoodAnayser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message == "")
                {
                    throw new CustomException(CustomException.ExceptionType.empty, "It is a empty string");

                }
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
            catch (CustomException obj)
            {
                return obj.Message;
            }
        }
    }

    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            Null, empty,
            InvalideClass,
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }

    public class MoodAnayserFactory // Reflection 
    {
        public static object CreateInstance(string ClassName)
        {
            try
            {
                Type type = Type.GetType(ClassName);
                if (type == null)
                {
                    throw new CustomException(CustomException.ExceptionType.InvalideClass, "No such class");
                }
                return type;
            }
            catch (CustomException obj)
            {
                return obj.Message;
            }
        }
    }
}

    
