namespace Puzzle_Solver
{
    partial class NewPuzzleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPuzzleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.simulateSolve_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(323, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter puzzle";
            // 
            // simulateSolve_btn
            // 
            this.simulateSolve_btn.BackColor = System.Drawing.Color.LightGray;
            this.simulateSolve_btn.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.simulateSolve_btn.Location = new System.Drawing.Point(746, 251);
            this.simulateSolve_btn.Name = "simulateSolve_btn";
            this.simulateSolve_btn.Size = new System.Drawing.Size(225, 49);
            this.simulateSolve_btn.TabIndex = 11;
            this.simulateSolve_btn.Text = "Simulate solve";
            this.simulateSolve_btn.UseVisualStyleBackColor = false;
            this.simulateSolve_btn.Click += new System.EventHandler(this.simulateSolve_btn_Click);
            // 
            // NewPuzzleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1006, 529);
            this.Controls.Add(this.simulateSolve_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPuzzleForm";
            this.Text = "N puzzle";
            this.Load += new System.EventHandler(this.NewPuzzleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button simulateSolve_btn;
    }
}