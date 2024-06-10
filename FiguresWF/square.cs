using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresWF
{
    //квадрат
    internal class square : Figure
    {
        public double Length { get; set; }
        int mood = 0;
        public square()
        {
            Length  = 0;
        }

        public square(double length)
        {
            Length = length;
        }

        public override double Square()
        {
            mood = 1;
            return Length * Length;
        }
        public override double Perimetr
        {
            get { return 4 * Length;  }
        }
        public override string ToString()
        {
            return string.Format("Квадрат (Д = {0})", Length);
        }



    }
}
