using System;
using System.Collections.Generic;
using System.Text;
using ClasseAbstrata.Entities.Enums;

namespace ClasseAbstrata.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
