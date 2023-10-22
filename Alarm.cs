using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ora_OOP
{
    internal class Alarm
    {
        public int AlarmHour { get; set; }
        public int AlarmMinute { get; set;}
        public bool IsAlarmOn { get; set;}


        public Alarm(int alarmHour, int alarmMinute) 
        {
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            IsAlarmOn = true;                    
        }

        public void SetAlarm(int hour, int minute)
        {
            this.AlarmHour = hour;
            this.AlarmMinute = minute;           
        }
       
        public void TurnOnAlarm()
        {
            IsAlarmOn = true;            
            Console.WriteLine($"Az ébresztés bekapcsolva: {AlarmHour} : {AlarmMinute} időpontra.");
        }

        public void TurnOffAlarm() 
        {
            IsAlarmOn = false;
            Console.WriteLine($"Az ébresztés nincs bekapcsolva!");
        }
        
        public bool IsAlarmTime(int hour, int minute)
        {
            return IsAlarmOn && AlarmHour == hour && AlarmMinute == minute;
        }

        










    }




}
