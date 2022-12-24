using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            Null, empty, InvalideClass, Invalideconstructor,

        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }


    public class MoodAnayserFactory // Reflection 
    {
        public MoodAnayserFactory()
        {

        }
        public static object CreateInstance(string ClassName, [Optional] string ConstructorName)
        {
            try
            {
                Type type = Type.GetType(ClassName);
                if (type == null)
                {
                    throw new CustomException(CustomException.ExceptionType.InvalideClass, "No such class");
                }

                var constructor = type.GetConstructor(new[] { typeof(string) });
                if (constructor.ToString() != ConstructorName)
                {
                    throw new CustomException(CustomException.ExceptionType.Invalideconstructor, "wrong constructor");
                }

                object instance = constructor.Invoke(new object[] { "HAPPY" });
                return instance;
                // return type;
            }
            catch (CustomException obj)
            {
                return obj.Message;
            }

        }
    }
}