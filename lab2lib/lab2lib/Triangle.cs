using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab2lib
{
    public class Triangle : Shape2d
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private float a;
        private float b;
        private float c;


        private float s = 0;
        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            a = Vector2.Distance(p1, p2);
            b = Vector2.Distance(p2, p3);
            c = Vector2.Distance(p3, p1);
            s = (float)1 / 2 * (a + b + c);
        }



        public override float Circumference => (float)(a + b + c);
        public override Vector3 Center => new Vector3((p1.X + p2.X + p3.X) / 3f, (p1.Y + p2.Y + p3.Y) / 3f, 0f);

        public override float Area => (float)Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        public override string ToString()
        {
            return $"Triangle @({Center.X:0.00}, {Center.Y:0.00}): p1{p1:0.00}, p2{p2:0.00}, p3{p3:0.00}";
        }
    }
}


