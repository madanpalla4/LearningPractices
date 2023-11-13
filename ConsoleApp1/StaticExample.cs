using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StaticExample
    {
        public static int age = 40;
        public static string FullName()
        {
            return "Palla Madan Kumar";
        }
    }

    public class nonSTaticExample
    {
        public int age;
    }
}
