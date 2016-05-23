using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

namespace 方法的注入
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            Console.WriteLine("查询方法");
            ObjectFactory factory = (ObjectFactory)ctx.GetObject("objectFactory");
            factory.CreatePersonDao().Save();
            Console.WriteLine();

            Console.WriteLine("替换方法");
            UserDao dao = (UserDao)ctx.GetObject("userDao");
            Console.WriteLine(dao.GetValue("Liu Dong"));
            Console.WriteLine();

            Console.WriteLine("事件注册");
            Door door = (Door)ctx.GetObject("door");
            door.OnOpen("Opening!");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
