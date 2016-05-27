using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向切面编程
{
    public class CompanyProxyManager : ICompanyManager
    {
        public string UserName { get; set; }

        private ICompanyManager target = new CompanyManager() { Dao = new CompanyDao() };

        public void Save()
        {
            //判断权限
            ISecurityManager security = new SecurityManager();
            if (security.IsPass(UserName))
            {
                //调用目标对象Save方法
                target.Save();
            }
            else
            {
                Console.WriteLine("您没有该权限");
            }
        }
    }
}
