using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    /// <summary>
    /// 房屋创建指导者
    /// </summary>
    public class HouseDirector
    {
        HouseBuilder houseBuilder;

        public HouseDirector(HouseBuilder houseBuilder)
        {
            this.houseBuilder = houseBuilder;
        }

        /// <summary>
        /// 变化中稳定的部分
        /// </summary>
        /// <returns>返回值</returns>
        public House init()
        {
                houseBuilder.BuildPart1();
                for (int i = 0; i < 4; i++)
                {
                houseBuilder.BuildPart2();
                }
            return houseBuilder.GetResult();
        }
    }
}
