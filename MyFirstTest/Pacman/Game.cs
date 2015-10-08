using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Game
    {
        Point playerPosition = new Point(0, 0);

        public void SetPlayerPosition(Point position)
        {
            playerPosition = position;
        }

        private Dictionary<Direction, Point> deltaMap = new Dictionary<Direction, Point>{
            {Direction.Left, new Point(-1, 0)},
            {Direction.Right, new Point(1, 0)},
            {Direction.Up, new Point(0, -1)},
            {Direction.Down, new Point(0, 1)},
        };

        public void MovePlayer(Direction direction)
        {
            var delta = deltaMap[direction];
            playerPosition.Add(delta);
        }

        public Point GetPlayerPosition()
        {
             return playerPosition;
        }
    }
}
