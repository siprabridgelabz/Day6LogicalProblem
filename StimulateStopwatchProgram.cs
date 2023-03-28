using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProblem
{
    public class StimulateStopwatchProgram
    {
        public static void FindStimulateStopwatchProgram()
        {
            
            Stopwatch stopwatch = new Stopwatch();

         
            stopwatch.Start();

            
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

           
            stopwatch.Stop();

        
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
        }
    }
}
    
