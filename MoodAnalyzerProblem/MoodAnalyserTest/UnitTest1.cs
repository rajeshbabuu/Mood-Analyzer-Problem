namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MoodAnayser moodAnayser = new MoodAnayser("I am in Any Mood");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("HAPPY".ToUpper(), result);
        }

        [TestMethod]
        public void TestSadOrHappyMood()
        {
            MoodAnayser moodAnayser = new MoodAnayser("I am in Sad Mood");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("SAD".ToUpper(), result);
        }

        [TestMethod]
        public void TestForHappyMood()
        {
            MoodAnayser moodAnayser = new MoodAnayser("I am in Happy Mood");
            string result = moodAnayser.AnalyseMood();
            Assert.AreEqual("HAPPY".ToUpper(), result);
        }
    }
}
        
    
