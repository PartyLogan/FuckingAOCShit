using FuckingAOCShit._2015;
using System;
using System.Diagnostics;

namespace FuckingAOCShit
{
    internal class Program
    {
        const long TicksPerMicrosecond = 10;

        static void Main(string[] args)
        {
            Thread.Sleep(100);
            Stopwatch timer = Stopwatch.StartNew();
            Day1_2015.SolvePart1();
            TimerStop(timer);

            timer.Restart();
            Day1_2015.SolvePart2();
            TimerStop(timer);

            timer.Restart();
            Day2_2015.SolvePart1();
            TimerStop(timer);

            timer.Restart();
            Day2_2015.SolvePart2();
            TimerStop(timer);
        }

        public static void TimerStop(Stopwatch timer)
        {
            timer.Stop();
            TimeSpan timespan = timer.Elapsed;
            long microseconds = timer.ElapsedTicks / TicksPerMicrosecond;
            Console.WriteLine("Time taken: {0} us", microseconds);
        }
        public static string ReadFileAsOneLine(string file)
        {
            string text = System.IO.File.ReadAllText("inputs/"+file);
            return text;
        }

        public static string[] ReadFile(string file)
        {
            string[] lines = System.IO.File.ReadAllLines("inputs/" + file);
            return lines;
        }
    }
}