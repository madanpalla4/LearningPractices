using ConsoleApp1.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ServiceHandler
{
    public class BikeManufacture : IronMachine
    {

        public bool MeltIron()
        {
            return true;
        }

        public string ShapetheIron()
        {
            return "Bike Shape";
        }

    }
}
