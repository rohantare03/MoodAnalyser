using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        //<Summary>
        //UC4 CreateMoodAnalyse method create object of MoodAnalyse Class
        //</summary>
        ///<param name="className"></param>
        ///<param name="constructorName"></param>
        ///<returns></returns>
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            //create pattern to check class name and constructor name are same or not
            string pattern = "." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            //computation
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = assembly.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodanalyserCustomException(MoodanalyserCustomException.Exceptiontype.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new MoodanalyserCustomException(MoodanalyserCustomException.Exceptiontype.NO_SUCH_CONSTRUCTOR, "Constructor not found");
            }
        }
    }
}
