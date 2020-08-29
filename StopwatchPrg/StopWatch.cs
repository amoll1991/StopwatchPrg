using System;
using System.Collections.Generic;
using System.Text;

namespace StopwatchPrg
{
    class StopWatch
    {
        DateTime startTime { get; set; }
        DateTime stopTime { get; set; }
        bool flag = false;
        public void Start()
        { 
            if (flag == false)
            {
                startTime = DateTime.Now;
                flag = true;
            }
        }
        public void Stop()
        {   
            if (flag == true)
            {
                stopTime = DateTime.Now;
                flag = false;
            }
        }
        public TimeSpan GetInterval()
        {
            return(stopTime-startTime);
        }
    }
}
