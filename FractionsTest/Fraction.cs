using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsTest
{
    public class Fraction

    {

        public int numerator { get; }
        public int denumerator { get; }

        public Fraction(int n, int d)
        {
            if (d == 0)
                throw new ArgumentNullException(nameof(d));
            this.numerator = n;
            this.denumerator = d;
        }

        static void Main(string[] args)
        {
        }
    }
}
