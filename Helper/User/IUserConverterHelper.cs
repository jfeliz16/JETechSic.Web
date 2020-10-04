using JETech.SIC.Core.User.Models;
using JETech.SIC.Web.Models;

namespace JETech.SIC.Web.Helper.User
{
    public interface IUserConverterHelper
    {
        LoginModel ToLoginModel(LoginViewModel login);
        UserModel ToUserModel(AddUserViewModel model);
    }
}