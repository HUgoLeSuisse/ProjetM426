namespace SnakeAndLaders
{
    partial class Game
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
            menuStrip = new MenuStrip();
            btnOptions = new ToolStripMenuItem();
            btnAide = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pnlStart = new Panel();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { btnOptions, btnAide });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(779, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip1";
            // 
            // btnOptions
            // 
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(61, 20);
            btnOptions.Text = "Options";
            // 
            // btnAide
            // 
            btnAide.Name = "btnAide";
            btnAide.Size = new Size(43, 20);
            btnAide.Text = "Aide";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TableSnakeLader;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 513);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pnlStart
            // 
            pnlStart.Location = new Point(22, 479);
            pnlStart.Name = "pnlStart";
            pnlStart.Size = new Size(63, 41);
            pnlStart.TabIndex = 3;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 552);
            Controls.Add(pnlStart);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip);
            Name = "Game";
            Text = "Game";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem btnOptions;
        private ToolStripMenuItem btnAide;
        private PictureBox pictureBox1;
        private Panel pnlStart;
    }
}