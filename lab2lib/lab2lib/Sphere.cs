using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab2lib
{
    public class Sphere : Shape3d
    {
        Vector3 center;
        float radius;
        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override float Volume => (float)(4 / 3 * Math.PI * Math.Pow(radius, 3));

        public override Vector3 Center => center;

        public override float Area => (float)(4 * Math.PI * Math.Pow(radius, 2));

        public override string ToString()
        {
            return $"Sphere @({center.X:0.00}, {center.Y:0.00}, {center.Z:0.00}): r = {radius:0.00}";
        }
    }
}