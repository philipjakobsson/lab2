using System;
using System.Collections.Generic;
using System.Text;

namespace lab2lib
{
    public abstract class Shape3d : Shape
    {
        readonly float x;
        readonly float y;
        readonly float z;
        public abstract float Volume { get; }
    }
}
