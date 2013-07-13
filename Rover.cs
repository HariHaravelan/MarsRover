using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_OOP
{
    class Rover
    {
        public int pos_X { get; set; }
        public int pos_Y { get; set; }
        public char facingDirection { get; set; }
        public char[] roverInput { get; set; }

        public Rover(int posX, int posY, char direction, char[] inputs)
        {
            this.pos_X = posX;
            this.pos_Y = posY;
            this.facingDirection = direction;
            this.roverInput = inputs;
        }


       
    }
}
