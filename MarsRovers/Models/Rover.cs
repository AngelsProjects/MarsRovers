using System;
using MarsRovers.Constants;
using MarsRovers.Interfaces;

namespace MarsRovers.Models
{
    public class Rover : IRover
    {
        private int x;
        private int y;
        private Direction direction;
        private ISurface surface;

        public Rover(int x, int y, Direction direction, ISurface surface)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.surface = surface;
        }


        #region IRover Methods

        public int X
        {
            get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }

        public Direction Direction
        {
            get { return this.direction; }
        }

        public ISurface Surface
        {
            get { return this.surface; }
        }

        public void Move(Movement movement)
        {
            switch (movement)
            {
                case Movement.L:
                    this.TurnLeft();
                    break;
                case Movement.R:
                    this.TurnRight();
                    break;
                case Movement.M:
                    this.MoveForward();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(movement), movement, null);
            }
        }

        #endregion

        private void MoveForward()
        {
            switch (this.direction)
            {
                case Direction.N:
                    if (this.y + 1 <= this.surface.Size.Height)
                        this.y += 1;
                    break;

                case Direction.E:
                    if (this.x + 1 <= this.surface.Size.Width)
                        this.x += 1;
                    break;

                case Direction.S:
                    if (this.y - 1 >= 0)
                        this.y -= 1;
                    break;

                case Direction.W:
                    if (this.x - 1 >= 0)
                        this.x -= 1;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void TurnLeft()
        {
            switch (this.direction)
            {
                case Direction.N:
                    this.direction = Direction.W;
                    break;

                case Direction.W:
                    this.direction = Direction.S;
                    break;

                case Direction.S:
                    this.direction = Direction.E;
                    break;

                case Direction.E:
                    this.direction = Direction.N;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void TurnRight()
        {
            switch (this.direction)
            {
                case Direction.N:
                    this.direction = Direction.E;
                    break;

                case Direction.E:
                    this.direction = Direction.S;
                    break;

                case Direction.S:
                    this.direction = Direction.W;
                    break;

                case Direction.W:
                    this.direction = Direction.N;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}

