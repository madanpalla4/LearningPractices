using ApplicationLayer.InterfaceService;
using ApplicationLayer.Model;

namespace ApplicationLayer.Service
{
    public class UserService :InterfaceUserService
    {

        public bool ValidateLogin(UserModel user)
        {
            if(user.UserName==SuperUser.UserName && user.Password == SuperUser.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
