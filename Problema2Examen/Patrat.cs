using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2Examen
{
    public class Patrat:Shape
    {
        public Patrat(Punct A, double l)
        {
            this.A = A;
            this.B.X = this.A.X + l;
            this.B.Y = this.A.Y;
            this.C.X = this.A.X + l;
            this.C.X = this.A.X + l;
            this.D.X = this.A.X;
            this.D.X = this.A.X + l;
        }

        public Punct A { get; set; }
        public Punct B { get; set; } = new Punct(0, 0);
        public Punct C { get; set; } = new Punct(0, 0);
        public Punct D { get; set; } = new Punct(0, 0);

        public double i { get; set; }

        public override Punct[] Points { get; set; }

        public override double Area { get; set; }

        public override void Move(double dx, double dy)
        {
            A.Move(dx, dy);
            B.Move(dx, dy);
            C.Move(dx, dy);
            D.Move(dx, dy);
        }

        public override void Rotate(int theta)
        {
            A.Rotate(theta);
            B.Rotate(theta);
            C.Rotate(theta);
            D.Rotate(theta);
        }
    }
}
