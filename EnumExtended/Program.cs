using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EnumExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var num1 = Number1Util.GetNumber1("");
            switch (num1)
            {
                case Number1.One:
                    Console.WriteLine("One");
                    break;
                case Number1.Two:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("None");
                    break;
            }


            Run();
        }

        static void Run()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            int i = 0;
            while (i < 100000000)
            {
                var str = Enum2.A.ToStringLite();
                i++;
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.Seconds);
        }
    }

}
