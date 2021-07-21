using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace Hometask5
{
    //Створити клас TickerTimer який містить
    // - методи StartTimer, StopTimer,
    // - подію TickEvent, що генерується через певний проміжок часу який задається властивістю Interval у вигляді мілісекунд.
    //Продемонструвати роботу класу TickerTimer з виводом на консоль.
    //Запуск і зупинка таймера задається через консоль
    class Program
    {
        public static void TickerTimer_OnInterval(object sender, EventArgs args)
        {
            Console.WriteLine("Tык");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TickerTimer timer = new TickerTimer(10000, 300);
            timer.IntervalEnded += TickerTimer_OnInterval;

            Console.WriteLine("Started working. Press any key to abort");
            timer.StartTimer();     

            Console.ReadKey();
            Console.WriteLine("Stopped");
            timer.StopTimer();
        }


    }
}
