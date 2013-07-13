using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_OOP
{
    class Movement
    {
        
        public void Move(Rover rover)
        {
            char direction = rover.facingDirection;
            switch (direction)
            {
                case Constants.North:
                    rover.pos_Y += 1;
                    break;

                case Constants.East:
                    rover.pos_X += 1;
                    break;

                case Constants.South:
                    rover.pos_Y -= 1;
                    break;

                case Constants.West:
                    rover.pos_X -= 1;
                    break;
            }
        }

        public void rotateLeft(Rover rover)
        {
            char direction = rover.facingDirection ;
            switch (direction)
            {
                case Constants.North:
                    rover.facingDirection = 'W';
                    break;

                case Constants.East:
                    rover.facingDirection = 'N';
                    break;

                case Constants.South:
                    rover.facingDirection = 'E';
                    break;

                case Constants.West:
                    rover.facingDirection = 'S';
                    break;
            }
        }

        public void rotateRight(Rover rover)
        {
            char direction = rover.facingDirection;
            switch (direction)
            {
                case Constants.North:
                    rover.facingDirection = 'E';
                    break;

                case Constants.East:
                    rover.facingDirection = 'S';
                    break;

                case Constants.South:
                    rover.facingDirection = 'W';
                    break;

                case Constants.West:
                    rover.facingDirection = 'N';
                    break;
            }
        }
    }
}
