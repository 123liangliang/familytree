using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;


namespace DAL
{
    public class AppDAL
    {
        #region 添加应用

        /// <summary>
        /// 添加应用
        /// </summary>
        public static bool AddApp(UserModel User)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            string comStr = @"Insert into app(用户名,应用) values(";
            comStr += "'" + User.UserName + "','" + User.App + "')";
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

        #region 查看该用户名是否已拥有购物车里的一个及其以上的应用
        /// <summary>
        /// 查看该用户名是否已拥有购物车里的一个及其以上的应用
        /// </summary>
        public static string UserHaveApp(UserModel User)//返回一个string，这样就可以分别判断该用户是否拥有应用或者拥有哪些应用
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();
            string sql = @"Select * from app where (用户名='" + User.UserName + "')";//用于查询用户的应用
            OleDbCommand cmdFindname = new OleDbCommand(sql, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();
            string have = "";
            while (dr.Read()) //开始读取数据
            {
                if (dr["应用"].ToString() == "ADO.NET")
                {
                    have += "ADO.NET" + " ";
                }
                else if (dr["应用"].ToString() == "RTF")
                {
                    have += "RTF" + " ";
                }
                else if (dr["应用"].ToString() == "TypingGame")
                {
                    have += "TypingGame" + " ";
                }
                else if (dr["应用"].ToString() == "Kidding")
                {
                    have += "Kidding" + " ";
                }
            }
            mycon.Close();
            return have;
        }
        #endregion
    }
}
