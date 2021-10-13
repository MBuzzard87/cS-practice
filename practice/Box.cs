using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Box
    {
        private int length;
        private int height;
        private int width;
        private int volume;

        public Box() { }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            volume = this.length * this.height * this.width;
        }

        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int GetVolume()
        { 
            return volume;
        }

    }
}
