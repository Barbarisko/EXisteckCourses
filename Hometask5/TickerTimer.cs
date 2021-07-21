using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hometask5
{
    //Створити клас TickerTimer який містить
    // - методи StartTimer, StopTimer,
    // - подію TickEvent, що генерується через певний проміжок часу який задається властивістю Interval у вигляді мілісекунд.
    public delegate void Tick(object sender, EventArgs args);
    public class TickerTimer
    {
        public event EventHandler IntervalEnded; 

        private uint interval;
        private uint skolko_jdat;
        private bool wokr;

        public TickerTimer(uint _skolko_jdat, uint _interval)
        {
            skolko_jdat = _skolko_jdat;
            interval = _interval;
        }
        public void StartTimer()
        {
            if (!wokr)
            {
                wokr = true;
                Thread thread = new Thread(Random_funk);
                thread.Start();
            }            
        }

        private void Random_funk()
        {
            for (uint i = skolko_jdat; i >= 0 && wokr;)
            {
                i -= interval;
                Thread.Sleep((int)interval);

                if (IntervalEnded != null)
                {
                    IntervalEnded(this, new EventArgs());
                    
                }
            }
            wokr = false;
            Console.WriteLine("Tick-tack, youre dead");
        }


        public void StopTimer()
        {
            wokr = false;
        }

    }
}
