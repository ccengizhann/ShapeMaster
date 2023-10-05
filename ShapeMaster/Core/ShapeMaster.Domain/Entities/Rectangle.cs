using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Rectangle:Shape
    {
        public double ASide { get; set; }
        public double BSide { get; set; }

        public Rectangle()
        {
            Type = "Rectangle";
        }
        public override double GetArea()
        {
            return ASide * BSide;
        }

        public override double GetPerimeter()
        {
          return 2*(ASide+BSide);
        }
    }
}
