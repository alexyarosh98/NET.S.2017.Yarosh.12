using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    public class Timer
    {
        /// <summary>
        /// Event to be started after time is out
        /// </summary>
        public event EventHandler TimerStoped;
        private int time;
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="time">Starting time for Timer (in sec)</param>
        public Timer(int time)
        {
            this.time = time;
        }
        /// <summary>
        /// Starting timer
        /// </summary>
        public void Start()
        {
            Thread.Sleep(time*1000);
            TimeIsOut(this,new EventArgs());

        }

        private void TimeIsOut(object o, EventArgs args)
        {
            
                TimerStoped(o, args);
            
        }
    }
}
