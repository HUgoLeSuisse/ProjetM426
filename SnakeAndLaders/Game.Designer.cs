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
            pnlPlateau = new Panel();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { btnOptions, btnAide });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(686, 24);
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
            // pnlPlateau
            // 
            pnlPlateau.Location = new Point(19, 41);
            pnlPlateau.Name = "pnlPlateau";
            pnlPlateau.Size = new Size(655, 411);
            pnlPlateau.TabIndex = 2;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 552);
            Controls.Add(pnlPlateau);
            Controls.Add(menuStrip);
            Name = "Game";
            Text = "Game";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem btnOptions;
        private ToolStripMenuItem btnAide;
        private Panel pnlPlateau;
    }
}