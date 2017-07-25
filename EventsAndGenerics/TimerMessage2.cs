using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace EventsAndGenerics
{
    class TimerMessage2
    {

        public TimerMessage2(Timer timer)
        {
            timer.TimerStoped += Message;
        }

        private void Message(object o, EventArgs args)
        {
            Console.WriteLine("Timer Message 2");
        }
    }
}
