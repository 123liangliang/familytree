using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserBLL
    {
        #region 验证用户密码
        /// <summary>
        /// 验证用户密码
        /// </summary>////根据 ui 选择返回一个user
        public bool CheckUser(UserModel User)
        {
            return UserDAL.CheckUser(User);
        }
        #endregion

        #region 查看用户名是否存在
        /// <summary>
        /// 查看用户名是否存在
        /// </summary>
        public bool ExistUser(UserModel User)
        {
            return UserDAL.ExistUser(User);
        }
        #endregion

        #region 身份验证 and 查找密码

        /// <summary>
        /// 身份验证 and 查找密码
        /// </summary>
        public bool ConfirmUser(UserModel User)
        {
            return UserDAL.ConfirmUser(User);
        }
        #endregion

        #region 注册用户

        /// <summary>
        /// 添加一个用户
        /// </summary>
        public bool AddUser(UserModel User)
        {
            return UserDAL.AddUser(User);
        }
        #endregion

        #region 修改密码

        /// <summary>
        /// 修改密码
        /// </summary>
        public bool ChangePassword(UserModel User)
        {
            return UserDAL.ChangePassword(User);
        }
        #endregion

        #region 注销用户

        /// <summary>
        /// 注销用户
        /// </summary>
        public bool CLUser(UserModel User)
        {
                return UserDAL.CLUser(User);
        }
        #endregion

        #region 管理员登录验证
        /// <summary>
        /// 管理员登录验证
        /// </summary>
        public bool CheckAdmin(UserModel User)
        {
            return UserDAL.CheckAdmin(User);
        }
        #endregion

        #region 修改用户信息

        /// <summary>
        /// 修改用户信息
        /// </summary>
        public bool ChangeInfo(UserModel User)
        {
                return UserDAL.ChangeInfo(User);
        }
        #endregion

        #region 按用户名查询用户信息
        /// <summary>
        /// 按用户名查询用户信息
        /// </summary>
        public string UserInfo(UserModel User)//返回一个string，按顺序存储用户的所有信息，用空格隔开
        {
            return UserDAL.UserInfo(User);
        }
        #endregion

        #region 加载所有用户的信息

        /// <summary>
        /// 加载所有用户的信息
        /// </summary>
        public static List<UserModel> UserList()
        {
            return UserDAL.UserList();
        }
        #endregion

        //#region 在DATaGridView中修改用户信息

        ///// <summary>
        ///// 在DATaGridView中修改用户信息
        ///// </summary>
        //public bool UpdateInfo()
        //{
        //    return UserDAL.UpdateInfo();
        //}
        //#endregion
    }
}
