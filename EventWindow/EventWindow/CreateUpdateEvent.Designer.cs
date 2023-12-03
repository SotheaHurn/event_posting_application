namespace EventWindow
{
    partial class CreateUpdateEvent
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
            dtpEndTime = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            cbCategory = new ComboBox();
            btSave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            tbName = new TextBox();
            label4 = new Label();
            btRemoveLogo = new Button();
            btChangeLogo = new Button();
            pbLogo = new PictureBox();
            lbTitle = new Label();
            ofdEventLogo = new OpenFileDialog();
            label1 = new Label();
            tbLocation = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // dtpEndTime
            // 
            dtpEndTime.CustomFormat = "hh:mm tt";
            dtpEndTime.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(288, 320);
            dtpEndTime.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpEndTime.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.ShowUpDown = true;
            dtpEndTime.Size = new Size(93, 23);
            dtpEndTime.TabIndex = 54;
            dtpEndTime.Value = DateTime.Now.AddDays(1);
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "dd MMMM yyyy";
            dtpEndDate.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(140, 320);
            dtpEndDate.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(142, 23);
            dtpEndDate.TabIndex = 53;
            dtpEndDate.Value = DateTime.Now.AddDays(1);
            // 
            // dtpStartTime
            // 
            dtpStartTime.CustomFormat = "hh:mm tt";
            dtpStartTime.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(288, 264);
            dtpStartTime.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpStartTime.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.ShowUpDown = true;
            dtpStartTime.Size = new Size(93, 23);
            dtpStartTime.TabIndex = 52;
            dtpStartTime.Value = DateTime.Now;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd MMMM yyyy";
            dtpStartDate.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(140, 264);
            dtpStartDate.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(142, 23);
            dtpStartDate.TabIndex = 50;
            dtpStartDate.Value = DateTime.Now;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Kantumruy Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "None", "Charity", "Concerts", "Parties", "Sports", "Conferences", "Exhibitions", "Workshops", "Festivals", "Meetups", "Fundraisers", "Classes", "Comedy Shows", "Theater And Plays", "Movies And Screenings", "Gaming", "Food And Drink", "Art And Culture", "Outdoor Activities", "Tech And Innovation", "Health And Wellness" });
            cbCategory.Location = new Point(140, 370);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(241, 26);
            cbCategory.TabIndex = 51;
            // 
            // btSave
            // 
            btSave.BackColor = Color.FromArgb(0, 0, 192);
            btSave.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btSave.ForeColor = Color.White;
            btSave.Location = new Point(163, 469);
            btSave.Name = "btSave";
            btSave.Size = new Size(89, 32);
            btSave.TabIndex = 48;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 374);
            label7.Name = "label7";
            label7.Size = new Size(83, 22);
            label7.TabIndex = 47;
            label7.Text = "Category*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 322);
            label6.Name = "label6";
            label6.Size = new Size(85, 22);
            label6.TabIndex = 46;
            label6.Text = "End Date*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 266);
            label5.Name = "label5";
            label5.Size = new Size(93, 22);
            label5.TabIndex = 45;
            label5.Text = "Start Date*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 87);
            label2.Name = "label2";
            label2.Size = new Size(45, 22);
            label2.TabIndex = 44;
            label2.Text = "Logo";
            // 
            // tbName
            // 
            tbName.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbName.Location = new Point(140, 211);
            tbName.MaxLength = 255;
            tbName.Name = "tbName";
            tbName.Size = new Size(241, 23);
            tbName.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 212);
            label4.Name = "label4";
            label4.Size = new Size(61, 22);
            label4.TabIndex = 42;
            label4.Text = "Name*";
            // 
            // btRemoveLogo
            // 
            btRemoveLogo.BackColor = Color.Red;
            btRemoveLogo.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btRemoveLogo.ForeColor = Color.White;
            btRemoveLogo.Location = new Point(305, 136);
            btRemoveLogo.Name = "btRemoveLogo";
            btRemoveLogo.Size = new Size(76, 32);
            btRemoveLogo.TabIndex = 41;
            btRemoveLogo.Text = "Remove";
            btRemoveLogo.UseVisualStyleBackColor = false;
            // 
            // btChangeLogo
            // 
            btChangeLogo.BackColor = Color.FromArgb(0, 0, 192);
            btChangeLogo.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btChangeLogo.ForeColor = Color.White;
            btChangeLogo.Location = new Point(305, 87);
            btChangeLogo.Name = "btChangeLogo";
            btChangeLogo.Size = new Size(76, 32);
            btChangeLogo.TabIndex = 40;
            btChangeLogo.Text = "Change";
            btChangeLogo.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.ErrorImage = Properties.Resources.image_holder;
            pbLogo.Image = Properties.Resources.image_holder;
            pbLogo.InitialImage = Properties.Resources.image_holder;
            pbLogo.Location = new Point(140, 82);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 39;
            pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Kantumruy Pro", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(178, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(74, 28);
            lbTitle.TabIndex = 55;
            lbTitle.Text = "Create";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kantumruy Pro SemiBold", 11.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 428);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 56;
            label1.Text = "Location*";
            // 
            // tbLocation
            // 
            tbLocation.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbLocation.Location = new Point(140, 427);
            tbLocation.MaxLength = 255;
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(241, 23);
            tbLocation.TabIndex = 57;
            // 
            // CreateUpdateEvent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 513);
            Controls.Add(tbLocation);
            Controls.Add(label1);
            Controls.Add(lbTitle);
            Controls.Add(dtpEndTime);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartTime);
            Controls.Add(dtpStartDate);
            Controls.Add(cbCategory);
            Controls.Add(btSave);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(btRemoveLogo);
            Controls.Add(btChangeLogo);
            Controls.Add(pbLogo);
            Name = "CreateUpdateEvent";
            Text = "CreateUpdateEvent";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpEndTime;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartTime;
        private DateTimePicker dtpStartDate;
        private ComboBox cbCategory;
        private Button btSave;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private TextBox tbName;
        private Label label4;
        private Button btRemoveLogo;
        private Button btChangeLogo;
        private PictureBox pbLogo;
        private Label lbTitle;
        private OpenFileDialog ofdEventLogo;
        private Label label1;
        private TextBox tbLocation;
    }
}