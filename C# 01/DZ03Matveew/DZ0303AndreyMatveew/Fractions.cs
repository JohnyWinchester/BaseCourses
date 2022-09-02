using System;
using System.Collections.Generic;
using System.Text;

namespace DZ0303AndreyMatveew
{
    class Fractions
    {
        private int numerator, denominator;

        public int Numerator 
        {
            get { return numerator; }
            set { numerator = value; } 
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; } 
        }

        public double DecimalFraction 
        { 
            get 
            {
                return (double)numerator / (double)denominator;
            } 
        }

        public Fractions(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fractions Addition(Fractions fraction2)
        {
            Fractions fraction = new Fractions(0, 0);

            if (this.denominator != fraction2.denominator)
            {
                GenericDenominator(this, fraction2);
            }

            fraction.denominator = this.denominator;
            fraction.numerator = this.numerator + fraction2.numerator;
            return fraction;
        }

        public Fractions Substraction(Fractions fraction2)
        {
            Fractions fraction = new Fractions(0, 0);

            if (this.denominator != fraction2.denominator)
            {
                GenericDenominator(this, fraction2);
            }

            fraction.denominator = this.denominator;
            fraction.numerator = this.numerator - fraction2.numerator;
            return fraction;
        }

        public Fractions Multi(Fractions fraction2)
        {
            Fractions fraction = new Fractions(0, 0);

            fraction.denominator = this.denominator * fraction2.denominator;
            fraction.numerator = this.numerator * fraction2.numerator;
            return fraction;
        }

        public Fractions Division(Fractions fraction2)
        {
            Fractions fraction = new Fractions(0, 0);

            fraction.denominator = this.denominator * fraction2.numerator;
            fraction.numerator = this.numerator * fraction2.denominator;
            return fraction;
        }

        public (Fractions, Fractions) GenericDenominator(Fractions fraction1, Fractions fraction2)
        {
            int noc = 2;
            int numerator = fraction1.numerator;
            int denominator = fraction1.denominator;
            int numerator2 = fraction2.numerator;
            int denominator2 = fraction2.denominator;

            while (denominator != denominator2)
            {
                numerator = fraction1.numerator;
                denominator = fraction1.denominator;
                numerator *= noc;
                denominator *= noc;

                for (int i = 2; i <= 10; i++)
                {
                    numerator2 = fraction2.numerator;
                    denominator2 = fraction2.denominator;
                    numerator2 *= i;
                    denominator2 *= i;
                    if (denominator2 == denominator) break;
                }
                noc++;
            }

            fraction1.numerator = numerator;
            fraction1.denominator = denominator;
            fraction2.numerator = numerator2;
            fraction2.denominator = denominator2;

            return (fraction1, fraction2);
        }

        public override string ToString()
        {
            return $"{this.numerator}/{this.denominator}";
        }
    }
}
