using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制反转
{
    class Person : IPerson
    {
        public void Save()
        {
            Console.WriteLine("保存 Person");
        }
    }
}
