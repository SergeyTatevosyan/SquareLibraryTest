using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Figures
{
    public class Rhombus: GeometricFigure
    {
        public Rhombus(double Height, double Length)
        {
            _height = Height;
            _length = Length;
        }
        
        /// <summary>
        /// Высота ромба
        /// </summary>
        private double _height;
        /// <summary>
        /// длина стороны ромба
        /// </summary>
        private double _length;

        public override double SquareCalculator()
        {
            return _length * _height;
        }
    }
}
