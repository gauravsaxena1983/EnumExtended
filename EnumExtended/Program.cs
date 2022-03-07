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

            var num1 = Enum3Ext.KeyOf("A_1");
            switch (num1)
            {
                case Enum3.A:
                    Console.WriteLine("A");
                    break;
                case Enum3.B:
                    Console.WriteLine("B");
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
                var str = Enum3.A.ToStringLite();
                i++;
            }
            stopwatch.Stop();

            Console.WriteLine(stopwatch.Elapsed.Seconds);
        }
    }

}
