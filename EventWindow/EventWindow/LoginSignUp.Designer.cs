namespace EventWindow
{
    partial class LoginSignUp
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
            lbLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btLogin = new Button();
            btSignUp = new Button();
            label4 = new Label();
            btShowPass = new Label();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Kantumruy Pro", 14.2499981F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            lbLogin.Location = new Point(216, 68);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(63, 28);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AKbalthom HighSchool", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(1, -2);
            label1.Name = "label1";
            label1.Size = new Size(146, 76);
            label1.TabIndex = 1;
            label1.Text = "Event Posting \r\n  Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 125);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 184);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(179, 125);
            tbUsername.MaxLength = 255;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(216, 23);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(179, 184);
            tbPassword.MaxLength = 255;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(216, 23);
            tbPassword.TabIndex = 5;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.FromArgb(0, 0, 192);
            btLogin.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btLogin.ForeColor = Color.White;
            btLogin.Location = new Point(91, 246);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(96, 32);
            btLogin.TabIndex = 6;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            // 
            // btSignUp
            // 
            btSignUp.BackColor = Color.FromArgb(0, 0, 192);
            btSignUp.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btSignUp.ForeColor = Color.White;
            btSignUp.Location = new Point(272, 246);
            btSignUp.Name = "btSignUp";
            btSignUp.RightToLeft = RightToLeft.No;
            btSignUp.Size = new Size(96, 32);
            btSignUp.TabIndex = 7;
            btSignUp.Text = "Sign Up";
            btSignUp.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kantumruy Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(91, 303);
            label4.Name = "label4";
            label4.Size = new Size(288, 36);
            label4.TabIndex = 8;
            label4.Text = "Don't have account? Fill Username and Password,\r\nthen click Sign Up";
            // 
            // btShowPass
            // 
            btShowPass.AutoSize = true;
            btShowPass.Font = new Font("Kantumruy Pro Medium", 9.749999F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            btShowPass.ForeColor = Color.FromArgb(0, 0, 192);
            btShowPass.Location = new Point(401, 188);
            btShowPass.Name = "btShowPass";
            btShowPass.Size = new Size(48, 19);
            btShowPass.TabIndex = 9;
            btShowPass.Text = "Show";
            // 
            // LoginSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 363);
            Controls.Add(btShowPass);
            Controls.Add(label4);
            Controls.Add(btSignUp);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbLogin);
            Name = "LoginSignUp";
            Text = "Event Posting Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btLogin;
        private Button btSignUp;
        private Label label4;
        private Label btShowPass;
    }
}