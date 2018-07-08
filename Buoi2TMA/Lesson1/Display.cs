using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson1
{
    class Display
    {

        int _size, _color;


        public Display( int size, int color)
        {
            Size = size;
            Color = color;
        }

        public int Size { get => _size; set => _size = value; }
        public int Color { get => _color; set => _color = value; }
    }
}
