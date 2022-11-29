using System;
using static System.Net.Mime.MediaTypeNames;

namespace ev_tapsiriqlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "salam p327";
            Console.WriteLine(test.ToUpper());

        }

        static void test(params string[] test)
        {
            foreach (string item in test)
            {
                Console.WriteLine(test);
            }
        }


    }
    }


