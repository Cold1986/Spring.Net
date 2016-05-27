using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向切面编程
{
    public class SimpleCompanyManager : ICompanyManager
    {
        public string UserName
        {
            get;
            set;
        }
        public CompanyDao Dao { get; set; }

        public void Save()
        {
            //判断权限
            ISecurityManager security = new SecurityManager();
            if (security.IsPass(UserName))
            {
                //执行业务方法
                //.......
                //调用DAO层方法
                Dao.Save();
            }
            else
            {
                //执行其它业务方法...
                Console.WriteLine("您没有该权限");
            }
        }
    }
}
