﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.product
{
    public class Apple : Fruit
    {
        public override void get_name()
        {
            Console.WriteLine("我的名字叫苹果");
        }
    }
}
