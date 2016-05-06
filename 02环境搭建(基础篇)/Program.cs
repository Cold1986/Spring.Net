using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
using Spring.Core.IO;
using Spring.Objects.Factory;
using Spring.Objects.Factory.Xml;

namespace 环境搭建
{
    class Program
    {
        static void Main(string[] args)
        {
            AppRegistry();
            XmlSystem();
            FileSystem();

            Console.ReadLine();
        }

        static void AppRegistry()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            Console.WriteLine(ctx.GetObject("Person").ToString());
        }

        static void XmlSystem()
        {
            //需要选中“Objects.xml”文件，再改变其“生成操作”属性为“生成嵌入的资源
            string[] xmlFiles = new string[] 
            {
                //"file://Objects.xml"  //, 文件名
                "assembly://02环境搭建(基础篇)/环境搭建/Objects.xml"  //assembly://程序集名/命名空名/文件名
            };
            IApplicationContext context = new XmlApplicationContext(xmlFiles);

            IObjectFactory factory = (IObjectFactory)context;
            Console.WriteLine(factory.GetObject("Person").ToString());
        }

        static void FileSystem()
        {
            //file://文件名
            IResource input = new FileSystemResource(System.IO.Path.GetFileName("Objects.xml"));  //实际物理路径
            IObjectFactory factory = new XmlObjectFactory(input);
            Console.WriteLine(factory.GetObject("Person").ToString());
        }
    }
}
