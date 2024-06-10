using System;

namespace FiguresWF
{
    internal class Circle : Figure
    {
        public double Radius { get; set; }
        int mode = 0;
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
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double Perimetr { get { return 2 * Math.PI * Radius; } }
        public override string ToString()
        {
            if (mode==0)
            {
                return string.Format("Окружность (PI*r^2 = PIx{0}^2)", Radius);
            }
            if (mode == 1)
            {
                return string.Format("Окружность (2*PI*r = 2*PI*{0})", Radius);
            }
            return string.Format("Ошибка");

        }

    }

}
