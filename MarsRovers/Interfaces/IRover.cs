using System;
using MarsRovers.Constants;

namespace MarsRovers.Interfaces
{
    public interface IRover
    {
        int X { get; }

        int Y { get; }

        ISurface Surface { get; }

        Direction Direction { get; }

        void Move(Movement movement);
    }
}

