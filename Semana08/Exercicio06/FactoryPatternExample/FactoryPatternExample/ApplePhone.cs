using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class ApplePhone: IMobile
    {
        public string GetCPU()
        {
            return "Apple A15 Bionic";
        }
        public string GetRAM()
        {
            return "8GB";
        }
    }

}
