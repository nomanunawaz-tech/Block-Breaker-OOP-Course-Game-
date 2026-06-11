using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace oop_final_game
{
    [DesignerCategory("Form")]
    public partial class StartForm : Form
    {
        public string PlayerName { get; private set; } = "Player";

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            PlayerName = string.IsNullOrEmpty(name) ? "Player" : name;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Player")
                txtName.Clear();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
                txtName.Text = "Player";
        }
    }
}
