

namespace MS.BLL.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MS.DAL.User;
    using MS.Model;

    public static class UserBLL
    {
        public static List<UserInfo_ViewModel> GetAllUserInfo()
        {
            return UserDAL.GetAllUserInfo();
        }

    }
}
