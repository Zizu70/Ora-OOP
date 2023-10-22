using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ora_OOP
{
    internal class Clock
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
        public string TimeZone { get; set; }
        public bool In24HourFormat { get; set; }

        public Clock(int hour, int minute, int second, string timeZone, bool in24HourFormat)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
            TimeZone = timeZone;
            In24HourFormat = in24HourFormat;              
        }
       
        public void SetTime(int hour, int minute, int second)
        { 
             this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public void DisplayTime()
        {
            string timeFormat = In24HourFormat ? "HH:mm:ss" : "h:mm tt";
            string myClockFormat = new DateTime(1, 1, 1, Hour, Minute, Second).ToString(timeFormat);
            Console.WriteLine($"\tAz idő: {myClockFormat} : {TimeZone} időzónában.");
        }

        public void SetTimeZone(string timeZone) 

        {
            this.TimeZone = timeZone;
        }
        
        public void ToggleTimeFormat() 

        {             
            In24HourFormat = !In24HourFormat;   //true - 24 órás - alapértelmezett

        }
    
    }
}
