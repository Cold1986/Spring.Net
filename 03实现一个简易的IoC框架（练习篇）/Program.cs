using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实现一个简易的IoC框架
{
    class Program
    {
        static void Main(string[] args)
        {
            AppRegistry();
            Console.ReadLine();
        }

        static void AppRegistry()
        {
            MyXmlFactory ctx = new MyXmlFactory(System.IO.Path.GetFileName("Objects.xml"));
            Console.WriteLine(ctx.GetObject("Person").ToString());
        }
    }
}
