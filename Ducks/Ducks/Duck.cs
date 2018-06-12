using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ducks
{
    public class Duck : IEquatable<Duck>
    {
        public string Name { get; }
        public string Type { get; }
        public int WeightInGrams { get; }
        public int AgeInMonths { get; }

        public Duck(string name, string type, int weightInGrams, int ageInMonths)
        {
            Name = name;
            Type = type;
            WeightInGrams = weightInGrams;
            AgeInMonths = ageInMonths;
        }


        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Duck)obj);
        }

        public bool Equals(Duck other)
        {
            return WeightInGrams == other.WeightInGrams;
        }

        public override int GetHashCode()
        {
            return WeightInGrams;
        }

        public override string ToString()
        {
            return $"Duck weighing {WeightInGrams} grams";
        }
    }
}
