using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Puzzle_Solver
{
    
    public partial class SolveWindow : Form
    {
        
        ushort puzzleSize;
        int zeroIndexX, zeroIndexY;
        ushort[,] gameMatrix;
        ushort[] gameList;
        ushort solveSelection;
        public SolveWindow(ushort[,] gameMatrix ,ushort[] gameList,ushort puzzleSize,ushort solveSelection)
        {
            this.gameMatrix = gameMatrix;
            this.gameList = gameList;
            this.puzzleSize = puzzleSize;   
            this.solveSelection = solveSelection;
            InitializeComponent();

        }
        TextBox[] txtBox;
        Panel createCard(int a,int i, int j)
        {
            if (a == 0) {
                zeroIndexX = i;
                zeroIndexY = j;
            }

           Panel panel = new Panel();
            txtBox[i * puzzleSize + j] = new TextBox();
            txtBox[i*puzzleSize+j].Width = 420 / puzzleSize - 10;
            txtBox[i * puzzleSize + j].Height = 420 / puzzleSize - 10;
            txtBox[i * puzzleSize + j].Font = new Font("Mongolian Baiti", 150 / puzzleSize, FontStyle.Bold);
            txtBox[i * puzzleSize + j].Name = "txtBx" + (i * puzzleSize + j + 1);
            txtBox[i * puzzleSize + j].Location = new Point(4, 4);
            if(puzzleSize == 3)
                txtBox[i * puzzleSize + j].TextAlign = HorizontalAlignment.Center;
            else
            txtBox[i * puzzleSize + j].TextAlign = HorizontalAlignment.Left;
            txtBox[i * puzzleSize + j].BorderStyle = BorderStyle.None;
            txtBox[i * puzzleSize + j].Text = Convert.ToString(a);
            txtBox[i * puzzleSize + j].ReadOnly = true;
            txtBox[i * puzzleSize + j].Name = "txtBx" + (i*puzzleSize + j + 1);
            txtBox[i * puzzleSize + j].BackColor = Color.LightGray;
     
            panel.Location = new Point(121 + j * (420 / puzzleSize), 103 + i * (420 / puzzleSize));
            panel.BackColor = Color.White;
            panel.Width = 420 / puzzleSize - 10;
            panel.Height = 420 / puzzleSize - 10;
            panel.BackColor = Color.LightGray;
            panel.Controls.Add(txtBox[i * puzzleSize + j]);
            return panel;
        }
        Graph graph;    
        private void simulateSolve_btn_Click(object sender, EventArgs e)
        {
           
            graph = new Graph(gameMatrix, gameList, puzzleSize,solveSelection);

            if (graph.getPath().Length == 0) {
                MessageBox.Show("UnSolvable puzzle");
            }
            else
            {
                numberOfMoves_lbl.Text = "Number of moves : " + graph.getMovesNumber();
                elapsedTime_lbl.Text = "Elapsed time : " + graph.getElapsedTime();
            }
        }

        private void SolveWindow_Load(object sender, EventArgs e)
        {

            txtBox = new TextBox[puzzleSize * puzzleSize];
            
            for (int i = 0; i < puzzleSize; i++)
            {
                for (int j = 0; j < puzzleSize; j++)
                {
                    Controls.Add(createCard(gameMatrix[i,j], i, j));
                }
            }
        }
        int l;
        string path;
        Timer timer;
        private void button1_Click(object sender, EventArgs e)
        {
            path = graph.getPath();
            l = path.Length - 1;

            timer = new Timer();
            timer.Interval = 300;
            
            timer.Tick += new EventHandler(TimerEventProcessor);
            timer.Start();
 
            }

        private void TimerEventProcessor(object? sender, EventArgs e)
        {
            string x = Convert.ToString(path[l]);
            if (x == "U")
            {
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Text = txtBox[(zeroIndexX - 1) * puzzleSize + zeroIndexY].Text;
                txtBox[(zeroIndexX - 1) * puzzleSize + zeroIndexY].Text = "0";
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Enabled = true;
                txtBox[(zeroIndexX - 1) * puzzleSize + zeroIndexY].Enabled = false;
                zeroIndexX -= 1;
            }
            else if (x == "D")
            {
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Text = txtBox[(zeroIndexX + 1) * puzzleSize + zeroIndexY].Text;
                txtBox[(zeroIndexX + 1) * puzzleSize + zeroIndexY].Text = "0";
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Enabled = true;
                txtBox[(zeroIndexX + 1) * puzzleSize + zeroIndexY].Enabled = false;
                zeroIndexX += 1;
            }
            else if (x == "R")
            {
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Text = txtBox[zeroIndexX * puzzleSize + (zeroIndexY + 1)].Text;
                txtBox[zeroIndexX * puzzleSize + (zeroIndexY + 1)].Text = "0";
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Enabled = true;
                txtBox[zeroIndexX * puzzleSize + (zeroIndexY + 1)].Enabled = false;
                zeroIndexY += 1;
            }
            else if (x == "L")
            {
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Text = txtBox[zeroIndexX * puzzleSize + (zeroIndexY - 1)].Text;
                txtBox[zeroIndexX * puzzleSize + (zeroIndexY - 1)].Text = "0";
                txtBox[zeroIndexX * puzzleSize + zeroIndexY].Enabled = true;
                txtBox[zeroIndexX * puzzleSize + (zeroIndexY - 1)].Enabled = false;
                zeroIndexY -= 1;
            }
            l--;
            if (l < 0) timer.Stop();
        }
    }
    }

