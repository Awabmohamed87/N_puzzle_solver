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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataReader dr = new DataReader();
        private void insertPuzzle_btn_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(puzzleSize_tb.Text)<=10)
            {
                NewPuzzleForm newPuzzleForm = new NewPuzzleForm(Convert.ToInt32(puzzleSize_tb.Text));
                newPuzzleForm.Show();
            }
            else {
                MessageBox.Show("maximum N value is 10");
            }
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            readData();
            manhattan_rb.Checked = true;
        }
        private void readData() {
            
            foreach(var i in dr.listSamples())
                selectTest_cb.Items.Add(i.getKey());

        }

        private void selectTest_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dr.isSolvableByHamming(selectTest_cb.SelectedItem.ToString()))
            {
                hamming_rb.Enabled = false;
                BFS_rb.Enabled = false;
                manhattan_rb.Checked = true;
            }
            else {
                hamming_rb.Enabled = true;
                BFS_rb.Enabled = true;
            }
        }


        private void puzzleSize_tb_TextChanged(object sender, EventArgs e)
        {
            label6.Text = puzzleSize_tb.Text + " x " + puzzleSize_tb.Text + " puzzle";
        }

        private void simulateSolve_btn_Click(object sender, EventArgs e)
        {
            ushort solveSelection;
            if (BFS_rb.Checked)
                solveSelection = 2;
            else if (manhattan_rb.Checked)
                solveSelection = 0;
            else
                solveSelection = 1;

            //SolveWindow solveWindow = new SolveWindow(dr.getPuzzleMatrix(), dr.getPuzzleList(), (ushort)dr.getSize(), solveSelection);

            dr.Read(dr.getPath(selectTest_cb.SelectedItem.ToString()));
            if (dr.getSize() < 50)
            {
                SolveWindow solveWindow = new SolveWindow(dr.getPuzzleMatrix(), dr.getPuzzleList(), (ushort)dr.getSize(), solveSelection);

                solveWindow.Show();
            }
            else
            {
                Graph graph = new Graph(dr.getPuzzleMatrix(), dr.getPuzzleList(), (ushort)dr.getSize(), solveSelection);
                MessageBox.Show("Very large puzzle size\nNumber of moves : " + graph.getMovesNumber()
                + " Elapsed time : " + graph.getElapsedTime());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            dr.Read(openFileDialog1.FileName);
            ushort solveSelection;
            if (BFS_rb.Checked)
                solveSelection = 2;
            else if (manhattan_rb.Checked)
                solveSelection = 0;
            else
                solveSelection = 1;
                  
            SolveWindow solveWindow = new SolveWindow(dr.getPuzzleMatrix(), dr.getPuzzleList(), (ushort)dr.getSize(),solveSelection);
            solveWindow.Show();
        }
    }
}
