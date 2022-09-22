using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    public class OhadEyal:Mammals
    {
        protected double height;
        protected double hairLength;
        protected double mustacheLength;
        protected double beardLength;
        protected double temperature;
        protected bool hasBlanket;

        public OhadEyal(double height, double hairLength, double mustacheLength, double beardLength, double temperature, bool hasBlanket, double milk, string type, double weight, string name):base(milk, type, weight, name)
        {
            this.height = height;
            this.hairLength = hairLength;
            this.mustacheLength = mustacheLength;
            this.beardLength = beardLength;
            this.temperature = temperature;
            this.hasBlanket = hasBlanket;
        }

        public void cutHair()
        {
            mustacheLength = 0;
            beardLength = 0;
            hairLength = 0;
        }
        public void masturbate()
        {
            this.milk = 0;
        }
        public void SetTemperature(double temp)
        {
            this.temperature = temp;
            this.hasBlanket = this.temperature < 30;          
        }
    }
}
