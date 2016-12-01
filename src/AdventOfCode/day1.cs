using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class day1 : ISolvable
    {
        enum Direction
        {
            North,
            East,
            South,
            West
        }
        public int SolvePart1(string input)
        {
            var instructions = input.Replace(" ", string.Empty).Split(',');


            int x = 0, y = 0;
            int maxX = 1, maxY = 1;
            Direction direction = Direction.North;

            foreach (var instruction in instructions)
            {
                switch (instruction[0])
                {
                    case 'L':
                        direction = (Direction)((int)direction - 1 % 4);
                        break;
                    case 'R':
                        direction = (Direction)((int)direction - 1 % 4);
                        break;
                }

                switch (direction)
                {
                    case Direction.North:
                        y++;
                        break;
                    case Direction.East:
                        x++;
                        break;
                    case Direction.South:
                        y--;
                        break;
                    case Direction.West:
                        x--;
                        break;
                }
            }

            int distance = 0;
            return distance;
        }

        public int SolvePart2(string input)
        {
            throw new NotImplementedException();
        }
    }
}
