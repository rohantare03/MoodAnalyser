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
            EMPTY_NULL, EMPTY_MOOD, NO_SUCH_CLASS, NO_SUCH_CONSTRUCTOR 
        }
        public MoodanalyserCustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
