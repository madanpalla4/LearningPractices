using ApplicationLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.InterfaceService
{
    public interface InterfaceUserService
    {
        bool ValidateLogin(UserModel user);
    }
}
