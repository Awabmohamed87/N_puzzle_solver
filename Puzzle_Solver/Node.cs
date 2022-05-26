using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_Solver
{
    internal class Node
    {
        public ushort[] gameM;
        public int heuristicValue;
        public int levelNumber;
        ushort zeroIndexX, zeroIndexY;
        string moveDirection;
        public string parentDirection;
        public string path;
        public int oppositedirection;
        public string parentPath;
        public Node(string parentDirection, ushort[] matrix, int manhattan, int lvl, int zeroX, int zeroY, string moveDirection, int oppositeDirection)
        {
            this.parentDirection = parentDirection;
            levelNumber = lvl + 1;
            gameM = matrix;
            heuristicValue = manhattan;
            setZeroIndex(zeroX, zeroY);
            setMoveDirection(moveDirection);
            oppositedirection = oppositeDirection;
        }
        public void setZeroIndex(int x, int y)
        {
            zeroIndexX = (ushort)x;
            zeroIndexY = (ushort)y;
        }
        public ushort getZeroIndexX() => zeroIndexX;

        public ushort getZeroIndexY() => zeroIndexY;

        public void setMoveDirection(string s) => moveDirection = s;
        public string getMoveDirection() => moveDirection;

    }
}
