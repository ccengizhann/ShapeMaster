using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Type = "Circle";
        }

        public override double GetArea()
        {
           return Math.PI*Math.Pow(Radius, 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI*Radius*2;
        }
    }
}
