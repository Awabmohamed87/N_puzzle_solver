using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.Threading;

namespace Puzzle_Solver
{
    public class Graph
    {
        List<int>[] adjacents;
        ushort[] gameMatrix;
        ushort[] gameList;
        public static int puzzleSize;
        int hammingValue = 0, manhattanValue = 0;
        int zeroIndexX, zeroIndexY;
        int levelNumber;
        string theWay = "";
        Dictionary<int, KeyValuePair<int, int>> arrayIndex;

        Stopwatch stopwatch;

        public Graph(ushort[,] gameMatrix, ushort[] gameList, int size, ushort solveSelection)
        {

            this.gameMatrix = gameList;
            this.gameList = gameList;
            puzzleSize = size; 
            stopwatch = new Stopwatch();
            stopwatch.Start();

            initiateGraph();

            if (isSolvable())
            {
                if (solveSelection == 0) solveByManhattan();
                else if (solveSelection == 1)
                    solveByHamming();
                else
                    BFS();

                isSolve = true;
            }
            
        }
        class DFSNode
        {
            public PriorityQueue<Node, int> children = new PriorityQueue<Node, int>();
            public PriorityQueue<Node, int> parentQueue = new PriorityQueue<Node, int>();
        }
        void BFS()
        {
            manhattanValue = calcManhattanWeight();
            bool isSolved = false;
            PriorityQueue<DFSNode, int> pa = new PriorityQueue<DFSNode, int>();

            Node Root = new(null, gameMatrix, manhattanValue, -1, zeroIndexX, zeroIndexY, "N", -1);
            Node parent = Root;
            DFSNode dfsNode = new DFSNode();

            Node node;
            int[] dir = new int[4] { 3, 0, 2, 1 };
            List<Node> closedList = new List<Node>();
            bool inList = false;
            while (!isSolved)
            {
                dfsNode.parentQueue = dfsNode.children;
                dfsNode.children.Clear();
                foreach (int i in dir)
                {
                    inList = false;
                    if (i < adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1].Count)
                    {


                        if (adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] == parent.oppositedirection)
                            continue;
                        ushort[] matrix = new ushort[puzzleSize * puzzleSize];
                        parent.gameM.CopyTo(matrix, 0);

                        int m = parent.heuristicValue - cost(matrix, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value);

                        matrix[zeroIndexX * puzzleSize + zeroIndexY] = matrix[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] - 1];
                        matrix[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] - 1] = 0;

                        m += cost(matrix, zeroIndexX, zeroIndexY);

