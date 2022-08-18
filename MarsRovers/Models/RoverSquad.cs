using System;
using MarsRovers.Constants;
using MarsRovers.Interfaces;

namespace MarsRovers.Models
{
    public class RoverSquad: IRoverSquad
    {

        private Plataeu surface;
        private Rover currentRover;

        public RoverSquad(Plataeu surface = null)
        {
            this.surface = surface;
        }

        #region IRoverSquad Methods

        public Rover CurrentRover { get { return this.currentRover; } }
        public ISurface Surface { get { return this.surface; } }
        public void MoveRover(int x, int y, Direction direction)
        {
            if (x >= 0 && x < this.surface.Size.Width &&
                   y >= 0 && y < this.surface.Size.Height)
            {
                Rover rover = new Rover(x, y, direction, this.surface);
                this.currentRover = rover;
            } else
            {
                throw new Exception("This Rover is outside.");
            }
        }

        #endregion
    }
}

