using ShapeMaster.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.Domain.Common
{
    public abstract class Shape:EntityBase<Guid>,ISaveableShape
    {
        public string Type { get; set; }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public string GetInfo()
        {
            return $"{Type} AREA: {GetArea()} PERIMETER: {GetPerimeter()}";
        }
    }
}
