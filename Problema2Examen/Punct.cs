using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2Examen
{
    public class Punct
    {
        public Punct(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public double X { get; set; }
        public double Y { get; set; }

        public void Move(double dx, double dy)
        {
            this.X = this.X + dx;
            this.Y = this.Y + dy;
        }

        public void Rotate(int theta)
        {
            this.X = this.X * Math.Cos(theta) - Y * Math.Sin(theta);
            this.Y = this.X * Math.Sin(theta) + Y * Math.Cos(theta);
        }
    }
}
