using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class SamsungPhone: IMobile
    {
        public string GetCPU()
        {
            return "Exynos 2100";
        }
        public string GetRAM()
        {
            return "12GB";
        }
    }

}
