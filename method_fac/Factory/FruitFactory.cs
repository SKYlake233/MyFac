using FactoryMethod.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factory
{
    public abstract class FruitFactory
    {
        public abstract Fruit createFruit();

    }
}
