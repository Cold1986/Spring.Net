﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.Context;
using Spring.Context.Support;

namespace AOP的配置
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IDictionary speakerDictionary = ctx.GetObjectsOfType(typeof(IService));

            foreach (DictionaryEntry entry in speakerDictionary)
            {
                string name = (string)entry.Key;
                IService service = (IService)entry.Value;
                Console.WriteLine(name + "拦截：");

                service.FindAll();
                Console.WriteLine();
                service.Save("数据");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
