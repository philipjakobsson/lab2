using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace lab2lib
{
    class Rectangle : Shape2d
    {
        private Vector2 _center;
        private Vector2 _size;

        public override Vector3 Center => throw new NotImplementedException();

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = center;
            _size = size;
        }

        public override float Area
        {
            get
            {
                return _size.X * _size.Y;
            }
        }

        public override float Circumference
        {
            get
            {
                return (_size.X * 2) + (_size.Y * 2);
            }
        }

        public override string ToString()
        {
            return CheckSize() + _center.ToString() + "w= " + _size.X + "h= " + _size.Y;
        }

        private string CheckSize()
        {
            if (_size.X == _size.Y)
                return "Square @:";

            return "Rectangle @:";
        }
    }
}

