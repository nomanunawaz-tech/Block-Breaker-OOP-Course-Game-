using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace oop_final_game
{
    public partial class Form1 : Form
    {
        Game game;
        private string _playerName;
        public bool ShouldRestart { get; private set; } = false;

        public Form1(string playerName = "Player")
        {
            _playerName = playerName;
            InitializeComponent();
            this.Size = new Size(1600, 800);

            game = new Game(this.ClientSize.Width, this.ClientSize.Height);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            game.Draw(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            game.update();
            this.Invalidate();

            if (game.isOver)
            {
                timer.Stop();
                ShowEndScreen();
            }
        }

        private void ShowEndScreen()
        {
            var result = game.scores >= 1 && !game.isGameLost
                ? GameEndResult.Win
                : GameEndResult.Lose;

            // Always show Lose when isOver and player ran out of balls
            result = GameEndResult.Lose;

            var endForm = new EndForm(result, _playerName, game.scores);
            var dlgResult = endForm.ShowDialog();

            if (dlgResult == DialogResult.Retry)
            {
                ShouldRestart = true;
            }

            this.Close();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Suppress default background painting for smooth rendering
        }
    }
}
