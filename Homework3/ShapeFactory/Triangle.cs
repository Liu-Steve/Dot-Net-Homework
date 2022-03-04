using System;

namespace ShapeFactory
{
    class Triangle : Shape
    {
        public double Edge1 { get; }
        public double Edge2 { get; }
        public double Edge3 { get; }

        public Triangle(double edge1, double edge2, double edge3)
        {
            Edge1 = edge1;
            Edge2 = edge2;
            Edge3 = edge3;
        }

        public override String Type { get => "Triangle"; }

        public override double Area
        {
            get
            {
                if (!IsValid())
                    throw new ArgumentException("Invalid edge.");
                //Helen formula
                double p = (Edge1 + Edge2 + Edge3) / 2.0;
                return Math.Sqrt(p * (p - Edge1) * (p - Edge2) * (p - Edge3));
            }
        }

        public override bool IsValid()
        {
            if (Edge1 <= 0 || Edge2 <= 0 || Edge3 <= 0)
                return false;
            double sum = Edge1 + Edge2 + Edge3;
            double maxEdge = Math.Max(Edge1, Edge2);
            maxEdge = Math.Max(maxEdge, Edge3);
            if (sum - maxEdge <= maxEdge)
                return false;
            return true;
        }
    }
}
