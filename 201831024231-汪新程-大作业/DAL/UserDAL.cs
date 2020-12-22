using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;
using System.Data;

namespace DAL
{

    public class UserDAL
    {
        #region 验证用户密码
        /// <summary>
        /// 验证用户密码
        /// </summary>
        public static bool CheckUser(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();
            string stName = User.UserName;
            string stPassword = User.UserName;
            string sql = @"Select * from login where 用户名='" + stName + "'";//用于查询用户名
            OleDbCommand cmdFindname = new OleDbCommand(sql, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();

            bool result = false;
            while (dr.Read()) //开始读取数据
            {
                if (User.UserName == dr["用户名"].ToString() && User.UserPwd == dr["密码"].ToString())
                {
                    result = true;
                }
            }
            mycon.Close();
            return result;
        }
        #endregion

        #region 查看用户名是否存在
        /// <summary>
        /// 查看用户名是否存在
        /// </summary>
        public static bool ExistUser(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();
            string stName = User.UserName;
            string stPassword = User.UserName;
            string sql = @"Select * from login where 用户名='" + stName + "'";//用于查询用户名
            OleDbCommand cmdFindname = new OleDbCommand(sql, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();
            bool exist = false;
            while (dr.Read()) //开始读取数据
            {
                exist = true;
            }
            mycon.Close();
            return exist;
        }
        #endregion

        #region 身份验证 and 查找密码

        /// <summary>
        /// 身份验证 and 查找密码
        /// </summary>
        public static bool ConfirmUser(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            string sql = @"Select * from login where 用户名='" + User.UserName + "'";
            OleDbConnection conn = new OleDbConnection(sqlcon);//创建command对象，指定要执行sql语句与连接对象conn
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            bool result = false;
            while (dr.Read())
            {
                if (User.RealName == dr["真实姓名"].ToString() && User.IDType == dr["证件类型"].ToString()
                    && User.ID == dr["证件号码"].ToString() && User.Province == dr["省份"].ToString() && User.City == dr["城市"].ToString())
                {
                    User.UserPwd = dr["密码"].ToString();
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        #endregion

        #region 注册用户

        /// <summary>
        /// 添加一个用户
        /// </summary>
        public static bool AddUser(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            string comStr = @"Insert into login(用户名,密码,真实姓名,证件类型,证件号码,省份,城市,管理员) values(";
            comStr += "'" + User.UserName + "','" + User.UserPwd + "','" + User.RealName + "','" + User.IDType + "','" + User.ID + "','" + User.Province + "','" + User.City + "','" + User.Admin + "')";
            OleDbConnection conn = new OleDbConnection(sqlcon);//创建command对象，指定要执行sql语句与连接对象conn
            OleDbCommand cmd = new OleDbCommand(comStr, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 修改密码

        /// <summary>
        /// 修改密码
        /// </summary>
        public static bool ChangePassword(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            string comStr = @"Update login set 密码='" + User.UserPwd + "'";
            comStr += " where 用户名='" + User.UserName + "'";
            OleDbConnection conn = new OleDbConnection(sqlcon);//创建command对象，指定要执行sql语句与连接对象conn
            OleDbCommand cmd = new OleDbCommand(comStr, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 注销用户

        /// <summary>
        /// 注销用户
        /// </summary>
        public static bool CLUser(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            string comStr = @"Delete from login where 用户名='" + User.UserName + "'";
            OleDbConnection conn = new OleDbConnection(sqlcon);//创建command对象，指定要执行sql语句与连接对象conn
            OleDbCommand cmd = new OleDbCommand(comStr, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 管理员登录验证
        /// <summary>
        /// 管理员登录验证
        /// </summary>
        public static bool CheckAdmin(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();
            string stName = User.UserName;
            string stPassword = User.UserName;
            string sql = @"Select * from login where 管理员='1'";//用于查询管理员
            OleDbCommand cmdFindname = new OleDbCommand(sql, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();

            bool result = false;
            while (dr.Read()) //开始读取数据
            {
                if (User.UserName == dr["用户名"].ToString() && User.UserPwd == dr["密码"].ToString())
                {
                    result = true;
                }
            }
            mycon.Close();
            return result;
        }
        #endregion

        #region 修改用户信息

        /// <summary>
        /// 修改用户信息
        /// </summary>
        public static bool ChangeInfo(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            string comStr = @"Update login set 密码='" + User.UserPwd + "'," + "真实姓名='" + User.RealName + "'," + "证件类型='" + User.IDType + "',"
                + "证件号码='" + User.ID + "'," + "省份='" + User.Province + "'," + "城市='" + User.City + "'," + "管理员='" + User.Admin + "'";
            comStr += " where 用户名='" + User.UserName + "'";
            OleDbConnection conn = new OleDbConnection(sqlcon);//创建command对象，指定要执行sql语句与连接对象conn
            OleDbCommand cmd = new OleDbCommand(comStr, conn);
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 按用户名查询用户信息
        /// <summary>
        /// 按用户名查询用户信息
        /// </summary>
        public static string UserInfo(UserModel User)//返回一个string，按顺序存储用户的所有信息，用空格隔开
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();
            string sql = @"Select * from login where (用户名='" + User.UserName + "')";//准备查询语句
            OleDbCommand cmdFindname = new OleDbCommand(sql, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();
            string Info = "";//定义string，按顺序存储用户的所有信息，用空格隔开
            while (dr.Read()) //开始读取数据
            {
                Info = dr["用户名"].ToString() + " "
                    + dr["密码"].ToString() + " "
                    + dr["真实姓名"].ToString() + " "
                    + dr["证件类型"].ToString() + " "
                    + dr["证件号码"].ToString() + " "
                    + dr["省份"].ToString() + " "
                    + dr["城市"].ToString() + " "
                    + dr["管理员"].ToString();
            }
            mycon.Close();
            return Info;
        }
        #endregion

        #region 加载所有用户的信息

        /// <summary>
        /// 加载所有用户的信息
        /// </summary>
        public static List<UserModel> UserList()
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();//打开数据库
            string comStr = "select * from login";//准备查询语句
            OleDbCommand cmdFindname = new OleDbCommand(comStr, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();

            List<UserModel> userList = new List<UserModel>();//准备一个List<UserModel>类型的集合来装dr中的数据

            while (dr.Read()) //开始读取数据
            {
                userList.Add(new UserModel()
                    {
                        UserName = dr["用户名"].ToString(),
                        UserPwd = dr["密码"].ToString(),
                        RealName = dr["真实姓名"].ToString(),
                        IDType = dr["证件类型"].ToString(),
                        ID = dr["证件号码"].ToString(),
                        Province = dr["省份"].ToString(),
                        City = dr["城市"].ToString(),
                        Admin = dr["管理员"].ToString(),
                    });
            }
            mycon.Close();
            return userList;
        }
        #endregion

        //#region 在DATaGridView中修改用户信息

        ///// <summary>
        ///// 在DATaGridView中修改用户信息
        ///// </summary>
        //public static bool UpdateInfo()
        //{
        //    string conn = DbUtil.connString; //定义连接字符串
        //    OleDbConnection mycon = new OleDbConnection(conn);//创建OleDbConnection对象，建立数据库连接
        //    mycon.Open();//打开数据库
        //    string sql = "select * from login";//准备查询语句
        //    OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
        //    DataSet ds = new DataSet();
        //    DataSet myDataSet = new DataSet();
        //    da.Fill(ds, "用户表");
        //    ds.Tables["用户表"].PrimaryKey = new DataColumn[] { ds.Tables["用户表"].Columns["用户名"] };
        //    OleDbCommandBuilder cmdBuild = new OleDbCommandBuilder(da);
        //    da.InsertCommand = cmdBuild.GetInsertCommand();
        //    da.DeleteCommand = cmdBuild.GetDeleteCommand();
        //    da.UpdateCommand = cmdBuild.GetUpdateCommand();
        //    bool result = false;
        //    return result;
        //}
        //#endregion
    }
}
