using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace lab2lib
{
    public class Circle : Shape2d
    {
        public Circle(Vector2 center, float radius)
        {
            _radius = radius;
        }

        private Vector2 _center;
        private float _radius;

        public override float Circumference
        {
            get
            {
                return (_radius + _radius) * (float)System.Math.PI;
            }
        }

        public override Vector3 Center => throw new NotImplementedException();

        public override float Area
        {
            get
            {
                return _radius * _radius * (float)System.Math.PI;
            }
        }

        public override string ToString()
        {
            return "Circle @:" + _center.ToString() + "r:" + _radius;
        }
    }
}
