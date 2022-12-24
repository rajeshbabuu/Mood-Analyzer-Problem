using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases1
{
    internal class MoodTester
    {
        [TestMethod]
        public void TestHappyOrSad()
        {
            MoodAnalyzerProblem.MoodAnalyzer objMood = new MoodAnalyzerProblem.MoodAnalyzer("Happy"); // Arrange

            string result = objMood.AnalyzeMood(); // Act

            Assert.AreEqual("Happy".ToUpper(), result); //Assert
        }
    }
}
