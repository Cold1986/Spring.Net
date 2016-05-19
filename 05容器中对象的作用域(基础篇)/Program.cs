using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;
using Spring.Objects.Factory;

namespace 容器中对象的作用域
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWithSingleton();
            CreateWithOutSingleton();
            CreateWithLazy();

            Console.ReadLine();
        }


        public static void CreateWithSingleton()
        {
            string[] xmlFiles = new string[] 
            {
                "assembly://05容器中对象的作用域(基础篇)/容器中对象的作用域/Objects.xml"
            };
            IApplicationContext context = new XmlApplicationContext(xmlFiles);

            IObjectFactory factory = (IObjectFactory)context;
            object obj1 = factory.GetObject("personDao");
            object obj2 = factory.GetObject("personDao");
            Console.WriteLine(obj1 == obj2);
        }

        public static void CreateWithOutSingleton()
        {
            string[] xmlFiles = new string[] 
            {
                "assembly://05容器中对象的作用域(基础篇)/容器中对象的作用域/Objects.xml"
            };
            IApplicationContext context = new XmlApplicationContext(xmlFiles);

            IObjectFactory factory = (IObjectFactory)context;
            object obj1 = factory.GetObject("person");
            object obj2 = factory.GetObject("person");
            Console.WriteLine(obj1 == obj2);
        }


        public static void CreateWithLazy()
        {
            string[] xmlFiles = new string[] 
            {
               "assembly://05容器中对象的作用域(基础篇)/容器中对象的作用域/Objects.xml"
            };
            IApplicationContext context = new XmlApplicationContext(xmlFiles);

            IObjectFactory factory = (IObjectFactory)context;

            object dao = factory.GetObject("personDao");
            Console.WriteLine(dao.ToString());

            object server = factory.GetObject("personServer");
            Console.WriteLine(server.ToString());
        }
    }
}
