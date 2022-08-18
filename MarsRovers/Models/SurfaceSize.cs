using System;
namespace MarsRovers.Models
{
    public class SurfaceSize
    {

        private int height;
        private int width;

        public int Width { get { return this.width; } }
        public int Height { get { return this.height; } }

        public SurfaceSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}

