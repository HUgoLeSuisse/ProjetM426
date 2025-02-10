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
            menuStrip = new MenuStrip();
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
            btnColor1 = new Button();
            txtJoueur1 = new TextBox();
            lblJoueur1 = new Label();
            ColorDialog = new ColorDialog();
            pnlJoueur2 = new Panel();
            btnColor2 = new Button();
            txtJoueur2 = new TextBox();
            lblJoueur2 = new Label();
            pnlJoueur3 = new Panel();
            btnColor3 = new Button();
            txtJoueur3 = new TextBox();
            lblJoueur3 = new Label();
            pnlJoueur4 = new Panel();
            btnColor4 = new Button();
            txtJoueur4 = new TextBox();
            lblJoueur4 = new Label();
            menuStrip.SuspendLayout();
            pnlJoueurs.SuspendLayout();
            pnlJoueur1.SuspendLayout();
            pnlJoueur2.SuspendLayout();
            pnlJoueur3.SuspendLayout();
            pnlJoueur4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { btnOptions, btnAide });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(593, 24);
            menuStrip.TabIndex = 0;
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
            btnQuitter.Click += btnQuitter_Click;
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
            rdb4Joueurs.CheckedChanged += rdb4Joueurs_CheckedChanged;
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
            rdb3Joueurs.CheckedChanged += rdb3Joueurs_CheckedChanged;
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
            rdb2Joueurs.CheckedChanged += rdb2Joueurs_CheckedChanged;
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
            btnStart.Click += btnStart_Click;
            // 
            // pnlJoueur1
            // 
            pnlJoueur1.Controls.Add(btnColor1);
            pnlJoueur1.Controls.Add(txtJoueur1);
            pnlJoueur1.Controls.Add(lblJoueur1);
            pnlJoueur1.Location = new Point(280, 63);
            pnlJoueur1.Name = "pnlJoueur1";
            pnlJoueur1.Size = new Size(274, 42);
            pnlJoueur1.TabIndex = 5;
            // 
            // btnColor1
            // 
            btnColor1.BackColor = Color.Red;
            btnColor1.Location = new Point(219, 10);
            btnColor1.Name = "btnColor1";
            btnColor1.Size = new Size(36, 23);
            btnColor1.TabIndex = 8;
            btnColor1.UseVisualStyleBackColor = false;
            btnColor1.Click += btnColor1_Click;
            // 
            // txtJoueur1
            // 
            txtJoueur1.Location = new Point(77, 11);
            txtJoueur1.Name = "txtJoueur1";
            txtJoueur1.Size = new Size(122, 23);
            txtJoueur1.TabIndex = 7;
            // 
            // lblJoueur1
            // 
            lblJoueur1.AutoSize = true;
            lblJoueur1.Location = new Point(3, 9);
            lblJoueur1.Name = "lblJoueur1";
            lblJoueur1.Size = new Size(54, 15);
            lblJoueur1.TabIndex = 6;
            lblJoueur1.Text = "Joueur 1 ";
            // 
            // pnlJoueur2
            // 
            pnlJoueur2.Controls.Add(btnColor2);
            pnlJoueur2.Controls.Add(txtJoueur2);
            pnlJoueur2.Controls.Add(lblJoueur2);
            pnlJoueur2.Location = new Point(280, 111);
            pnlJoueur2.Name = "pnlJoueur2";
            pnlJoueur2.Size = new Size(274, 42);
            pnlJoueur2.TabIndex = 6;
            // 
            // btnColor2
            // 
            btnColor2.BackColor = Color.Blue;
            btnColor2.Location = new Point(219, 10);
            btnColor2.Name = "btnColor2";
            btnColor2.Size = new Size(36, 23);
            btnColor2.TabIndex = 8;
            btnColor2.UseVisualStyleBackColor = false;
            btnColor2.Click += btnColor2_Click;
            // 
            // txtJoueur2
            // 
            txtJoueur2.Location = new Point(77, 11);
            txtJoueur2.Name = "txtJoueur2";
            txtJoueur2.Size = new Size(122, 23);
            txtJoueur2.TabIndex = 7;
            // 
            // lblJoueur2
            // 
            lblJoueur2.AutoSize = true;
            lblJoueur2.Location = new Point(3, 9);
            lblJoueur2.Name = "lblJoueur2";
            lblJoueur2.Size = new Size(51, 15);
            lblJoueur2.TabIndex = 6;
            lblJoueur2.Text = "Joueur 2";
            // 
            // pnlJoueur3
            // 
            pnlJoueur3.Controls.Add(btnColor3);
            pnlJoueur3.Controls.Add(txtJoueur3);
            pnlJoueur3.Controls.Add(lblJoueur3);
            pnlJoueur3.Enabled = false;
            pnlJoueur3.Location = new Point(280, 159);
            pnlJoueur3.Name = "pnlJoueur3";
            pnlJoueur3.Size = new Size(274, 42);
            pnlJoueur3.TabIndex = 9;
            // 
            // btnColor3
            // 
            btnColor3.BackColor = Color.Yellow;
            btnColor3.Location = new Point(219, 10);
            btnColor3.Name = "btnColor3";
            btnColor3.Size = new Size(36, 23);
            btnColor3.TabIndex = 8;
            btnColor3.UseVisualStyleBackColor = false;
            btnColor3.Click += btnColor3_Click;
            // 
            // txtJoueur3
            // 
            txtJoueur3.Location = new Point(77, 11);
            txtJoueur3.Name = "txtJoueur3";
            txtJoueur3.Size = new Size(122, 23);
            txtJoueur3.TabIndex = 7;
            // 
            // lblJoueur3
            // 
            lblJoueur3.AutoSize = true;
            lblJoueur3.Location = new Point(3, 9);
            lblJoueur3.Name = "lblJoueur3";
            lblJoueur3.Size = new Size(54, 15);
            lblJoueur3.TabIndex = 6;
            lblJoueur3.Text = "Joueur 3 ";
            // 
            // pnlJoueur4
            // 
            pnlJoueur4.Controls.Add(btnColor4);
            pnlJoueur4.Controls.Add(txtJoueur4);
            pnlJoueur4.Controls.Add(lblJoueur4);
            pnlJoueur4.Enabled = false;
            pnlJoueur4.Location = new Point(280, 207);
            pnlJoueur4.Name = "pnlJoueur4";
            pnlJoueur4.Size = new Size(274, 42);
            pnlJoueur4.TabIndex = 9;
            // 
            // btnColor4
            // 
            btnColor4.BackColor = Color.LimeGreen;
            btnColor4.Location = new Point(219, 10);
            btnColor4.Name = "btnColor4";
            btnColor4.Size = new Size(36, 23);
            btnColor4.TabIndex = 8;
            btnColor4.UseVisualStyleBackColor = false;
            btnColor4.Click += btnColor4_Click;
            // 
            // txtJoueur4
            // 
            txtJoueur4.Location = new Point(77, 11);
            txtJoueur4.Name = "txtJoueur4";
            txtJoueur4.Size = new Size(122, 23);
            txtJoueur4.TabIndex = 7;
            // 
            // lblJoueur4
            // 
            lblJoueur4.AutoSize = true;
            lblJoueur4.Location = new Point(3, 9);
            lblJoueur4.Name = "lblJoueur4";
            lblJoueur4.Size = new Size(51, 15);
            lblJoueur4.TabIndex = 6;
            lblJoueur4.Text = "Joueur 4";
            // 
            // SelectionJoueurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 498);
            Controls.Add(pnlJoueur4);
            Controls.Add(pnlJoueur3);
            Controls.Add(pnlJoueur2);
            Controls.Add(pnlJoueur1);
            Controls.Add(btnStart);
            Controls.Add(lblTitrePanelJoueur);
            Controls.Add(pnlJoueurs);
            Controls.Add(btnQuitter);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "SelectionJoueurs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SnakeAndLader - Joueurs";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlJoueurs.ResumeLayout(false);
            pnlJoueurs.PerformLayout();
            pnlJoueur1.ResumeLayout(false);
            pnlJoueur1.PerformLayout();
            pnlJoueur2.ResumeLayout(false);
            pnlJoueur2.PerformLayout();
            pnlJoueur3.ResumeLayout(false);
            pnlJoueur3.PerformLayout();
            pnlJoueur4.ResumeLayout(false);
            pnlJoueur4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
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
        private Label lblJoueur1;
        private TextBox txtJoueur1;
        private Button btnColor1;
        private ColorDialog ColorDialog;
        private Panel pnlJoueur2;
        private Button btnColor2;
        private TextBox txtJoueur2;
        private Label lblJoueur2;
        private Panel pnlJoueur3;
        private Button btnColor3;
        private TextBox txtJoueur3;
        private Label lblJoueur3;
        private Panel pnlJoueur4;
        private Button btnColor4;
        private TextBox txtJoueur4;
        private Label lblJoueur4;
    }
}
