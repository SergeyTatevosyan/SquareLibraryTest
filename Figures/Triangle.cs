using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Figures
{
    public class Triangle : GeometricFigure
    {
        public Triangle(double A, double B, double C)
        {
            _a = A;
            _b = B;
            _c = C;
        }

        private double _a;
        private double _b;
        private double _c;

        /// <summary>
        /// Рассчитывает периметр треугольника
        /// </summary>
        /// <returns></returns>
        private double Perimeter()
        {
            return 0.5 * (_a + _b + _c);
        }

        /// <summary>
        /// Рассчитывает площадь треугольника
        /// </summary>
        /// <returns></returns>
        public override double SquareCalculator()
        {
            double p = Perimeter();
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}
