using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.FactoryMethod.Solution.Abstractions
{
    public abstract class Vehicle
    {
        protected List<Part> Parts { get; set; }

        protected Vehicle()
        {
            Parts = new List<Part>();
        }        

        public string Print()
        {
            return string.Join(",", Parts.Select( p => p.Name));
        }

    }
}
