using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask5
{
    //Створити клас TickerTimer який містить
    // - методи StartTimer, StopTimer,
    // - подію TickEvent, що генерується через певний проміжок часу який задається властивістю Interval у вигляді мілісекунд.
    public class TickerTimer
    {
        private int interval;

        public int Interval { get => interval; set => interval = value; }

        public void StartTimer()
        {

        }
        public void StopTimer()
        {

        }

    }
}
