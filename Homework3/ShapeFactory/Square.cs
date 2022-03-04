using System;

namespace ShapeFactory
{
    class Square : Shape
    {
        public double Edge { get; }

        public Square(double edge)
        {
            Edge = edge;
        }

        public override String Type { get => "Square"; }

        public override double Area
        {
            get
            {
                if (!IsValid())
                    throw new ArgumentException("Invalid edge.");
                return Edge * Edge;
            }
        }

        public override bool IsValid()
        {
            return Edge >= 0;
        }
    }
}
