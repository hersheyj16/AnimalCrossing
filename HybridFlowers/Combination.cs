using System;
using System.Collections.Generic;

namespace AnimalCrossingAlgorithm
{
    public class Combination
    {
        public Type type;
        public Colour ParentColour1;
        public Colour ParentColour2;

        public Colour Colour;

        public Combination(Type type, Colour f1, Colour f2, Colour color)
        {
            this.type = type;
            this.ParentColour1 = f1;
            this.ParentColour2 = f2;

            this.Colour = color;

        }

        public override string ToString()
        {
            return $"{type} of {ParentColour1} + {ParentColour2} produces: {this.Colour}";
        }

    }
}