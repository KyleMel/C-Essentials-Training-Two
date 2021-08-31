using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace EssentialTrainingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("the program started");
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
                logger.Error("directory not found " + ex.Message);
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("file not found");
                logger.Error(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("an unknown error occured " + ex.Message);
            }
            finally
            {
                Console.WriteLine("the finally runs all the time ");
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
