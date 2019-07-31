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

        public override double SquareCalculator()
        {
            return _width * _length;
        }
    }
}
