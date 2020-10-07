using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab2lib
{
    public class Sphere : Shape3d
    {
        public Sphere(Vector3 center, float radius)
        {
            _radius = radius;
        }

        private Vector3 _center;
        private float _radius;

        public override float Area => throw new NotImplementedException();
        public override Vector3 Center => throw new NotImplementedException();

        public override float Volume 
        {
            get
            {
                return 4 * (float)System.Math.PI * (_radius * 3);
            }
        }

        public override string ToString()
        {
            return "Sphere @:" + _center.ToString() + "r:" + _radius;
        }
    }
}