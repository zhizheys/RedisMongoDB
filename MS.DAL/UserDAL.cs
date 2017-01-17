namespace MS.DAL.User
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MS.Common.DBHelper;
    using MS.Common.LogHelper;
    using MS.Model;
    public class UserDAL
    {
        public static List<UserInfo_ViewModel> GetAllUserInfo()
        {

            var sql = @"SELECT   [UserName]
                                ,[UserEmail]
                                ,[PhoneNum]
                      FROM [TaskManager].[dbo].[p_User]";

            List<UserInfo_ViewModel> result;

            try
            {
                result = SQLHelper.ToList<UserInfo_ViewModel>(sql);
            }
            catch (Exception ex)
            {
                LogHelper.CreateInstance().Error("get all user error", ex);
                return null;
            }

            return result;
        }
    }
}
