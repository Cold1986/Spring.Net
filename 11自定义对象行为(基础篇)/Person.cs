using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 自定义对象行为
{
    public class Person
    {
        public void Init()
        {
            Console.WriteLine("我长大了");
        }

        public void Destroy()
        {
            Console.WriteLine("我衰老了");
        }
    }
}
