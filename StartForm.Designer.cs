namespace oop_final_game
{
    partial class StartForm
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlBody = new Panel();
            lblControls = new Label();
            pnlDivider = new Panel();
            txtName = new TextBox();
            lblNamePrompt = new Label();
            pnlFooter = new Panel();
            button1 = new Button();
            btnExit = new Button();
            btnPlay = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(15, 15, 26);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 5, 4, 5);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(871, 200);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Dock = DockStyle.Bottom;
            lblSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblSubtitle.ForeColor = Color.FromArgb(150, 150, 190);
            lblSubtitle.Location = new Point(0, 143);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(871, 57);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Arcade Edition";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(871, 117);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BLOCK BREAKER";
            lblTitle.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(28, 28, 42);
            pnlBody.Controls.Add(lblControls);
            pnlBody.Controls.Add(pnlDivider);
            pnlBody.Controls.Add(txtName);
            pnlBody.Controls.Add(lblNamePrompt);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 200);
            pnlBody.Margin = new Padding(4, 5, 4, 5);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(57, 40, 57, 17);
            pnlBody.Size = new Size(871, 319);
            pnlBody.TabIndex = 1;
            // 
            // lblControls
            // 
            lblControls.Font = new Font("Segoe UI", 9.5F);
            lblControls.ForeColor = Color.FromArgb(120, 130, 160);
            lblControls.Location = new Point(53, 150);
            lblControls.Margin = new Padding(4, 0, 4, 0);
            lblControls.Name = "lblControls";
            lblControls.Size = new Size(795, 91);
            lblControls.TabIndex = 3;
            lblControls.Text = "Move paddle           SPACE  Launch ball\r\nDestroy all bricks before time runs out!";
            lblControls.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(60, 60, 90);
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(57, 40);
            pnlDivider.Margin = new Padding(0, 17, 0, 17);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(757, 2);
            pnlDivider.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(18, 18, 30);
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 14F);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(173, 100);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.MaxLength = 15;
            txtName.Name = "txtName";
            txtName.Size = new Size(533, 45);
            txtName.TabIndex = 1;
            txtName.Text = "Player";
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // lblNamePrompt
            // 
            lblNamePrompt.Font = new Font("Segoe UI", 10F);
            lblNamePrompt.ForeColor = Color.FromArgb(160, 160, 200);
            lblNamePrompt.Location = new Point(44, 33);
            lblNamePrompt.Margin = new Padding(4, 0, 4, 0);
            lblNamePrompt.Name = "lblNamePrompt";
            lblNamePrompt.Size = new Size(795, 62);
            lblNamePrompt.TabIndex = 0;
            lblNamePrompt.Text = "                         Enter your name";
            lblNamePrompt.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(18, 18, 30);
            pnlFooter.Controls.Add(button1);
            pnlFooter.Controls.Add(btnExit);
            pnlFooter.Controls.Add(btnPlay);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 519);
            pnlFooter.Margin = new Padding(4, 5, 4, 5);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Padding = new Padding(57, 27, 57, 27);
            pnlFooter.Size = new Size(871, 150);
            pnlFooter.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(446, 27);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(294, 87);
            button1.TabIndex = 2;
            button1.Text = "❌   Exit Game";
            button1.UseVisualStyleBackColor = false;
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
            btnExit.Location = new Point(999, 27);
            btnExit.Margin = new Padding(4, 5, 4, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(186, 87);
            btnExit.TabIndex = 1;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(99, 102, 241);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.FlatAppearance.BorderSize = 0;
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(57, 27);
            btnPlay.Margin = new Padding(4, 5, 4, 5);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(293, 87);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "▶   Play Game";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 42);
            ClientSize = new Size(871, 669);
            Controls.Add(pnlBody);
            Controls.Add(pnlFooter);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Block Breaker";
            pnlHeader.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlFooter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label lblNamePrompt;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private Button button1;
    }
}
