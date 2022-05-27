namespace Puzzle_Solver
{
    partial class SolveWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolveWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfMoves_lbl = new System.Windows.Forms.Label();
            this.elapsedTime_lbl = new System.Windows.Forms.Label();
            this.simulateSolve_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.solveState_lbl = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(397, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "N puzzle";
            // 
            // numberOfMoves_lbl
            // 
            this.numberOfMoves_lbl.AutoSize = true;
            this.numberOfMoves_lbl.BackColor = System.Drawing.Color.Transparent;
            this.numberOfMoves_lbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfMoves_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.numberOfMoves_lbl.Location = new System.Drawing.Point(627, 230);
            this.numberOfMoves_lbl.Name = "numberOfMoves_lbl";
            this.numberOfMoves_lbl.Size = new System.Drawing.Size(289, 31);
            this.numberOfMoves_lbl.TabIndex = 3;
            this.numberOfMoves_lbl.Text = "Number of moves : 0";
            // 
            // elapsedTime_lbl
            // 
            this.elapsedTime_lbl.AutoSize = true;
            this.elapsedTime_lbl.BackColor = System.Drawing.Color.Transparent;
            this.elapsedTime_lbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.elapsedTime_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.elapsedTime_lbl.Location = new System.Drawing.Point(638, 285);
            this.elapsedTime_lbl.Name = "elapsedTime_lbl";
            this.elapsedTime_lbl.Size = new System.Drawing.Size(264, 31);
            this.elapsedTime_lbl.TabIndex = 4;
            this.elapsedTime_lbl.Text = "Elapsed time: 0 sec";
            // 
            // simulateSolve_btn
            // 
            this.simulateSolve_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.simulateSolve_btn.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulateSolve_btn.Location = new System.Drawing.Point(599, 361);
            this.simulateSolve_btn.Name = "simulateSolve_btn";
            this.simulateSolve_btn.Size = new System.Drawing.Size(168, 49);
            this.simulateSolve_btn.TabIndex = 12;
            this.simulateSolve_btn.Text = "Solve";
            this.simulateSolve_btn.UseVisualStyleBackColor = false;
            this.simulateSolve_btn.Click += new System.EventHandler(this.simulateSolve_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(807, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 49);
            this.button1.TabIndex = 13;
            this.button1.Text = "Simulate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // solveState_lbl
            // 
            this.solveState_lbl.AutoSize = true;
            this.solveState_lbl.BackColor = System.Drawing.Color.Transparent;
            this.solveState_lbl.Enabled = false;
            this.solveState_lbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.solveState_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.solveState_lbl.Location = new System.Drawing.Point(701, 446);
            this.solveState_lbl.Name = "solveState_lbl";
            this.solveState_lbl.Size = new System.Drawing.Size(0, 31);
            this.solveState_lbl.TabIndex = 14;
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.BackColor = System.Drawing.Color.Transparent;
            this.status_lbl.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.status_lbl.ForeColor = System.Drawing.Color.LightGray;
            this.status_lbl.Location = new System.Drawing.Point(724, 446);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(132, 31);
            this.status_lbl.TabIndex = 15;
            this.status_lbl.Text = "Solving..";
            this.status_lbl.Visible = false;
            // 
            // SolveWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.solveState_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.simulateSolve_btn);
            this.Controls.Add(this.elapsedTime_lbl);
            this.Controls.Add(this.numberOfMoves_lbl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SolveWindow";
            this.Text = "N puzzle";
            this.Load += new System.EventHandler(this.SolveWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label numberOfMoves_lbl;
        private Label elapsedTime_lbl;
        private Button simulateSolve_btn;
        private Button button1;
        private Label solveState_lbl;
        private Label status_lbl;
    }
}