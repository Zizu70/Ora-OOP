using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ora_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("***** ÓRA *****");
            Console.WriteLine();

            Clock myClock = new Clock(12, 30, 45, "UTC+2", true); 
                       
            Console.WriteLine("Az idő 24 órás formátum szerint:");
            myClock.DisplayTime();

            myClock.ToggleTimeFormat(); 

            Console.WriteLine("Az idő 12 órás formátum szerint:");
            myClock.DisplayTime();

            Console.WriteLine();
            Console.WriteLine("***** ÉBRESZTŐ *****");
            Console.WriteLine();
                                
            List<Alarm> riasztasok = new List<Alarm>();

            riasztasok.Add(new Alarm(06, 00));
            riasztasok.Add(new Alarm(08, 00));
            riasztasok.Add(new Alarm(12, 30));
            riasztasok.Add(new Alarm(12, 30)); 
            
            Console.WriteLine("Minden ébresztés:");
            foreach (var Alarm in riasztasok)
            {
                Console.WriteLine($"Beállított ébresztés: {Alarm.AlarmHour}:{Alarm.AlarmMinute}, Aktív-e: {Alarm.IsAlarmOn}");
            }
            Console.WriteLine();

            Console.WriteLine("Ébresztések:");
            foreach (var Alarm in riasztasok)
            {
                if (Alarm.IsAlarmTime(myClock.Hour, myClock.Minute))
                {
                    Console.WriteLine($"Ébresztés: {myClock.Hour} : {myClock.Minute}");
                    Console.WriteLine("Az ébresztő megszólalt!");
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("***** IDŐZÍTŐ *****");
            Console.WriteLine();

            Timer idozito = new Timer(10);
            
            idozito.StartTimer();
            

            Console.ReadKey();
        }
    }
}
