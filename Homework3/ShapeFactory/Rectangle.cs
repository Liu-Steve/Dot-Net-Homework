using System;

namespace ShapeFactory
{
    class Rectangle : Shape
    {
        public double Width { get; }
        public double Length { get; }
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override String Type { get => "Rectangle"; }

        public override double Area
        {
            get
            {
                if (!IsValid())
                    throw new ArgumentException("Invalid width or length.");
                return Width * Length;
            }
        }

        public override bool IsValid()
        {
            return (Width >= 0 && Length >= 0);
        }
    }
}
