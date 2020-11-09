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
            int r = random.Next(1, 8);

            switch (r)
            {
                case 1:
                    return new Circle(new Vector2(random.Next(1, 100), random.Next(1, 100)), random.Next(1, 100));
                case 2:
                    return new Rectangle(new Vector2((random.Next(1, 100)), random.Next(1, 100)), new Vector2((random.Next(1, 100)), (random.Next(1, 100))));
                case 3:
                    return new Rectangle(new Vector2(random.Next(1, 100), random.Next(1, 100)), random.Next(1, 100));
                case 4:
                    return new Triangle(new Vector2(random.Next(1, 100), random.Next(1, 100)), new Vector2(random.Next(1, 100), random.Next(1, 100)), new Vector2(random.Next(1, 100), random.Next(1, 100)));
                case 5:
                    return new Cuboid(new Vector3(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)), new Vector3(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)));
                case 6:
                    return new Cuboid(new Vector3(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)), random.Next(1, 100));
                case 7:
                    return new Sphere(new Vector3(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)), random.Next(1, 100));
                default:
                    return null;
            }
        }
        public static Shape GenerateShape(Vector3 center)
        {
            Random random = new Random();
            int r = random.Next(1, 8);

            switch (r)
            {
                case 1:
                    return new Circle(new Vector2(center.X, center.Y), random.Next(1, 100));
                case 2:
                    return new Rectangle(new Vector2(center.X, center.Y), new Vector2(random.Next(1, 100), random.Next(1, 100)));
                case 3:
                    return new Rectangle(new Vector2(center.X, center.Y), random.Next(1, 100));
                case 4:
                    Vector2 p1 = new Vector2(random.Next(1, 100), random.Next(1, 100));
                    Vector2 p2 = new Vector2(random.Next(1, 100), random.Next(1, 100));
                    return new Triangle(p1, p2, new Vector2(center.X * 3 - p1.X - p2.X, center.Y * 3 - p1.Y - p2.Y));
                case 5:
                    return new Cuboid(center, new Vector3(random.Next(1, 100), random.Next(1, 100), random.Next(1, 100)));
                case 6:
                    return new Cuboid(center, random.Next(1, 100));
                case 7:
                    return new Sphere(center, random.Next(1, 100));
                default:
                    return null;
            }


        }
    }
}