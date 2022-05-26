using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle_Solver
{
    class Sample
    {
        string key;
        string path;
        bool isSolvableByHamming = false;
        public Sample(string key,string path,bool isSolvableByHamming = false) {
        this.path = path;
            this.key = key;
            this.isSolvableByHamming = isSolvableByHamming;
        }
        public string getKey() => key;
        public bool getSolvability() => isSolvableByHamming;

        public string getPath() => path;
    }
    internal class DataReader
    {
        int size = -1;
        ushort[,] puzzleMatrix;
        ushort[] puzzleList;

        string[] sampleUnSolvables = new string[5] {
                    "8 Puzzle - Case 1.txt",
                    "8 Puzzle(2) - Case 1.txt",
                    "8 Puzzle(3) - Case 1.txt",
                    "15 Puzzle - Case 2.txt",
                    "15 Puzzle - Case 3.txt" };
        string[] completeUnSolvables = new string[4] {
        "15 Puzzle 1 - Unsolvable.txt",
        "99 Puzzle - Unsolvable Case 1.txt",
        "99 Puzzle - Unsolvable Case 2.txt",
        "9999 Puzzle.txt"
        };
        string[] sampleSolvables = new string[6] {
            "8 Puzzle (1).txt",
            "8 Puzzle (2).txt",
            "8 Puzzle (3).txt",
            "15 Puzzle - 1.txt",
            "24 Puzzle 1.txt",
            "24 Puzzle 2.txt" };
        string[] completeSolvables = new string[4] {
        "15 Puzzle 1.txt","15 Puzzle 3.txt","15 Puzzle 4.txt","15 Puzzle 5.txt"
        };
        string veryLarge = "TEST.txt";
        string[] manhattanAndHamming = new string[4] {
            "50 Puzzle.txt","99 Puzzle - 1.txt","99 Puzzle - 2.txt","9999 Puzzle.txt"
        };
        Sample[] samples;
        public Sample[] listSamples()
        {
            samples = new Sample[15] {
                new Sample("Sample test 1","Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[0],true),
                new Sample("Sample test 2","Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[1],true),
                new Sample("Sample test 3","Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[2],true),
                new Sample("Sample test 4","Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[3],true),
                new Sample("Sample test 5","Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[4],true),
                new Sample("Sample test 6","Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[5],true),
                new Sample("complete test 1","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan & Hamming\\" + manhattanAndHamming[0],true),
                new Sample("complete test 2","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan & Hamming\\" + manhattanAndHamming[1],true),
                new Sample("complete test 3","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan & Hamming\\" + manhattanAndHamming[2],true),
                new Sample("complete test 4","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan & Hamming\\" + manhattanAndHamming[3],true),
                new Sample("complete test 1 Manhattan only","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan Only\\" + completeSolvables[0],false),
                new Sample("complete test 2 Manhattan only","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan Only\\" + completeSolvables[1],false),
                new Sample("complete test 3 Manhattan only","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan Only\\" + completeSolvables[2],false),
                new Sample("complete test 4 Manhattan only","Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan Only\\" + completeSolvables[3],false),
                new Sample("Very large test","Testcases\\Complete\\Complete Test\\V. Large test case\\" + veryLarge,false)

            };
            return samples;
        }
        public bool isSolvableByHamming(string key) {
            for (int i = 0;i<15;i++) {
            if(samples[i].getKey() == key)return samples[i].getSolvability();
            }
            return false;
        }
        public string getPath(string key)
        {
            for (int i = 0; i < 15; i++)
            {
                if (samples[i].getKey() == key) return samples[i].getPath();
            }
            return null;
        }
        public void readUnSolvables(int index) =>
            Read("Testcases\\Sample\\Sample Test\\Unsolvable Puzzles\\" + sampleUnSolvables[index]);



        public void readCompleteUnSolbables(int index) =>
                Read("Testcases\\Complete\\Complete Test\\Unsolvable puzzles\\" + completeUnSolvables[index]);



        public void readSampleSolvables(int index) =>
            Read("Testcases\\Sample\\Sample Test\\Solvable Puzzles\\" + sampleSolvables[index]);

        public void readCompleteSolvables(int index) =>
            Read("Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan Only\\" + completeSolvables[index]);

        public void readVeryLargeTest() =>
            Read("Testcases\\Complete\\Complete Test\\V. Large test case\\" + veryLarge);

        public void readManhhantanAndHammingTests(int index) =>
            Read("Testcases\\Complete\\Complete Test\\Solvable puzzles\\Manhattan & Hamming\\" + manhattanAndHamming[index]);
        public void Read(string path)
        {
            size = -1;
            int i = 0;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (size == -1)
                        {
                            size = int.Parse(line);
                            puzzleList = new ushort[size * size];
                            puzzleMatrix = new ushort[size, size];
                        }
                        else
                        {
                            if (line != "")
                            {
                                string[] lines = line.Split(" ");
                                for (int j = 0; j < size; j++)
                                {
                                    puzzleMatrix[i, j] = ushort.Parse(lines[j]);
                                    puzzleList[i * size + j] = ushort.Parse(lines[j]);
                                }
                                i++;
                            }
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
        public int getSize() => size;

        public ushort[] getPuzzleList() => puzzleList;

        public ushort[,] getPuzzleMatrix() => puzzleMatrix;
    }
}





