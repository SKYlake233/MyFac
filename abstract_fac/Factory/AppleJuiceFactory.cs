using AbstractFactory.product.Juice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class AppleJuiceFactory : JuiceFactory
    {
        public override Juice createJucie()
        {
            return new AppleJuice();
        }
    }
}
