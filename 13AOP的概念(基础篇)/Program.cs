using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop.Framework;

namespace AOP的概念
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory(new OrderService() { UserName = "admin" });

            factory.AddAdvice(new AroundAdvise());
            IOrderService service = (IOrderService)factory.GetProxy();
            object result = service.Save(21);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
