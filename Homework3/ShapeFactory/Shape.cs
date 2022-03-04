using System;

namespace ShapeFactory
{
    abstract class Shape
    {
        public abstract String Type { get; }
        public abstract bool IsValid();
        public abstract double Area { get; }
    }
}
