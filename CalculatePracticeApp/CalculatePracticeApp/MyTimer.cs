using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePracticeApp
{
    public class MyTimer
    {
        public static double GetElapsedSeconds(DateTime start)
        {
            return (DateTime.Now - start).TotalSeconds;
        }
    }
}
