using System;
using MarsRovers.Interfaces;

namespace MarsRovers.Models
{
    public class Plataeu: ISurface
    {
        private SurfaceSize size;

        public Plataeu(int width = 0, int height = 0)
        {
            this.size = new SurfaceSize(width, height);
        }

        #region ISurface Methods

        public SurfaceSize Size { get { return this.size; } }

        #endregion
    }
}

