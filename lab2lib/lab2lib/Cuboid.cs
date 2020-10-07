using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace lab2lib
{
    public class Cuboid : Shape3d
    {
        private Vector3 _size;
        private Vector3 _center;
        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _size = size;
        }

        public override float Volume
        {
            get
            {
                return _size.X * _size.Y *_size.Z;
            }
        }

        public override Vector3 Center => throw new NotImplementedException();

        public override string ToString()
        {
            return CheckSize() + _center.ToString() + " w= " + _size.X + " h= " + _size.Y + " l=" + _size.Z;
        }

        private string CheckSize()
        {
            if (_size.X == _size.Y && _size.X == _size.Z && _size.Y == _size.Z) 
                return "Cube @:";

            return "Cuboid @:";
        }
        public override float Area => throw new NotImplementedException();
        
    }
}
