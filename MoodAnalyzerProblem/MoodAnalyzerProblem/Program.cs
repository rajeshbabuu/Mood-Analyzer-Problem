namespace MoodAnalyzerProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyzer Program");
            Console.WriteLine("Enter string to check Mood ");
            // string mood = Console.ReadLine();
            MoodAnalyser moodAnayser = new MoodAnalyser();

            MoodAnalyser obj = new MoodAnalyser();
            string res = obj.AnalyseMood("I am in Sad Mood");
            Console.WriteLine(res);
        }
    }
}