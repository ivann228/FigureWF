using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    //треугольник
    internal class triangle : Figure
    {
        public double r1 { get; set; }
        public double r2 { get; set; }
        public double r3 { get; set; }
        public double Height { get; set; }

        public triangle()
        {
            r1 = r2 = r3 = Height = 0;
        }

        public triangle(double a, double b, double c, double h)
        {
            r1 = a;
            r2 = b;
            r3 = c;
            Height = h;
        }

        public override double Square()
        {
            return r1 * Height / 2;
        }
        public override double Perimetr
        {
            get { return r1 + r2 + r3; }
        }
        public override string ToString()
        {
            return string.Format("Трапеция (AxBxC = {0}х{1}x{2}, h = {4})", r1, r2, r3, Height);
        }
    }
}
