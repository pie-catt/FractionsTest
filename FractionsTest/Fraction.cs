using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionsTest
{
    public class Fraction

    {
        public int Numerator { get; }
        public int Denominator { get; }

        public Fraction(int n, int d = 1)
        {

            //Denumerator not = 0
            if (d == 0)
                throw new ArgumentException(nameof(d));

            this.Numerator = n;
            this.Denominator = d;

            //Sign
            if (this.Denominator < 0)
            {
                    this.Numerator = -Numerator;
                    this.Denominator = -Denominator;
            }
           
            //Normal Form
            for (int i = Math.Abs(this.Numerator * this.Denominator); i > 1; i--)
            {
                if ((this.Numerator % i == 0) && (this.Denominator % i == 0))
                {
                    this.Numerator /= i;
                    this.Denominator /= i;
                }
            }
        }

        //Overload + operator
        public static Fraction operator+ (Fraction f1, Fraction f2)
        {
            int newNumerator = ((f1.Numerator * f2.Denominator) +
                                 (f2.Numerator * f1.Denominator));
                               
            int newDenominator = (f1.Denominator * f2.Denominator);

            return new Fraction(newNumerator, newDenominator);
        }

        //Overload * operator
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);
        }

        //Overload - operator
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int newNumerator = ((f1.Numerator * f2.Denominator) -
                                 (f2.Numerator * f1.Denominator));

            int newDenominator = (f1.Denominator * f2.Denominator);

            return new Fraction(newNumerator, newDenominator);
        }

        //Overload / operator
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator);
        }

        //Override ToString
        public override string ToString()
        {
            if(this.Denominator != 1)
            return this.Numerator + "/" + this.Denominator;
            return this.Numerator.ToString();
        }

        //Override Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() == typeof(Fraction))
            {
                Fraction other = (Fraction) obj;
                return this.Numerator == other.Numerator && this.Denominator == other.Denominator
                       && this.Denominator == other.Denominator;
            }
            return false;
        }


        static void Main(string[] args)
        {
        }
    }
}
