﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 依赖注入
{
    class Computer : ITool
    {
        public void UseTool()
        {
            Console.WriteLine("使用电脑");
        }
    }
}
