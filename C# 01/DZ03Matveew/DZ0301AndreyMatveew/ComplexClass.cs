using System;
using System.Collections.Generic;
using System.Text;

namespace DZ0301AndreyMatveew
{
    class ComplexClass
    {
        public double im;
        public double re;

        public ComplexClass(double validNum,double allegedNum)
        {
            im = allegedNum;
            re = validNum;
        }

        public ComplexClass Plus(ComplexClass x)
        {
            this.im = this.im + x.im;
            this.re = this.re + x.re;
            return this;
        }

        public ComplexClass Minus(ComplexClass x)
        {
            this.im = this.im - x.im;
            this.re = this.re - x.re;
            return this;
        }

        public ComplexClass Multi(ComplexClass x)
        {
            this.im = this.re * x.im + this.im * x.re;
            this.re = this.re * x.re - this.im * x.im;
            return this;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}
