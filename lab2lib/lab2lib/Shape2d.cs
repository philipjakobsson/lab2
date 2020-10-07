using System;
using System.Collections.Generic;
using System.Text;

namespace lab2lib
{
    public abstract class Shape2d : Shape
    {
        readonly float X;
        readonly float Y;
        public abstract float Circumference { get; }
    }

}