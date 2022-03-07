using System;
using System.Collections.Generic;
using System.Text;

namespace EnumExtended
{
    public static partial class Enum3Ext
    {
        public static void Test(this Enum2 value, string str)
        {
            Console.WriteLine(str);
        }
    }
}