                        node = new Node(parent.getMoveDirection(), matrix, m, parent.levelNumber, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key,
                            arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value,
                                                mapMove(zeroIndexX, zeroIndexY, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key,
                                                arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value), zeroIndexX * puzzleSize + zeroIndexY + 1);
                        node.parentPath = parent.path;
                        for (int a = 0; a < closedList.Count; a++)
                        {
                            if (compare2Darray(closedList[a].gameM, node.gameM))
                            {
                                inList = true;
                                break;
                            }
                        }
                        if (inList)
                            continue;
                        dfsNode.children.Enqueue(node, node.heuristicValue + node.levelNumber);

                    }
                }
                while (true)
                {
                    if (dfsNode.children.Count > 0)
                    {
                        parent = dfsNode.children.Dequeue();
                        break;
                    }
                    else
                        dfsNode.children = dfsNode.parentQueue;
                }
                closedList.Add(parent);
                parent.path += parent.getMoveDirection() + parent.parentPath;

                zeroIndexX = parent.getZeroIndexX();
                zeroIndexY = parent.getZeroIndexY();

                if (parent.heuristicValue == 0)
                {
                    isSolved = true;

                }

            }

            levelNumber = parent.levelNumber;
            theWay = parent.path;
        }

        public bool compare2Darray(ushort[] arr1, ushort[] arr2)
        {
            for (int i = 0; i < puzzleSize * puzzleSize; i++)
            {
                if (arr2[i] != arr1[i])
                    return false;
            }
            return true;
        }
        public int getMovesNumber() => levelNumber;
        public string getElapsedTime() => Convert.ToString( stopwatch.Elapsed.TotalSeconds);

        bool isSolve = false;
        public bool isSolved() => isSolve;

        public string getPath() => theWay;
        int calcHammingWeight(ushort[] matrix)
        {
            int h = 0;
            for (int i = 0; i < puzzleSize; i++)
            {
                for (int j = 0; j < puzzleSize; j++)
                {
                    if (matrix[i * puzzleSize + j] != 0)
                    {
                        if (matrix[i * puzzleSize + j] != i * puzzleSize + j + 1)
                            h++;
                    }
                }
            }
            return h;
        }

        void solveByHamming()
        {
            hammingValue = calcHammingWeight(gameMatrix);
            bool isSolved = false;
            PriorityQueue<Node, int> pa = new PriorityQueue<Node, int>();

            Node Root = new(null, gameMatrix, hammingValue, -1, zeroIndexX, zeroIndexY, "N", -1);
            Node parent = Root;
            Node node;

            while (!isSolved)
            {

                for (int i = 0; i < adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1].Count; i++)
                {
                    if (adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] == parent.oppositedirection)
                        continue;
                    ushort[] matrix = new ushort[puzzleSize * puzzleSize];

                    parent.gameM.CopyTo(matrix, 0);



                    matrix[zeroIndexX * puzzleSize + zeroIndexY] = matrix[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] - 1];
                    matrix[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] - 1] = 0;

                    int m = calcHammingWeight(matrix);

                    node = new Node(parent.getMoveDirection(), matrix, m, parent.levelNumber, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key,
                        arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value,
                        mapMove(zeroIndexX, zeroIndexY, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key,
                        arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value),
                        zeroIndexX * puzzleSize + zeroIndexY + 1);
                    node.parentPath = parent.path;

                    pa.Enqueue(node, (node.heuristicValue + node.levelNumber));


                }

                parent = pa.Dequeue();


                parent.path += parent.getMoveDirection() + parent.parentPath;
                zeroIndexX = parent.getZeroIndexX();
                zeroIndexY = parent.getZeroIndexY();

                if (parent.heuristicValue == 0)
                {
                    isSolved = true;

                }

            }

            levelNumber = parent.levelNumber;
            theWay = parent.path;
        }

        string mapMove(int a, int b, int x, int y)
        {
            if (a == x)
            {
                if (b + 1 == y) return "R";
                else return "L";
            }
            if (b == y)
            {
                if (a + 1 == x) return "D";
                else return "U";
            }
            return null;

        }
        void solveByManhattan()
        {
            manhattanValue = calcManhattanWeight();
            bool isSolved = false;
            PriorityQueue<Node, int> pa = new PriorityQueue<Node, int>();

            Node Root = new(null, gameMatrix, manhattanValue, -1, zeroIndexX, zeroIndexY, "N", -1);
            Node parent = Root;

            Node node;
            int[] dir = new int[4] { 3, 0, 2, 1 };

            while (!isSolved)
            {
                foreach (int i in dir)
                {
                    if (i < adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1].Count)
                    {

                        if (adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] == parent.oppositedirection)
                            continue;
                        ushort[] matrix = new ushort[puzzleSize * puzzleSize];
                        parent.gameM.CopyTo(matrix, 0);

                        int m = parent.heuristicValue - cost(matrix, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value);

                        matrix[zeroIndexX * puzzleSize + zeroIndexY] = matrix[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] - 1];
                        matrix[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i] - 1] = 0;

                        m += cost(matrix, zeroIndexX, zeroIndexY);

                        node = new Node(parent.getMoveDirection(), matrix, m, parent.levelNumber, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key,
                            arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value,
                                                mapMove(zeroIndexX, zeroIndexY, arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Key,
                                                arrayIndex[adjacents[zeroIndexX * puzzleSize + zeroIndexY + 1][i]].Value), zeroIndexX * puzzleSize + zeroIndexY + 1);
                        node.parentPath = parent.path;
                        pa.Enqueue(node, (node.heuristicValue + node.levelNumber));
                    }
                }

                parent = pa.Dequeue();

                parent.path += parent.getMoveDirection() + parent.parentPath;

                zeroIndexX = parent.getZeroIndexX();
                zeroIndexY = parent.getZeroIndexY();

                if (parent.heuristicValue == 0)
                {
                    isSolved = true;

                }

            }

            levelNumber = parent.levelNumber;
            theWay = parent.path;
        }

         bool isSolvable()
        {

            int zeroIndex = -1;
            int inversionCount = 0;

            for (int i = 0; i < gameList.Length - 1; i++)
            {
                if (gameList[i] == 0)
                {
                    zeroIndex = i;
                    continue;
                }
                for (int j = i + 1; j < gameList.Length; j++)
                {
                    if (gameList[j] < gameList[i] && gameList[j] != 0) inversionCount++;
                }
            }

            zeroIndex = puzzleSize - zeroIndexX;

            if (puzzleSize % 2 != 0 && inversionCount % 2 == 0) return true;
            else if (puzzleSize % 2 == 0)
            {
                if (inversionCount % 2 != 0 && zeroIndex % 2 == 0) return true;
                else if (inversionCount % 2 == 0 && zeroIndex % 2 != 0) return true;
            }
            else
                return false;
            return false;
        }
        void initiateGraph()
        {

            arrayIndex = new Dictionary<int, KeyValuePair<int, int>>();
            adjacents = new List<int>[puzzleSize * puzzleSize + 1];

            for (int i = 0; i <= puzzleSize * puzzleSize; i++)
                adjacents[i] = new List<int>();

            for (int i = 0; i < puzzleSize; i++)
            {
                for (int j = 0; j < puzzleSize; j++)
                {
                    if ((i * puzzleSize) + j + 1 <= puzzleSize * puzzleSize)
                    {
                        KeyValuePair<int, int> pair = new KeyValuePair<int, int>(i, j);
                        arrayIndex[(i * puzzleSize) + j + 1] = pair;

                    }
                    if (gameMatrix[i * puzzleSize + j] == 0) { zeroIndexX = i; zeroIndexY = j; }

                    if (j < puzzleSize - 1)
                        addEdge((i * puzzleSize) + j, (i * puzzleSize) + j + 1);

                    if (i < puzzleSize - 1)
                        addEdge((i * puzzleSize) + j, ((i + 1) * puzzleSize) + j);
                }
            }
            KeyValuePair<int, int> p = new KeyValuePair<int, int>(puzzleSize - 1, puzzleSize - 1);
            arrayIndex[0] = p;

        }

        int cost(ushort[] matrix, int i, int j) => Math.Abs(arrayIndex[matrix[i * puzzleSize + j]].Key - i) + Math.Abs(arrayIndex[matrix[i * puzzleSize + j]].Value - j);

        int calcManhattanWeight()
        {
            int h = 0;
            for (int i = 0; i < puzzleSize; i++)
            {
                for (int j = 0; j < puzzleSize; j++)
                {
                    if (gameMatrix[i * puzzleSize + j] != 0)
                    {

                        h += cost(gameMatrix, i, j);
                    }
                }
            }
            return h;
        }

        void addEdge(int source, int dist)
        {
            adjacents[source + 1].Add(dist + 1);
            adjacents[dist + 1].Add(source + 1);
        }
    }
}
