using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingAOCShit._2015
{
    public class Day1_2015
    {
        public static void SolvePart1()
        {
            string input = Program.ReadFileAsOneLine("2015-Day1.txt");
            int floor = 0;
            foreach(char c in input)
            {
                if (c == '(')
                    floor++;
                else
                    floor--;
            }
            Console.WriteLine("Santa must go to floor: {0}", floor);
        }

        public static void SolvePart2()
        {
            string input = Program.ReadFileAsOneLine("2015-Day1.txt");
            int floor = 0;
            int instruction = 0;
            foreach (char c in input)
            {
                if (c == '(')
                    floor++;
                else
                    floor--;

                instruction++;
                if (floor < 0)
                {
                    break;
                }               
            }
            Console.WriteLine("First instruction to cause santa to go to the basement is: {0}", instruction);
        }
    }
}
