namespace EventWindow
{
    partial class MyAccount
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
            pbProfile = new PictureBox();
            label1 = new Label();
            btChangeProfile = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            tbPhoneNumber = new TextBox();
            tbAddress = new TextBox();
            btCancel = new Button();
            btUpdate = new Button();
            ofdProfile = new OpenFileDialog();
            btRemoveProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // pbProfile
            // 
            pbProfile.ErrorImage = Properties.Resources.profile_holder;
            pbProfile.Image = Properties.Resources.profile_holder;
            pbProfile.InitialImage = Properties.Resources.profile_holder;
            pbProfile.Location = new Point(200, 30);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(100, 100);
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfile.TabIndex = 0;
            pbProfile.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kantumruy Pro SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 1;
            label1.Text = "My Account";
            // 
            // btChangeProfile
            // 
            btChangeProfile.BackColor = Color.FromArgb(0, 0, 192);
            btChangeProfile.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btChangeProfile.ForeColor = Color.White;
            btChangeProfile.Location = new Point(336, 40);
            btChangeProfile.Name = "btChangeProfile";
            btChangeProfile.Size = new Size(96, 32);
            btChangeProfile.TabIndex = 8;
            btChangeProfile.Text = "Change";
            btChangeProfile.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(78, 167);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 239);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 10;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 314);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 11;
            label4.Text = "Address";
            // 
            // tbName
            // 
            tbName.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(150, 166);
            tbName.MaxLength = 255;
            tbName.Name = "tbName";
            tbName.Size = new Size(294, 23);
            tbName.TabIndex = 12;
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPhoneNumber.Location = new Point(150, 238);
            tbPhoneNumber.MaxLength = 255;
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(294, 23);
            tbPhoneNumber.TabIndex = 13;
            // 
            // tbAddress
            // 
            tbAddress.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbAddress.Location = new Point(150, 313);
            tbAddress.MaxLength = 255;
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(294, 23);
            tbAddress.TabIndex = 14;
            // 
            // btCancel
            // 
            btCancel.BackColor = Color.Red;
            btCancel.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btCancel.ForeColor = Color.White;
            btCancel.Location = new Point(78, 388);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(96, 32);
            btCancel.TabIndex = 15;
            btCancel.Text = "Cancel";
            btCancel.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btUpdate.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.ForeColor = Color.White;
            btUpdate.Location = new Point(288, 388);
            btUpdate.Name = "btUpdate";
            btUpdate.RightToLeft = RightToLeft.No;
            btUpdate.Size = new Size(96, 32);
            btUpdate.TabIndex = 17;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            // 
            // ofdProfile
            // 
            ofdProfile.FileName = "";
            // 
            // btRemoveProfile
            // 
            btRemoveProfile.BackColor = Color.Red;
            btRemoveProfile.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btRemoveProfile.ForeColor = Color.White;
            btRemoveProfile.Location = new Point(336, 89);
            btRemoveProfile.Name = "btRemoveProfile";
            btRemoveProfile.Size = new Size(96, 32);
            btRemoveProfile.TabIndex = 18;
            btRemoveProfile.Text = "Remove";
            btRemoveProfile.UseVisualStyleBackColor = false;
            // 
            // MyAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 453);
            Controls.Add(btRemoveProfile);
            Controls.Add(btUpdate);
            Controls.Add(btCancel);
            Controls.Add(tbAddress);
            Controls.Add(tbPhoneNumber);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btChangeProfile);
            Controls.Add(label1);
            Controls.Add(pbProfile);
            Name = "MyAccount";
            Text = "Event Posting Application";
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProfile;
        private Label label1;
        private Button btChangeProfile;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbName;
        private TextBox tbPhoneNumber;
        private TextBox tbAddress;
        private Button btCancel;
        private Button btUpdate;
        private OpenFileDialog ofdProfile;
        private Button btRemoveProfile;
    }
}