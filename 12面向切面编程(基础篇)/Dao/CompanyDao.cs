using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向切面编程
{
    public class CompanyDao
    {
        public void Save()
        {
            Console.WriteLine("保存数据");
        }
    }
}
