using System;
using System.Numerics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace lab2lib
{
    public class Rectangle : Shape2d
    {
        private Vector2 center;
        private Vector2 size;
        private readonly bool _isSquare = false;

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.size = size;
            if (size.X == size.Y)
            {
                _isSquare = true;
            }
        }

        public Rectangle(Vector2 center, float width)
        {
            _isSquare = true;
            this.center = center;
            size = new Vector2(width);

        }

        public bool IsSquare
        {
            get => _isSquare;

        }
        public override float Circumference => size.X * 2 + size.Y * 2;

        public override Vector3 Center => new Vector3(center.X, center.Y, 0.0f);

        public override float Area => size.X * size.Y;

        public override string ToString()
        {
            if (IsSquare)
            {
                return $"Square @({center.X:0.00}, {center.Y:0.00}): w = {size.X:0.00}, h = {size.Y:0.00}";
            }
            else
                return $"Rectangle @({center.X:0.00}, {center.Y:0.00}): w = {size.X:0.00}, h = {size.Y:0.00}";
        }
    }
}