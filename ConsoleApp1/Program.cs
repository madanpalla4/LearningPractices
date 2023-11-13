using ConsoleApp1;


public class Program
{
    //types values types and refrence type
    public static void Main()
    {
       Functinalities ex=new CarExample();
        Console.WriteLine( ex.Accelarte());
        Functinalities ex2 = new Bike();

        ex2.Accelarte();

        derviation d = new derviation(new Bike());
        derviation d1 = new derviation(new CarExample()); // injection
                                                          //derviation d2 = new derviation(new Cycle());
        ImplemnetInterface test=new ImplemnetInterface();
        test.SentEmail();
        test.CalculateMyage();
        


    }

   
}

public class derviation
{
    private Functinalities Encapsulationfn;
    //private Bike bike;
    public derviation(Functinalities fn)
    {
        Encapsulationfn = fn;
        fn.CurrTime();
        Functinalities.Name();
    }


}



//2 types - values types --refrence tyeps
//