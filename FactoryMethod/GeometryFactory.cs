using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareLibrary.Figures;

namespace SquareLibrary.FactoryMethod
{
    public static class GeometryFactory
    {
        public enum FigureType { Circle, Triangle, Rectangle };

        /// <summary>
        /// Фабричный метод
        /// </summary>
        /// <returns></returns>
        public static GeometricFigure Create(FigureType figureType)
        {
            switch (figureType)
            {
                case FigureType.Circle: return new Circle(2);
                case FigureType.Triangle: return new Triangle(3,4,5);
                case FigureType.Rectangle: return new Rectangle(4, 5);
            }
            return null;
        }
    }
}
