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

            //Normal Form
            for (int i = Math.Abs(this.numerator * this.denumerator); i > 1; i--)
            {
                if ((this.numerator % i == 0) && (this.denumerator % i == 0))
                {
                    this.numerator /= i;
                    this.denumerator /= i;
                }
            }

            //Sign
            if (this.denumerator < 0)
            {
                if (this.numerator < 0)
                {
                    this.numerator = -numerator;
                    this.denumerator = -denumerator;
                }
                else
                {
                    this.numerator = -numerator;
                    this.denumerator = -denumerator;
                }
            }
        }

        public static Fraction operator+ (Fraction f1, Fraction f2)
        {
            int _newNominator = ((f1.numerator * f2.denumerator) +
                                 (f2.numerator * f1.denumerator));
                               
            int _newDenominator = (f1.denumerator * f2.denumerator);

            return new Fraction(_newNominator, _newDenominator);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {

         return new Fraction(f1.numerator * f2.numerator, f1.denumerator * f2.denumerator);
            
        }
        

        static void Main(string[] args)
        {
        }
    }
}
