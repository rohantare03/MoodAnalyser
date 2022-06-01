using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodanalyserCustomException : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            EMPTY_NULL, EMPTY_MOOD
        }
        public MoodanalyserCustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
