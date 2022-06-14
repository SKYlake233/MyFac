using AbstractFactory.product.Fruit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class AppleFactory : FruitFactory
    {
        public override Fruit createFruit()
        {
            return new Apple();
        }
    }
}
