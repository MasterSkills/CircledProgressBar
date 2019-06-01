namespace ProgressBarDemo
{
    partial class FrmMain
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
            this.circleProgramBar = new ProgressBarDemo.CircleProgramBar();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circleProgramBar
            // 
            this.circleProgramBar.BackColor = System.Drawing.Color.White;
            this.circleProgramBar.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circleProgramBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.circleProgramBar.FinishedColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(179)))), ((int)(((byte)(63)))));
            this.circleProgramBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleProgramBar.Location = new System.Drawing.Point(0, 0);
            this.circleProgramBar.MaxValue = 100;
            this.circleProgramBar.Name = "circleProgramBar";
            this.circleProgramBar.Progress = 50;
            this.circleProgramBar.Size = new System.Drawing.Size(889, 562);
            this.circleProgramBar.TabIndex = 0;
            this.circleProgramBar.Text = "circleProgramBar1";
            this.circleProgramBar.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(179)))), ((int)(((byte)(63)))));
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(705, 494);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(151, 40);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.circleProgramBar);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CircleProgramBar Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private CircleProgramBar circleProgramBar;
        private System.Windows.Forms.Button btnTest;
    }
}

