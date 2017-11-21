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
                throw new ArgumentException(nameof(d));
            this.numerator = n;
            this.denumerator = d;

            //Sign
            if (this.numerator < 0 && this.denumerator < 0)
            {
                this.numerator = -numerator;
                this.denumerator = -denumerator;
            }

            //Normal Form
            for (int i = Math.Abs(this.numerator * this.denumerator); i > 1; i--)
            {
                if ((this.numerator % i == 0) && (this.denumerator % i == 0))
                {
                    this.numerator /= i;
                    this.denumerator /= i;
                }
            }

        }
        
        static void Main(string[] args)
        {
        }
    }
}
