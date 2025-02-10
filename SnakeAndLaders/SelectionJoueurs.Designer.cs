namespace SnakeAndLaders
{
    partial class SelectionJoueurs
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            btnOptions = new ToolStripMenuItem();
            btnAide = new ToolStripMenuItem();
            btnQuitter = new Button();
            pnlJoueurs = new Panel();
            rdb4Joueurs = new RadioButton();
            rdb3Joueurs = new RadioButton();
            rdb2Joueurs = new RadioButton();
            lblTitrePanelJoueur = new Label();
            btnStart = new Button();
            pnlJoueur1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            pnlJoueurs.SuspendLayout();
            pnlJoueur1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnOptions, btnAide });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(593, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            // btnQuitter
            // 
            btnQuitter.BackColor = Color.FromArgb(224, 224, 224);
            btnQuitter.FlatAppearance.BorderSize = 0;
            btnQuitter.FlatStyle = FlatStyle.Flat;
            btnQuitter.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuitter.Location = new Point(51, 407);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(111, 52);
            btnQuitter.TabIndex = 1;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = false;
            // 
            // pnlJoueurs
            // 
            pnlJoueurs.BorderStyle = BorderStyle.FixedSingle;
            pnlJoueurs.Controls.Add(rdb4Joueurs);
            pnlJoueurs.Controls.Add(rdb3Joueurs);
            pnlJoueurs.Controls.Add(rdb2Joueurs);
            pnlJoueurs.Location = new Point(48, 63);
            pnlJoueurs.Name = "pnlJoueurs";
            pnlJoueurs.Size = new Size(185, 106);
            pnlJoueurs.TabIndex = 2;
            // 
            // rdb4Joueurs
            // 
            rdb4Joueurs.AutoSize = true;
            rdb4Joueurs.Location = new Point(60, 69);
            rdb4Joueurs.Name = "rdb4Joueurs";
            rdb4Joueurs.Size = new Size(74, 19);
            rdb4Joueurs.TabIndex = 2;
            rdb4Joueurs.TabStop = true;
            rdb4Joueurs.Text = "4 Joueurs";
            rdb4Joueurs.UseVisualStyleBackColor = true;
            // 
            // rdb3Joueurs
            // 
            rdb3Joueurs.AutoSize = true;
            rdb3Joueurs.Location = new Point(60, 43);
            rdb3Joueurs.Name = "rdb3Joueurs";
            rdb3Joueurs.Size = new Size(74, 19);
            rdb3Joueurs.TabIndex = 1;
            rdb3Joueurs.TabStop = true;
            rdb3Joueurs.Text = "3 Joueurs";
            rdb3Joueurs.UseVisualStyleBackColor = true;
            // 
            // rdb2Joueurs
            // 
            rdb2Joueurs.AutoSize = true;
            rdb2Joueurs.Checked = true;
            rdb2Joueurs.Location = new Point(60, 18);
            rdb2Joueurs.Name = "rdb2Joueurs";
            rdb2Joueurs.Size = new Size(74, 19);
            rdb2Joueurs.TabIndex = 0;
            rdb2Joueurs.TabStop = true;
            rdb2Joueurs.Text = "2 Joueurs";
            rdb2Joueurs.UseVisualStyleBackColor = true;
            // 
            // lblTitrePanelJoueur
            // 
            lblTitrePanelJoueur.AutoSize = true;
            lblTitrePanelJoueur.Location = new Point(51, 54);
            lblTitrePanelJoueur.Name = "lblTitrePanelJoueur";
            lblTitrePanelJoueur.Size = new Size(109, 15);
            lblTitrePanelJoueur.TabIndex = 3;
            lblTitrePanelJoueur.Text = "Nombre de joueurs";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(224, 224, 224);
            btnStart.Enabled = false;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(424, 407);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(111, 52);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // pnlJoueur1
            // 
            pnlJoueur1.Controls.Add(textBox1);
            pnlJoueur1.Controls.Add(label1);
            pnlJoueur1.Location = new Point(280, 63);
            pnlJoueur1.Name = "pnlJoueur1";
            pnlJoueur1.Size = new Size(274, 42);
            pnlJoueur1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Joueur 1 ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(122, 23);
            textBox1.TabIndex = 7;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 498);
            Controls.Add(pnlJoueur1);
            Controls.Add(btnStart);
            Controls.Add(lblTitrePanelJoueur);
            Controls.Add(pnlJoueurs);
            Controls.Add(btnQuitter);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SnakeAndLader - Joueurs";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlJoueurs.ResumeLayout(false);
            pnlJoueurs.PerformLayout();
            pnlJoueur1.ResumeLayout(false);
            pnlJoueur1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnOptions;
        private ToolStripMenuItem btnAide;
        private Button btnQuitter;
        private Panel pnlJoueurs;
        private RadioButton rdb4Joueurs;
        private RadioButton rdb3Joueurs;
        private RadioButton rdb2Joueurs;
        private Label lblTitrePanelJoueur;
        private Button btnStart;
        private Panel pnlJoueur1;
        private Label label1;
        private TextBox textBox1;
    }
}
