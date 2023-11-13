using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Accelarate, Break, Clutch
    /// person->> livers ABC
    /// >> internall funtioncality teliyadhu
    /// implemntation is in hidden
    /// Hiding the data -- Private accesmodifies
    /// </summary>
   
    public abstract class Functinalities{

        public abstract int Accelarte();
        public DateTime CurrTime()
        {
            return DateTime.Now;
        }
        public static string Name()
        {
            return "";
        }
    }
    public abstract class Anotherfun
    {
        public abstract int Accelarte();
    }
    public class CarExample : Functinalities
    {
        public override int Accelarte()
        {
            return 30;
        }
    }

    public class Bike : Functinalities
    {
        public override int Accelarte()
        {
            return 20;
        }
    }

    public class Cycle
    {
        public int Accelarte()
        {
            return 10;
        }
    }
}
