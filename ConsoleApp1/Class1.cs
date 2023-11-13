using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //abstract Classes and Interface
    //
    public class Class1:Services
    {
        public int GetSum(int i,int j)
        {
            return i + j;
        }
        public string GetName()
        {
            return "Teja";
        }
        public string GetAddress(int pincode)
        {
            return "Proddatur";
        }
        /// <summary>
        /// class1 > Refrence type
        /// >> intilizing or Objecting
        /// >>
        /// </summary>
        /// <returns></returns>
        public Class1 getSomething()
        {
            return new Class1();
        }
    }


    public interface Services
    {
        int GetSum(int i, int j);
        string GetName();
        string GetAddress(int pincode);
    }
}
