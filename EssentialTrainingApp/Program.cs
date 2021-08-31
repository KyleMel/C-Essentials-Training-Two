using System;
using System.Collections.Generic;
using System.IO;

namespace EssentialTrainingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("bread");
            Words.Add("milk");
            Words.Add("cheese");

            CrazyMathProblem();
            ReadTextFile();
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            try
            {
                using(var sr = new StreamReader(@"C:\temp\test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Directory not found");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("file not found");
            }
            catch(Exception ex)
            {
                Console.WriteLine("an unknown error occured " + ex.Message);
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for(var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
