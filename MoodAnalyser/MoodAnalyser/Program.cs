namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analysis");
            Moodanalyser moodAnalyser = new Moodanalyser("I am in any mood");
            moodAnalyser.AnalyseMood();
        }
    }
}
