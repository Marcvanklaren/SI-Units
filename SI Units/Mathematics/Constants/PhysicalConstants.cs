using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Physics.Mathematics.Constants
{
    public class PhysicalConstants
    {
        public static Constant c = new Constant(299792458, 0);

        public static Constant G = new Constant((decimal)6.674, -11);
    }
}
