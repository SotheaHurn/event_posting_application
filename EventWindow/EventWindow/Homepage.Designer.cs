namespace EventWindow
{
    partial class Homepage
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
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbName = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AKbalthom HighSchool", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(146, 76);
            label1.TabIndex = 2;
            label1.Text = "Event Posting \r\n  Application";
            // 
            // panel1
            // 
            panel1.Location = new Point(-2, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 466);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.profile_holder;
            pictureBox1.Image = Properties.Resources.profile_holder;
            pictureBox1.InitialImage = Properties.Resources.profile_holder;
            pictureBox1.Location = new Point(643, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Kantumruy Pro Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(740, 22);
            lbName.Name = "lbName";
            lbName.Size = new Size(89, 23);
            lbName.TabIndex = 5;
            lbName.Text = "Unknown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kantumruy Pro Medium", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(740, 56);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 6;
            label2.Text = "0123456789";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kantumruy Pro Medium", 8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(852, 58);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 7;
            label3.Text = "View Account";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 558);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbName);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Homepage";
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbName;
        private Label label2;
        private Label label3;
    }
}