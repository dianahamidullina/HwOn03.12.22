using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tumakov11_12
{
    public class Rational
    {
        public int Top { get; set; }
        private int bottom;
        public int Bottom
        {
            get { return bottom; }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Нельзя делить на 0!");
                }
                else
                {
                    bottom = value;
                }
            }
        }

        public static explicit operator int(Rational r)
        {
            return r.Top / r.Bottom;
        }
        public static explicit operator double(Rational r)
        {
            return (double)r.Top / r.Bottom;
        }

    }
}
