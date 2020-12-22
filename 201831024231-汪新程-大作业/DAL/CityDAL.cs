using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Model;

namespace DAL
{
    public class CityDAL
    {
        #region 找出输入省份对应的城市列表

        /// <summary>
        /// 找出输入省份对应的城市列表
        /// </summary>
        public static string CityData(CityModel City)
        {
            string sqlcon = DbUtil.connString; //定义连接字符串
            OleDbConnection mycon = new OleDbConnection(sqlcon);//创建OleDbConnection对象，建立数据库连接
            mycon.Open();//打开数据库
            string comStr = @"select * from CityList where (省份='" + City.Province + "')";//准备查询语句
            OleDbCommand cmdFindname = new OleDbCommand(comStr, mycon);
            OleDbDataReader dr = cmdFindname.ExecuteReader();

            string cityData = "";//准备一个List<CityModel>类型的集合来装dr中的数据

            while (dr.Read()) //开始读取数据
            {
                cityData += dr["城市"] + " ";
            }
            mycon.Close();
            return cityData;
        }
        #endregion
    }
}
