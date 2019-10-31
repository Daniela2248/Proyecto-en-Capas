using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Proceso
    {
        public double d1, d2, d3;
        public void prosuma()
        {
            d3 = d1 + d2;
        }
        public void proresta()
        {
            d3 = d1 - d2;
        }
        public void promult()
        {
            d3 = d1 * d2;
        }
        public void prodiv()
        {
            d3 = d1 / d2;
        }
    }
}
