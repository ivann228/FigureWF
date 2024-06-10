using System;

namespace FiguresWF
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }
        public int mode = 0;
        public Circle()
        {
            Radius = 0;
        }
        public Circle(double rad)
        {
            Radius = rad;
        }
        public override double Square()
        {
            mode = 0;
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimetr {  get { return 2 * Math.PI * Radius; } }
        public override string ToString()
        {
           return string.Format("Окружность (R = {0})", Radius);
        }

    }

}
