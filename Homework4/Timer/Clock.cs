using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Clock
{
    public delegate void TickHandler(object sender, ClockEventArgs args);
    public delegate void AlarmHandler(object sender, ClockEventArgs args);
    public class ClockEventArgs
    {
        public ClockEventArgs(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }
    }

    class Clock
    {
        private int hour;
        private int minute;
        private int second;
        private int alarmHour;
        private int alarmMinute;
        private int alarmSecond;
        public int Hour
        {
            get => hour;
            set => hour = (value < 0 || value >= 24) ? 0 : value;
        }
        public int Minute
        {
            get => minute;
            set => minute = (value < 0 || value >= 60) ? 0 : value;
        }
        public int Second
        {
            get => second;
            set => second = (value < 0 || value >= 60) ? 0 : value;
        }
        public int AlarmHour
        {
            get => alarmHour;
            set => alarmHour = (value < 0 || value >= 24) ? 0 : value;
        }
        public int AlarmMinute
        {
            get => alarmMinute;
            set => alarmMinute = (value < 0 || value >= 60) ? 0 : value;
        }
        public int AlarmSecond
        {
            get => alarmSecond;
            set => alarmSecond = (value < 0 || value >= 60) ? 0 : value;
        }
        private readonly Timer timer;
        public Clock(int h, int m, int s, int alh, int alm, int als)
        {
            Hour = h;
            Minute = m;
            Second = s;
            AlarmHour = alh;
            AlarmMinute = alm;
            AlarmSecond = als;
            //tick per 1000ms
            int interval = 1000;        
            timer = new Timer(interval);
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(Tick);
            OnTick += new TickHandler(Alarm);
        }
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        private void Tick(object sender, ElapsedEventArgs e)
        {
            Second++;
            if(Second == 0)
            {
                Minute++;
                if(Minute == 0)
                {
                    Hour++;
                }
            }
            OnTick(this, new ClockEventArgs(Hour, Minute, Second));
        }
        private void Alarm(object sender, ClockEventArgs e)
        {
            if (e.Hour != AlarmHour || 
                e.Minute != AlarmMinute || 
                e.Second != AlarmSecond)
                return;
            OnAlarm(this, e);
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
    }
}
