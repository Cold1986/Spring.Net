using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Aop.Framework;

namespace AOP的通知类型
{
    class Program
    {
        static void Main(string[] args)
        {
            ProxyFactory factory = new ProxyFactory(new OrderService());

            factory.AddAdvice(new AroundAdvise());
            factory.AddAdvice(new BeforeAdvise());
            factory.AddAdvice(new AfterReturningAdvise());
            factory.AddAdvice(new ThrowsAdvise());

            IOrderService service = (IOrderService)factory.GetProxy();

            object result = service.Save(1);

            Console.WriteLine();
            Console.WriteLine(string.Format("客户端返回值：{0}", result));

            Console.ReadLine();
        }
    }
}
