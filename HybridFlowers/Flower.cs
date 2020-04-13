using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCrossingAlgorithm
{
    public class Flower
    {
        public Type Type { get; set; }
        public Colour Colour { get; set; }
        public IDictionary<String,Flower> ChildrenDictionary { get; set; }

        public Flower(Type Type, Colour color)
        {
            this.Type = Type;
            this.Colour = color;
            this.ChildrenDictionary = new Dictionary<String,Flower>();
        }

        public override string ToString()
        {
            if (this.ChildrenDictionary.Count == 0)
            {
                return $"{this.Colour} {this.Type}";
            }

            StringBuilder children = new StringBuilder();
            foreach (var item in this.ChildrenDictionary)
            {
                children.Append($"    With {item.Key}, {item.Value.Colour} \n");
            }

            return $"{this.Colour} {this.Type}, can produce these offsprings: \n" + children.ToString();
        }
    }
}