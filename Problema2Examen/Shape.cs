using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2Examen
{
    public abstract class Shape
    {
        public abstract Punct[] Points { get; set; }
        public abstract double Area { get; set; }

        public abstract void Move(double dx, double dy);
        public abstract void Rotate(int theta);
        
    }
}
