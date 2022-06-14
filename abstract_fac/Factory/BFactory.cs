using AbstractFactory.product.Fruit;
using AbstractFactory.product.Juice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class BFactory : Factory
    {
        public override Fruit createFruit()
        {
            return new Banana();
        }

        public override Juice createJuice()
        {
            return new BananaJuice();
        }
    }
}
