using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的注入
{
    //先定义一个委托
    public delegate string OpenHandler(string arg);

    public class Door
    {
        public event OpenHandler OpenTheDoor;

        public void OnOpen(string arg)
        {
            //调用事件
            if (OpenTheDoor != null)
            {
                Console.WriteLine(OpenTheDoor(arg));
            }
        }
    }
}
