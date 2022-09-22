using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceXAMPLE
{
    public class Animals
    {
        protected string Animaltype;
        protected double weight;
        protected string name;

        public Animals(string type, double weight, string name)
        {
            this.Animaltype = type;
            this.weight = weight;
            this.name = name;
        }

        public Animals(string type)
        {
            this.weight=0;
            this.Animaltype = type;
            this.name=string.Empty;
        }

        public Animals()
        {
            this.weight = 0;
            this.Animaltype = string.Empty;
            this.name = string.Empty;
        }


        public double GetWeight()
        {
            return weight;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAnimalType()
        {
            return Animaltype;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetWeight(double weight)
        {
            if (weight >= 0)
                this.weight = weight;
        }

        public override string ToString()
        {
            return $"name:{name}, weight:{weight} of type: {Animaltype}";
        }

    }
}
