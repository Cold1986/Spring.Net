using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向切面编程
{
    public class CompanyManager : ICompanyManager
    {
        #region 可通过外部注入的属性

        public string UserName { get; set; }

        public CompanyDao Dao { get; set; }

        #endregion

        public void Save()
        {
            //执行业务方法
            //.......
            //调用DAO层方法
            Dao.Save();
        }
    }
}
