using AbstractFactory.product.Fruit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    abstract public class FruitFactory
    {
        public abstract Fruit createFruit();
    }
}
