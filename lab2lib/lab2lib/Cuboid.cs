using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab2lib
{
    public class Cuboid : Shape3d
    {
        private float width;
        private Vector3 center;
        private Vector3 size;
        private readonly bool _isCube = false;

        private float h;
        private float w;
        private float l;

        public Cuboid(Vector3 center, Vector3 size)
        {

            this.center = center;
            this.size = size;

            h = size.X;
            w = size.Y;
            l = size.Z;

            if (h == w && h == l)
            {
                _isCube = true;
            }
        }

        public Cuboid(Vector3 center, float width)
        {
            _isCube = true;
            this.center = center;
            this.width = width;
            size = new Vector3(width);
            h = size.X;
            w = size.Y;
            l = size.Z;
        }

        public bool IsCube
        {
            get => _isCube;
        }

        public override float Volume => h * w * l;

        public override Vector3 Center => center;

        public override float Area => 2 * (l * w + l * h + w * h);

        public override string ToString()
        {
            if (IsCube)
            {
                return $"Cube @({center.X:0.00}, {center.Y:0.00}, {center.Z:0.00}): w = {width:0.00}, h = {width:0.00}, l = {width:0.00}";
            }
            else
                return $"Cuboid @({center.X:0.00}, {center.Y:0.00}, {center.Z:0.00}): w = {w:0.00}, h = {h:0.00}, l = {l:0.00}";
        }
    }
}