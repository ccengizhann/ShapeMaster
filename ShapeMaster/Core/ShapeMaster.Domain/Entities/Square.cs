using ShapeMaster.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Entities
{
    public class Square:Shape
    {
        public double OneSide { get; set; }

        public Square()
        {
            Type = "Square";
        }
        public override double GetArea()
        {
            return Math.Pow(OneSide, 2); 
        }

        public override double GetPerimeter()
        {
            return 4 * OneSide;
        }
    }
}
