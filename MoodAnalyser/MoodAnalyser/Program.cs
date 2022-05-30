namespace MoodAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analysis");
            Moodanalyser moodAnalyser = new Moodanalyser("null");
            moodAnalyser.AnalyseMood();
        }
    }
}
