using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Moodanalyser 
    {
        public string message;

        public Moodanalyser()
        {
            this.message = "I am in any mood";
        }
        public string AnalyseMood(string message) 
        {
            if (message.Contains("SAD"))
            {
                Console.WriteLine("The mood is SAD");
                return "SAD";
            }
            else
            {
                Console.WriteLine("The mood is HAPPY");
                return "HAPPY";
            }
        }
    }
}
