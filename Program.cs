using FuckingAOCShit._2015;

namespace FuckingAOCShit
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Day1_2015.SolvePart1();
            Day1_2015.SolvePart2();
            Day2_2015.SolvePart1();
            Day2_2015.SolvePart2();
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