using System;
using MarsRovers.Constants;
using MarsRovers.Models;

namespace MarsRovers.Interfaces
{
    public interface IRoverSquad
    {
        // List<Rover> Rovers { get; }
        Rover CurrentRover { get; }
        ISurface Surface { get; }
        void MoveRover(int x, int y, Direction direction);
    }
}

