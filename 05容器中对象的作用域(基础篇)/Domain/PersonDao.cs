using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 容器中对象的作用域
{
    public class PersonDao
    {
        public PersonDao()
        {
            Console.WriteLine("PersonDao被实例");
        }

        public override string ToString()
        {
            return "我是PersonDao";
        }
    }
}
