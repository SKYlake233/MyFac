using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.product.Fruit
{
    public class Banana : Fruit
    {
        public override void get_name()
        {
            Console.WriteLine("我的名字叫香蕉");
        }
    }
}
