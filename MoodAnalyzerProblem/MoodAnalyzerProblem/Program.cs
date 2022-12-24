namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            // MoodAnayser obj = new MoodAnayser("I am in SAD Mood");
            MoodAnayser obj = new MoodAnayser(null);

            string res = obj.AnalyseMood();
            Console.WriteLine(res);

        }
    }
}