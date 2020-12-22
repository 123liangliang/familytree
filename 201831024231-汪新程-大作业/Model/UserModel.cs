using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 实体类，用于保存用户信息
    /// </summary>
    public class UserModel
    {
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string RealName { get; set; }
        public string IDType { get; set; }
        public string ID { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string App { get; set; }
        public string Admin { get; set; }

    }
}
