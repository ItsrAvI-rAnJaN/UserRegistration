using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzers
{
    public class MoodAnalyzer
    {
        public string AnalyzeMood(string Messsage)
        {
            if (Messsage.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
