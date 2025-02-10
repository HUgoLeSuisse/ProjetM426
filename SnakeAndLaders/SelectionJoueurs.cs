namespace SnakeAndLaders
{
    public partial class SelectionJoueurs : Form
    {
        // Les couleurs des perssonages
        Color Color1 = Color.Red;
        Color Color2 = Color.Blue;
        Color Color3 = Color.Yellow;
        Color Color4 = Color.Green;

        public SelectionJoueurs()
        {
            InitializeComponent();
        }

        #region Couleurs des perssonages
        private void btnColor1_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color1 = ColorDialog.Color;
                btnColor1.BackColor = ColorDialog.Color;
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color2 = ColorDialog.Color;
                btnColor2.BackColor = ColorDialog.Color;
            }
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color3 = ColorDialog.Color;
                btnColor3.BackColor = ColorDialog.Color;
            }
        }

        private void btnColor4_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                Color4 = ColorDialog.Color;
                btnColor4.BackColor = ColorDialog.Color;
            }
        }
        #endregion
        /// <summary>
        /// le bouton pour quitter 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Les checkBox pour le nombre de joueurs

        private void rdb2Joueurs_CheckedChanged(object sender, EventArgs e)
        {
            pnlJoueur3.Enabled = false;
            pnlJoueur4.Enabled = false;
        }

        private void rdb3Joueurs_CheckedChanged(object sender, EventArgs e)
        {
            pnlJoueur3.Enabled = true;
            pnlJoueur4.Enabled = false;
        }

        private void rdb4Joueurs_CheckedChanged(object sender, EventArgs e)
        {
            pnlJoueur3.Enabled=true;
            pnlJoueur4.Enabled=true;
        }
        #endregion
    }
}
