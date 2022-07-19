using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingAOCShit._2015
{
    public class Day2_2015
    {
        public static List<Present> Presents = new List<Present>();
        public static void SolvePart1()
        {
            string[] lines = Program.ReadFile("2015-day2.txt");
            int total = 0;
            foreach (string line in lines)
            {
                string[] parts = line.Split('x');
                Present p = new Present(Int32.Parse(parts[0]), Int32.Parse(parts[1]), Int32.Parse(parts[2]));
                total += p.surface;
                Presents.Add(p);
            }
            Console.WriteLine("The fucks needs {0} total paper", total);
        }

        public static void SolvePart2()
        {
            int total = 0;
            foreach (Present p in Presents)
            {

            }

            Console.WriteLine("The fucks needs {0} total ribbon", total);
        }

        public class Present
        {
            int l = 0;
            int w = 0;
            int h = 0;
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            int smallest = 0;
            public int surface = 0;

            public Present(int len, int wid, int hei)
            {
                l = len;
                w = wid;
                h = hei;

                side1 = l * w;
                side2 = w * h;
                side3 = h * l;
                smallest = side1;
                if (side2 < smallest)
                    smallest = side2;
                if (side3 < smallest)
                    smallest = side3;
                surface = 2*(side1 + side2 + side3);
                surface += smallest;
            }
        }
    }
}
