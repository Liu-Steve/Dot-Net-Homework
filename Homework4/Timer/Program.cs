using System;
using System.Threading;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Testing Clock-----");
            Clock clk = new(12, 59, 50, 13, 00, 01);
            clk.OnTick += new TickHandler(TickOutput);
            clk.OnAlarm += new AlarmHandler(AlarmOutput);
            clk.Start();
            Thread.Sleep(12000);
            Console.WriteLine("-----Time is over-----");
        }
        static String ShowTime(ClockEventArgs e)
        {
            //make sure length is 2 number
            String h = e.Hour.ToString().PadLeft(2, '0');
            String m = e.Minute.ToString().PadLeft(2, '0');
            String s = e.Second.ToString().PadLeft(2, '0');
            return $"{h}:{m}:{s}";
        }
        static void TickOutput(object sender, ClockEventArgs e)
        {
            Console.WriteLine($"Tick:\t{ShowTime(e)}");
        }
        static void AlarmOutput(object sender, ClockEventArgs e)
        {
            Console.WriteLine($"Alarm:\t{ShowTime(e)}");
            ((Clock)sender).Stop();
        }
    }
}
