using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class AppBLL
    {
        #region 添加应用

        /// <summary>
        /// 添加应用
        /// </summary>
        public bool AddApp(UserModel User)
        {
            return AppDAL.AddApp(User);
        }
        #endregion

        #region 查看该用户名是否已购买此应用
        /// <summary>
        /// 查看该用户名是否已购买此应用
        /// </summary>
        public string UserHaveApp(UserModel User)
        {
            return AppDAL.UserHaveApp(User);
        }
        #endregion
    }
}
