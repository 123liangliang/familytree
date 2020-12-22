using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class CityBLL
    {
        #region 找出输入省份对应的城市列表

        /// <summary>
        /// 找出输入省份对应的城市列表
        /// </summary>
        public static string CityData(CityModel City)
        {
            return CityDAL.CityData(City);
        }
        #endregion
    }
}
