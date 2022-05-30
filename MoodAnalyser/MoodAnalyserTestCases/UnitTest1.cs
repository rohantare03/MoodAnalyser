using NUnit.Framework;
using MoodAnalyser;

namespace MoodAnalyserTestCases
{
    public class MoodAnalyserTest 
    {
        Moodanalyser moodAnalyser;
        [SetUp]
        public void Setup()
        {
            moodAnalyser = new Moodanalyser();
        }
        //<summary>
        //uc1-1.1 :Given message "I am in SAD mood" returns SAD
        //</summary>
        [Test]
        public void Given_Message_in_SAD_Mood_returns_SAD_Message()
        {
            //Arrange
            string message = "I am in SAD mood";
            moodAnalyser = new Moodanalyser();
            //Act
            string expected = "SAD";
            string actual = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc1-1.2 :Given message "I am in any mood" returns HAPPY
        //</summary>
        [Test]
        public void Given_Message_in_any_Mood_returns_HAPPY_Message() 
        {
            //Arrange
            string message = "I am in any mood";
            moodAnalyser = new Moodanalyser();
            //Act
            string expected = "HAPPY";
            string actual = moodAnalyser.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}