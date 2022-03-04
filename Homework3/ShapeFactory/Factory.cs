using System;

namespace ShapeFactory
{
    class Factory
    {
        public static Shape Manufacture()
        {
            var rand = new Random();
            int type = rand.Next(3);
            switch (type)
            {
                //build rectangle
                case 0:
                    double w = rand.Next(1000) / 10.0;
                    double l = rand.Next(1000) / 10.0;
                    return new Rectangle(w, l);

                //build square
                case 1:
                    double e = rand.Next(1000) / 10.0;
                    return new Square(e);

                //build triangle
                case 2:
                    double e1 = rand.Next(1000) / 10.0;
                    double e2 = rand.Next(1000) / 10.0;
                    double e3 = rand.Next(1000) / 10.0;
                    return new Triangle(e1, e2, e3);

                default:
                    throw new ArgumentException("Unexpected shape");
            }
        }
    }
}
