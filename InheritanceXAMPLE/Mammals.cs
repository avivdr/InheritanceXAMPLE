using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    public class Mammals:Animals
    {
        protected double milk;

        public Mammals(double milk, string type, double weight, string name):base(type, weight, name)
        {
            this.milk = milk;
        }
        public Mammals(double milk)
        {
            this.milk = milk;
        }   

        public Mammals()
        {
            milk = 0;
        }

    }
}
