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

        public Moodanalyser(string message) 
        {
            this.message = message;
        }
        public string AnalyseMood() 
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
