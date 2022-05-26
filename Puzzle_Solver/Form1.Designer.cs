namespace Puzzle_Solver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectTest_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.manhattan_rb = new System.Windows.Forms.RadioButton();
            this.hamming_rb = new System.Windows.Forms.RadioButton();
            this.puzzleSize_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.simulateSolve_btn = new System.Windows.Forms.Button();
            this.insertPuzzle_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(392, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "N puzzle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(555, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Puzzle size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(678, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create puzzle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(106, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select exsisting puzzle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(29, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Test";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(508, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 309);
            this.panel1.TabIndex = 5;
            // 
            // selectTest_cb
            // 
            this.selectTest_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selectTest_cb.FormattingEnabled = true;
            this.selectTest_cb.Location = new System.Drawing.Point(204, 257);
            this.selectTest_cb.Name = "selectTest_cb";
            this.selectTest_cb.Size = new System.Drawing.Size(245, 28);
            this.selectTest_cb.TabIndex = 6;
            this.selectTest_cb.SelectedIndexChanged += new System.EventHandler(this.selectTest_cb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.manhattan_rb);
            this.groupBox1.Controls.Add(this.hamming_rb);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(132, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solve by";
            // 
            // manhattan_rb
            // 
            this.manhattan_rb.AutoSize = true;
            this.manhattan_rb.Location = new System.Drawing.Point(59, 43);
            this.manhattan_rb.Name = "manhattan_rb";
            this.manhattan_rb.Size = new System.Drawing.Size(114, 22);
            this.manhattan_rb.TabIndex = 1;
            this.manhattan_rb.TabStop = true;
            this.manhattan_rb.Text = "Manhattan";
            this.manhattan_rb.UseVisualStyleBackColor = true;
            // 
            // hamming_rb
            // 
            this.hamming_rb.AutoSize = true;
            this.hamming_rb.Location = new System.Drawing.Point(59, 84);
            this.hamming_rb.Name = "hamming_rb";
            this.hamming_rb.Size = new System.Drawing.Size(105, 22);
            this.hamming_rb.TabIndex = 0;
            this.hamming_rb.TabStop = true;
            this.hamming_rb.Text = "Hamming";
            this.hamming_rb.UseVisualStyleBackColor = true;
            // 
            // puzzleSize_tb
            // 
            this.puzzleSize_tb.BackColor = System.Drawing.Color.LightGray;
            this.puzzleSize_tb.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.puzzleSize_tb.Location = new System.Drawing.Point(736, 256);
            this.puzzleSize_tb.Name = "puzzleSize_tb";
            this.puzzleSize_tb.Size = new System.Drawing.Size(92, 29);
            this.puzzleSize_tb.TabIndex = 8;
            this.puzzleSize_tb.Text = "N";
            this.puzzleSize_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.puzzleSize_tb.TextChanged += new System.EventHandler(this.puzzleSize_tb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(844, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "N x N puzzle";
            // 
            // simulateSolve_btn
            // 
            this.simulateSolve_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.simulateSolve_btn.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulateSolve_btn.Location = new System.Drawing.Point(151, 468);
            this.simulateSolve_btn.Name = "simulateSolve_btn";
            this.simulateSolve_btn.Size = new System.Drawing.Size(225, 49);
            this.simulateSolve_btn.TabIndex = 10;
            this.simulateSolve_btn.Text = "Simulate solve";
            this.simulateSolve_btn.UseVisualStyleBackColor = false;
            this.simulateSolve_btn.Click += new System.EventHandler(this.simulateSolve_btn_Click);
            // 
            // insertPuzzle_btn
            // 
            this.insertPuzzle_btn.BackColor = System.Drawing.Color.LightGray;
            this.insertPuzzle_btn.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertPuzzle_btn.Location = new System.Drawing.Point(653, 339);
            this.insertPuzzle_btn.Name = "insertPuzzle_btn";
            this.insertPuzzle_btn.Size = new System.Drawing.Size(225, 49);
            this.insertPuzzle_btn.TabIndex = 11;
            this.insertPuzzle_btn.Text = "Insert puzzle";
            this.insertPuzzle_btn.UseVisualStyleBackColor = false;
            this.insertPuzzle_btn.Click += new System.EventHandler(this.insertPuzzle_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.insertPuzzle_btn);
            this.Controls.Add(this.simulateSolve_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.puzzleSize_tb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.selectTest_cb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "N puzzle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private ComboBox selectTest_cb;
        private GroupBox groupBox1;
        private RadioButton manhattan_rb;
        private RadioButton hamming_rb;
        private TextBox puzzleSize_tb;
        private Label label6;
        private Button simulateSolve_btn;
        private Button insertPuzzle_btn;
    }
}