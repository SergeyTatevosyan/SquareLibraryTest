using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareLibrary.Figures
{
    
    public class Circle : GeometricFigure
    {
        public Circle(double Radius)
        {
            _radius = Radius;
        }

        private double _radius;

        /// <summary>
        /// Рассчитывает площадь окружности
        /// </summary>
        /// <returns></returns>
        public override double SquareCalculator()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
