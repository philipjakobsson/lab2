using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab2lib
{
    public class Triangle : Shape2d
    {
        private Vector2 _p1;
        private Vector2 _p2;
        private Vector2 _p3;



        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            _p1 = p1;
            _p2 = p2;
            _p3 = p3;
        }
        public override float Area
        {
            get
            {
                return 1f;
            }
        }

        public override float Circumference
        {
            get
            {
                return 1f;
            }
        }

        public override string ToString()
        {
            return "Triangle @:";
        }
        public override Vector3 Center => throw new NotImplementedException();

    }

}

