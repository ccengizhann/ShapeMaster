using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapeMaster.Domain.Entities
{
    public class Triangle:Shape
    {
        public double TSide { get; set; }
        public double Fside { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle()
        {
            Type = "Triangle";
        }
        public override double GetArea()
        {
            return (Base * Height) / 2;
        }

        public override double GetPerimeter()
        {
            return TSide + Fside + Base;
        }
    }
}
