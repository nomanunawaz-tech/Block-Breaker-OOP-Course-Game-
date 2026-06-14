using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace oop_final_game
{
    [DesignerCategory("Form")]
    public partial class EndForm : Form
    {
        // Parameterless constructor — used by Visual Studio Designer
        public EndForm()
        {
            InitializeComponent();
        }

        // Runtime constructor — called by Form1 when the game ends
        public EndForm(GameEndResult result, string playerName, int score)
        {
            InitializeComponent();
            ApplyResult(result, playerName, score);
        }

        private void ApplyResult(GameEndResult result, string playerName, int score)
        {
            bool isWin = result == GameEndResult.Win;

            if (isWin)
            {
                pnlHeader.BackColor = System.Drawing.Color.FromArgb(20, 60, 35);
                lblResult.ForeColor = System.Drawing.Color.FromArgb(74, 222, 128);
                lblResult.Text = "YOU WIN!";
                lblIcon.Text = "🏆";
                btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
            }
            else
            {
                pnlHeader.BackColor = System.Drawing.Color.FromArgb(60, 20, 20);
                lblResult.ForeColor = System.Drawing.Color.FromArgb(248, 113, 113);
                lblResult.Text = "GAME OVER";
                lblIcon.Text = "💀";
                btnPlayAgain.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            }

            //lblGreeting.Text = isWin
            //    ? $"Great job, {playerName}!"
            //    : $"Better luck next time, {playerName}!";

            lblScore.Text = score.ToString("N0");

            int stars = score >= 500 ? 3 : score >= 200 ? 2 : 1;
            lblStars.Text = new string('★', stars) + new string('☆', 3 - stars);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
