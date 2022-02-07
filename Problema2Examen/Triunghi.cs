using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2Examen
{
    public class Triunghi : Shape
    {
        public Triunghi(Punct A, Punct B, Punct C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Punct A { get; set; }
        public Punct B { get; set; }
        public Punct C { get; set; }

        public override Punct[] Points { get; set; }

        public override double Area { get; set; }

        public override void Move(double dx, double dy)
        {
            A.Move(dx, dy);
            B.Move(dx, dy);
            C.Move(dx, dy);
        }

        public override void Rotate(int theta)
        {
            A.Rotate(theta);
            B.Rotate(theta);
            C.Rotate(theta);
        }
    }
}
