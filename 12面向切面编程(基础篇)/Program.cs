using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop.Framework;
using Spring.Context;
using Spring.Context.Support;

namespace 面向切面编程
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 
            ICompanyManager target = new SimpleCompanyManager() { Dao = new CompanyDao(), UserName = "admin1" };
            target.Save();

            //2 
            IApplicationContext ctx = ContextRegistry.GetContext();
            ICompanyManager target2 = ctx.GetObject("simpleCompanyManager") as ICompanyManager;
            if (target2 != null)
            {
                target2.Save();
            }

            //3 代理模式解耦
            ICompanyManager target3 = new CompanyProxyManager() {  UserName = "admin" };
            target3.Save();

            //4 Spring.NET提供的AOP：AopAlliance.Intercept.IMethodInterceptor接口和ProxyFactory类的组合。
            ProxyFactory factory = new ProxyFactory(target2);
            factory.AddAdvice(new AroundAdvice());

            ICompanyManager manager = (ICompanyManager)factory.GetProxy();
            manager.Save();

            Console.ReadLine();
        }
    }
}
