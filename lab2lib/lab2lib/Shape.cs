using System;
using System.Numerics;

namespace lab2lib
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        public static Shape GenerateShape()
        {
            Random random = new Random();
            int r = random.Next(0, 4);

            switch (r)
            {
                case 0:
                    return new Circle(GetRandomVector(), GetRandomNumber(0, 100));
                case 1:
                    return new Rectangle(GetRandomVector(), GetRandomVector());
                case 2:
                    return new Triangle(GetRandomVector(), GetRandomVector(), GetRandomVector());
                case 3:
                    return new Cuboid(GetRandomVector3(), GetRandomVector3());
                case 4:
                    return new Sphere(GetRandomVector3(), GetRandomNumber(0, 100));
                default:
                    return null;
            }
        }

        public static Vector2 GetRandomVector()
        {
            return new Vector2(GetRandomNumber(0, 100), GetRandomNumber(0, 100));
        }

        public static Vector3 GetRandomVector3()
        {
            return new Vector3(GetRandomNumber(0, 100), GetRandomNumber(0, 100), GetRandomNumber(0, 100));
        }

        public static float GetRandomNumber(float minimum, float maximum)
        {
            Random random = new Random();
            return (float)random.NextDouble() * (maximum - minimum) + minimum;
        }
    }
}
