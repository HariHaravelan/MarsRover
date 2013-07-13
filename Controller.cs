using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_OOP
{
    class Controller
    {
        public int grid_maxY { get; set; }
        public int grid_maxX { get; set; }
        char direction;
        Movement move = new Movement();
        public void DisplayMoves(Rover rover)
        {
            char[] inputs = rover.roverInput;
            foreach (char c in inputs)
            {
                direction = c;
                switch (direction)
                {
                    case Constants.Left:
                        move.rotateLeft(rover);
                        break;
                    case Constants.Right:
                        move.rotateRight(rover);
                        break;
                    case Constants.Move:
                        move.Move(rover);
                        break;
                }
            }
            Console.WriteLine(rover.pos_X + "\t" + rover.pos_Y + "\t" + rover.facingDirection);
        }

        

        static void Main(string[] args)
        {
            Controller lay = new Controller();
            Console.WriteLine("Enter Total Grid");
            string grid = Console.ReadLine();
            string[] grid_arr = grid.Split(' ');
            lay.grid_maxX = Convert.ToInt32(grid_arr[0]);
            lay.grid_maxY = Convert.ToInt32(grid_arr[1]);
            Console.WriteLine("Type Rover Coordinates");
            string roveronepos = Console.ReadLine();
            string[] roverpos = roveronepos.Split(' ');
            int pos_X = Convert.ToInt32(roverpos[0]);
            int pos_Y = Convert.ToInt32(roverpos[1]);
            string dir = roverpos[2];
            char facingDirection = dir[0];  
            Console.WriteLine("Inputs");
            string inputs = Console.ReadLine();
            char[] roverInput = inputs.ToCharArray();
            Rover roverone = new Rover(pos_X, pos_Y, facingDirection, roverInput);

            lay.DisplayMoves(roverone);
            Console.ReadLine();
        }
    }
}
