﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制反转
{
    class DataAccess
    {
        public static IPerson CreatePersonDao()
        {
            return new Person();
        }
    }
}
