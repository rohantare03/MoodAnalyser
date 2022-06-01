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
            moodAnalyser = new Moodanalyser("null");
        }
        //<summary>
        //uc1Refactor-1.1 :Given message "I am in SAD mood" returns SAD
        //</summary>
        [Test]
        public void Given_Message_in_SAD_Mood_returns_SAD_Message()
        {
            //Arrange
            string message = "I am in SAD mood";
            moodAnalyser = new Moodanalyser(message);
            //Act
            string expected = "SAD";
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc1Refactor-1.2 :Given message "I am in any mood" returns HAPPY
        //</summary>
        [Test]
        public void Given_Message_in_any_Mood_returns_HAPPY_Message() 
        {
            //Arrange
            string message = "I am in any mood";
            moodAnalyser = new Moodanalyser(message);
            //Act
            string expected = "HAPPY";
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc2-2.1 :Handle null exception returns HAPPY
        //</summary>
        [Test]
        public void Handle_Null_Exception_returns_HAPPY() 
        {
            //Arrange
            string message = null;
            moodAnalyser = new Moodanalyser(message);
            //Act
            string expected = "HAPPY";
            string actual = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //<summary>
        //uc3-3.1 :Given null mood throw custom exception
        //</summary>
        [Test]
        public void Given_NullMood_Return_Custom_Exception()
        {
            //Arrange
            string message = null;
            string expected = "The mood should not be null";
            try
            {
                //Act
                moodAnalyser = new Moodanalyser(message);
            }
            catch (MoodanalyserCustomException exception)
            {
                //Assert
                Assert.AreEqual(expected, exception.Message);
            }

        }
        //<summary>
        //uc3-3.2 :Given Empty mood throw custom exception
        //</summary>
        [Test]
        public void Given_Empty_Mood_Returns_Custom_Exception()
        {
            //Arrange
            string message = " ";
            string expected = "The mood should not be null";
            try
            {
                //Act
                moodAnalyser = new Moodanalyser(message);
            }
            catch (MoodanalyserCustomException exception)
            {
                //Assert
                Assert.AreEqual(expected, exception.Message);
            }
        }
        //<summary>
        //UC4-4.1 Given MoodAnalyse Class name should return moodanalyse object
        //</summary>
        [Test]
        public void MoodAnalyserClassName_Should_Return_MoodAnalyserObject()
        {
            string message = null;
            object expected = new Moodanalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.Moodanalyser", "Moodanalyser");
            expected.Equals(obj);
        }
        //<summary>
        //UC4-4.2 Given MoodAnalyse ClassName when Improper should throw exception
        //</summary>
        [Test]
        public void MoodAnalyserClassName_Improper_Should_ThrowMoodAnalyserException()
        {
            string expected = "Class not found";
            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyser.Mood", "Mood");
            }
            catch (MoodanalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
        //<summary>
        //UC4-4.3 Given MoodAnalyse Class Name When Constructor is Improper should throw Exception
        //</summary>
        [Test]
        public void MoodAnalyseClassName_ConstructorIsImproper_Should_ThrowMoodAnalyserException()
        {
            object obj = null;
            string expected = "Constructor not found";
            try
            {
                obj = MoodAnalyserFactory.CreateMoodAnalyse("Moodanalyser.MoodAnalyser", "Mood");
            }
            catch (MoodanalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }
    }
}