namespace Form_PersonalMovieTracker
{
    partial class Form1
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
            lblWelcome = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnCreateAccount = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = SystemColors.ActiveCaptionText;
            lblWelcome.Location = new Point(297, 89);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(244, 20);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to Personal Movie Tracker";
            lblWelcome.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // btnLogin
            // 
            btnLogin.ForeColor = SystemColors.HotTrack;
            btnLogin.Location = new Point(297, 126);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(245, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.ForeColor = SystemColors.MenuHighlight;
            btnCreateAccount.Location = new Point(297, 180);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(245, 29);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.ForeColor = SystemColors.Highlight;
            btnExit.Location = new Point(297, 236);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(245, 28);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(857, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(lblWelcome);
            ForeColor = SystemColors.Control;
            Name = "Form1";
            Text = "Movie Tracker PH";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblWelcome;
        private Label label2;
        private Button btnLogin;
        private Button btnCreateAccount;
        private Button btnExit;
    }
}
