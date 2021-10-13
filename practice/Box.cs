using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    class Box
    {
     
        private int volume;

        public Box() { }

        public Box(int length, int height, int width)
        {
            if(length > 0 && height > 0 && width > 0)
            {
                Length = length;
                Height = height;
                Width = width;
                volume = length * height * width;
            } else
            {
                Console.WriteLine("enter a number greater than 1");
            }
            
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
