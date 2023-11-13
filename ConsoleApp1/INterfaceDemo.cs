using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //interface also Creates an pure Abstraction
    public interface InterfaceDemo
    {
        void MyName();
        void Myname(string name);
    }
    public interface InterfaceDemo1
    {
        void CalculateMyage();
        //void MyName();
        //void Myname(string name);
    }
    public interface InterfaceDemo2
    {
        void SentEmail();
        //void MyName();
        //void Myname(string name);
    }
    public interface InterfaceDemo3
    {
        void MyName();
        //void Myname(string name);
    }


    public class ImplemnetInterface : InterfaceDemo, InterfaceDemo1, InterfaceDemo2, InterfaceDemo3
    {
        public void MyName()
        {
            throw new NotImplementedException();
        }

        public void Myname(string name)
        {
            throw new NotImplementedException();
        }
        public void CalculateMyage()
        {

        }

        public void SentEmail()
        {
        }
    }
}
