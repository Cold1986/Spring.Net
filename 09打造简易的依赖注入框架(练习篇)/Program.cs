using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 打造简易的依赖注入框架
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlFile = Directory.GetCurrentDirectory() + "\\Objects.xml";
            ObjectFactory factory = ObjectFactory.Instance(xmlFile);

            PersonDao dao = (PersonDao)factory.GetObject("personDao");

            Console.WriteLine("姓名：" + dao.Entity.Name);
            Console.WriteLine("年龄：" + dao.Entity.Age);
            var t = dao.ToString();
            Console.WriteLine(dao);

            Console.ReadLine();
        }
    }
}
