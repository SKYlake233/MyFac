using AbstractFactory.product.Juice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class BananaJuiceFactory : JuiceFactory
    {
        public override Juice createJucie()
        {
            return new BananaJuice();
        }
    }
}
