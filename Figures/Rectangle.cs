using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Figures
{
    public class Rectangle : GeometricFigure
    {
        public Rectangle(double Width, double Length)
        {
            _width = Width;
            _length = Length;
        }

        private double _width;
        private double _length;

        /// <summary>
        /// Площадь квадрата
        /// </summary>
        /// <returns></returns>

        public override double SquareCalculator()
        {
            return _width * _length;
        }
    }
}
