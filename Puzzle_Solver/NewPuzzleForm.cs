using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Solver
{
    public partial class NewPuzzleForm : Form
    {
        int puzzleSize;
        public NewPuzzleForm(int puzzleSize)
        {
            this.puzzleSize = puzzleSize;
            InitializeComponent();
        }
        TextBox[] txtBox;
        Panel createCard(int i, int j)
        {
   
            Panel panel = new Panel();
            txtBox[i * puzzleSize + j] = new TextBox();
            txtBox[i * puzzleSize + j].Width = 420 / puzzleSize - 2;
            txtBox[i * puzzleSize + j].Height = 420 / puzzleSize - 2;
            txtBox[i * puzzleSize + j].Font = new Font("Mongolian Baiti", 150 / puzzleSize, FontStyle.Bold);
            txtBox[i * puzzleSize + j].Name = "txtBx" + (i * puzzleSize + j);
            txtBox[i * puzzleSize + j].Location = new Point(4, 4);
            txtBox[i * puzzleSize + j].TextAlign = HorizontalAlignment.Center;
            txtBox[i * puzzleSize + j].BorderStyle = BorderStyle.None;
            txtBox[i * puzzleSize + j].Name = "txtBx" + (i * puzzleSize + j + 1);
            txtBox[i * puzzleSize + j].BackColor = Color.White;

            panel.Location = new Point(121 + j * (420 / puzzleSize), 103 + i * (420 / puzzleSize));
            panel.BackColor = Color.White;
            panel.Width = 420 / puzzleSize - 2;
            panel.Height = 420 / puzzleSize - 2;
            panel.Controls.Add(txtBox[i * puzzleSize + j]);
            return panel;
        }

        private void NewPuzzleForm_Load(object sender, EventArgs e)
        {
            //287, 103 420,420
            txtBox = new TextBox[puzzleSize*puzzleSize];
            for (int i = 0;i<puzzleSize;i++) {
                for (int j = 0;j<puzzleSize;j++) {
                   
                    Controls.Add(createCard(i,j));
                    
                }
            }
     

        }

        private void simulateSolve_btn_Click(object sender, EventArgs e)
        {
            ushort[,]gameMatrix = new ushort[puzzleSize,puzzleSize];
            ushort[]gameList = new ushort[puzzleSize*puzzleSize];
            bool isAlreadyEntered = false;
            bool isOutOfRange = false;
            bool isBadFormat = false;
            ushort counter = 0;
            for (int i = 0; i < puzzleSize; i++)
            {
                for (int j = 0; j < puzzleSize; j++)
                {
                    ushort tmp =0;
                    try {tmp = Convert.ToUInt16(txtBox[i * puzzleSize + j].Text); } catch (FormatException ex) { isBadFormat = true; }
                    gameList[i * puzzleSize + j] = tmp;
                    gameMatrix[i, j] = tmp;

                    if (gameList[i * puzzleSize + j] >= puzzleSize * puzzleSize || gameList[i * puzzleSize + j] < 0)
                        isOutOfRange = true;
                    else
                        counter++;

                    for (int x = 0;x< i * puzzleSize + j;x++) {
                        if (gameList[x] == gameList[i * puzzleSize + j]) {
                        isAlreadyEntered = true;
                        }
                    }

                }
            }
            if (!isAlreadyEntered && !isOutOfRange && !isBadFormat) {
                SolveWindow solveWindow = new SolveWindow(gameMatrix,gameList,(ushort)puzzleSize,0);
                solveWindow.Show();
                
            }

            else {
                MessageBox.Show("Bad entry \n puzzle should contain non repeated integers from 0 to N*N - 1");
            }
        }
    }
}
