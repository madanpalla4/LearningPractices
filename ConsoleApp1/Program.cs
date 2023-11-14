using ApplicationLayer.InterfaceService;
using ApplicationLayer.Model;
using ApplicationLayer.Service;

public class Program
{
    //types values types and refrence type
    public static void Main()
    {
        Console.WriteLine( "Welcome. please enter to Login Screen");
        Console.ReadLine();
        Console.WriteLine("Enter UserName and click Enter");
        UserModel us=new UserModel();
        us.UserName = Console.ReadLine();
        Console.WriteLine("ENter Password and press enter to Login");
        us.Password = Console.ReadLine();
        InterfaceUserService interfaceUserService = new UserService();
        bool reponse= interfaceUserService.ValidateLogin(us);
        if (reponse == true)
        {
            Console.WriteLine(  "Successsfully Login");
        }
        else
        {
            Console.WriteLine( "Login Failed due to Username or Password Mismatch");
        }
    }

   
}




//2 types - values types --refrence tyeps
//