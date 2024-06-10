using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    //Трапеция
    internal class trapezoid : Figure
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width1 { get; set; }
        public double Width2 { get; set; }
        public double Height { get; set; }

        public trapezoid()
        {
            Length1 = Width1 = Length2 = Width2 = Height = 0;
        }

        public trapezoid(double a, double b, double c, double d, double h)
        {
            Length1 = a;
            Width1 = b;
            Length2 = c;
            Width2 = d;
            Height = h;
        }

        public override double Square()
        {
            return (Length1 + Length2) * Height * 2;
        }
        public override double Perimetr
        {
            get { return Length1 + Width1 + Length2 + Width2; }
        }
        public override string ToString()
        {
            return string.Format("Трапеция (Д1хД2хШ1хШ2 = {0}х{1}x{2}x{3}, h = {4})",
                Length1, Length2, Width1, Width2, Height);
        }
    }

}