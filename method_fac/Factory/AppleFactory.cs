using FactoryMethod.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public class AppleFactory : FruitFactory
    {
        public override Fruit createFruit()
        {
            return new Apple();
        }
    }
}
