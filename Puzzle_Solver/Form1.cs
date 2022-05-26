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
            NewPuzzleForm newPuzzleForm = new NewPuzzleForm(Convert.ToInt32(puzzleSize_tb.Text));
            newPuzzleForm.Show();
            //this.Close();
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
                manhattan_rb.Checked = true;
            }
            else {
                hamming_rb.Enabled = true;
            }
        }


        private void puzzleSize_tb_TextChanged(object sender, EventArgs e)
        {
            label6.Text = puzzleSize_tb.Text + " x " + puzzleSize_tb.Text + " puzzle";
        }

        private void simulateSolve_btn_Click(object sender, EventArgs e)
        {
            
            dr.Read(dr.getPath(selectTest_cb.SelectedItem.ToString()));
            SolveWindow solveWindow = new SolveWindow(dr.getPuzzleMatrix(),dr.getPuzzleList(),(ushort)dr.getSize(),manhattan_rb.Checked?(ushort)0: (ushort)1);
            solveWindow.Show();
        }
    }
}
