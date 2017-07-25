using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events;

namespace EventsAndGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer=new Timer(10);

            TimerMessage1 timerMessage1=new TimerMessage1(timer);
            TimerMessage2 timerMessage2=new TimerMessage2(timer);

            timer.Start();
            
            Timer timer2=new Timer(4);
            timerMessage1=new TimerMessage1(timer2);
            timer2.Start();

            Console.ReadKey();
        }
    }
}
