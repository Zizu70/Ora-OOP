using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ora_OOP
{
    internal class Timer
    {
        public int RemainingSeconds { get; set; } 

        public Timer(int remainingSeconds)
        { 
            this.RemainingSeconds = remainingSeconds; 
        }
        
        public void SetTime(int seconds)
        {
            this.RemainingSeconds = seconds; 
        }

        public void StartTimer()
        {
            while (RemainingSeconds > 0)
            {
                Console.WriteLine($"A hátralévő idő: {RemainingSeconds} másodperc.");
                Thread.Sleep(1000); 
                RemainingSeconds--;
            }
            Console.WriteLine("Időzítés lejárt!");
        }
    }
}
