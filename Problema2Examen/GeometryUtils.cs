using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2Examen
{
    public static class GeometryUtils
    {
        public static double GetArea(Triunghi triunghi)
        {
            return triunghi.Area;
        }
        public static double GetArea(Dreptunghi dreptunghi)
        {
            return dreptunghi.Area;
        }
        public static double GetArea(Patrat patrat)
        {
            return patrat.Area;
        }

        public static void Move(double dx, double dy, Triunghi triunghi)
        {
            triunghi.Move(dx, dy);
        }
        public static void Move(double dx, double dy, Dreptunghi dreptunghi)
        {
            dreptunghi.Move(dx, dy);
        }

        public static void Move(double dx, double dy, Patrat patrat)
        {
            patrat.Move(dx, dy);
        }

        public static void Rotate(int x, Triunghi triunghi)
        {
            triunghi.Rotate(x);
        }
    }
}
