namespace oop_final_game
{
    partial class EndForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblResult = new Label();
            lblIcon = new Label();
            pnlBody = new Panel();
            pnlDivider = new Panel();
            lblStars = new Label();
            lblScore = new Label();
            lblScoreTitle = new Label();
            pnlFooter = new Panel();
            btnExit = new Button();
            btnPlayAgain = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(60, 20, 20);
            pnlHeader.Controls.Add(lblResult);
            pnlHeader.Controls.Add(lblIcon);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1021, 150);
            pnlHeader.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.Dock = DockStyle.Top;
            lblResult.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(248, 113, 113);
            lblResult.Location = new Point(0, 94);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(1021, 66);
            lblResult.TabIndex = 1;
            lblResult.Text = "GAME OVER";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIcon
            // 
            lblIcon.Dock = DockStyle.Top;
            lblIcon.Font = new Font("Segoe UI Emoji", 32F);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(1021, 94);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "💀";
            lblIcon.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(28, 28, 42);
            pnlBody.Controls.Add(pnlDivider);
            pnlBody.Controls.Add(lblStars);
            pnlBody.Controls.Add(lblScore);
            pnlBody.Controls.Add(lblScoreTitle);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 150);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(40, 10, 40, 10);
            pnlBody.Size = new Size(1021, 445);
            pnlBody.TabIndex = 1;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(60, 60, 90);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(40, 225);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(941, 1);
            pnlDivider.TabIndex = 3;
            // 
            // lblStars
            // 
            lblStars.Dock = DockStyle.Top;
            lblStars.Font = new Font("Segoe UI", 22F);
            lblStars.ForeColor = Color.FromArgb(250, 204, 21);
            lblStars.Location = new Point(40, 159);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(941, 66);
            lblStars.TabIndex = 2;
            lblStars.Text = "☆☆☆";
            lblStars.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            lblScore.Dock = DockStyle.Top;
            lblScore.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(40, 60);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(941, 99);
            lblScore.TabIndex = 1;
            lblScore.Text = "0";
            lblScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblScoreTitle
            // 
            lblScoreTitle.Dock = DockStyle.Top;
            lblScoreTitle.Font = new Font("Segoe UI", 10F);
            lblScoreTitle.ForeColor = Color.FromArgb(150, 150, 190);
            lblScoreTitle.Location = new Point(40, 10);
            lblScoreTitle.Name = "lblScoreTitle";
            lblScoreTitle.Size = new Size(941, 50);
            lblScoreTitle.TabIndex = 0;
            lblScoreTitle.Text = "FINAL SCORE";
            lblScoreTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(18, 18, 30);
            pnlFooter.Controls.Add(btnExit);
            pnlFooter.Controls.Add(btnPlayAgain);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 595);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(40, 16, 40, 16);
            pnlFooter.Size = new Size(1021, 88);
            pnlFooter.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(50, 50, 70);
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(80, 80, 110);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F);
            btnExit.ForeColor = Color.FromArgb(180, 180, 210);
            btnExit.Location = new Point(1091, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(130, 52);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlayAgain
            // 
            btnPlayAgain.BackColor = Color.FromArgb(99, 102, 241);
            btnPlayAgain.Cursor = Cursors.Hand;
            btnPlayAgain.FlatAppearance.BorderSize = 0;
            btnPlayAgain.FlatStyle = FlatStyle.Flat;
            btnPlayAgain.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlayAgain.ForeColor = Color.White;
            btnPlayAgain.Location = new Point(40, 16);
            btnPlayAgain.Name = "btnPlayAgain";
            btnPlayAgain.Size = new Size(210, 52);
            btnPlayAgain.TabIndex = 0;
            btnPlayAgain.Text = "▶   Play Again";
            btnPlayAgain.UseVisualStyleBackColor = false;
            btnPlayAgain.Click += btnPlayAgain_Click;
            // 
            // EndForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 42);
            ClientSize = new Size(1021, 683);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EndForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block Breaker";
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblScoreTitle;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
    }
}
