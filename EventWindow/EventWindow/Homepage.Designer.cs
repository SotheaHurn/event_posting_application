using EventLib;

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
            pbProfile = new PictureBox();
            lbName = new Label();
            lbPhone = new Label();
            btViewAccount = new Label();
            btRefresh = new Button();
            dtpDate = new DateTimePicker();
            btClear = new Button();
            cbCategory = new ComboBox();
            tbUsername = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flpListEvent = new FlowLayoutPanel();
            btMyEvents = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AKbalthom HighSchool", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(-2, -2);
            label1.Name = "label1";
            label1.Size = new Size(146, 76);
            label1.TabIndex = 2;
            label1.Text = "Event Posting \r\n  Application";
            // 
            // pbProfile
            // 
            pbProfile.ErrorImage = Properties.Resources.profile_holder;
            pbProfile.Image = Properties.Resources.profile_holder;
            pbProfile.InitialImage = Properties.Resources.profile_holder;
            pbProfile.Location = new Point(547, 12);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(70, 70);
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfile.TabIndex = 4;
            pbProfile.TabStop = false;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Kantumruy Pro Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.Location = new Point(644, 22);
            lbName.Name = "lbName";
            lbName.Size = new Size(89, 23);
            lbName.TabIndex = 5;
            lbName.Text = "Unknown";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Kantumruy Pro Medium", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbPhone.Location = new Point(644, 56);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(91, 19);
            lbPhone.TabIndex = 6;
            lbPhone.Text = "0123456789";
            // 
            // btViewAccount
            // 
            btViewAccount.AutoSize = true;
            btViewAccount.Font = new Font("Kantumruy Pro Medium", 8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btViewAccount.ForeColor = Color.FromArgb(0, 0, 192);
            btViewAccount.Location = new Point(758, 58);
            btViewAccount.Name = "btViewAccount";
            btViewAccount.Size = new Size(88, 16);
            btViewAccount.TabIndex = 7;
            btViewAccount.Text = "View Account";
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.FromArgb(0, 0, 192);
            btRefresh.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btRefresh.ForeColor = Color.White;
            btRefresh.Location = new Point(48, 130);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(96, 32);
            btRefresh.TabIndex = 7;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "dd MMMM yyyy";
            dtpDate.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(12, 305);
            dtpDate.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtpDate.MinDate = new DateTime(2015, 1, 1, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(179, 23);
            dtpDate.TabIndex = 8;
            dtpDate.Value = new DateTime(2023, 11, 29, 0, 0, 0, 0);
            // 
            // btClear
            // 
            btClear.BackColor = Color.Red;
            btClear.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btClear.ForeColor = Color.White;
            btClear.Location = new Point(48, 494);
            btClear.Name = "btClear";
            btClear.Size = new Size(96, 32);
            btClear.TabIndex = 9;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Kantumruy Pro", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "None", "Charity", "Concerts", "Parties", "Sports", "Conferences", "Exhibitions", "Workshops", "Festivals", "Meetups", "Fundraisers", "Classes", "Comedy Shows", "Theater And Plays", "Movies And Screenings", "Gaming", "Food And Drink", "Art And Culture", "Outdoor Activities", "Tech And Innovation", "Health And Wellness" });
            cbCategory.Location = new Point(12, 389);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(179, 26);
            cbCategory.TabIndex = 10;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(12, 215);
            tbUsername.MaxLength = 255;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(179, 23);
            tbUsername.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 191);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 12;
            label2.Text = "Search";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 271);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 13;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 365);
            label4.Name = "label4";
            label4.Size = new Size(69, 21);
            label4.TabIndex = 14;
            label4.Text = "Category";
            // 
            // flpListEvent
            // 
            flpListEvent.AutoScroll = true;
            flpListEvent.Location = new Point(208, 90);
            flpListEvent.Name = "flpListEvent";
            flpListEvent.Size = new Size(744, 467);
            flpListEvent.TabIndex = 15;
            // 
            // btMyEvents
            // 
            btMyEvents.AutoSize = true;
            btMyEvents.Font = new Font("Kantumruy Pro Medium", 8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btMyEvents.ForeColor = Color.Red;
            btMyEvents.Location = new Point(864, 58);
            btMyEvents.Name = "btMyEvents";
            btMyEvents.Size = new Size(68, 16);
            btMyEvents.TabIndex = 16;
            btMyEvents.Text = "My Events";
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(952, 558);
            Controls.Add(btMyEvents);
            Controls.Add(btRefresh);
            Controls.Add(dtpDate);
            Controls.Add(flpListEvent);
            Controls.Add(btClear);
            Controls.Add(btViewAccount);
            Controls.Add(cbCategory);
            Controls.Add(lbPhone);
            Controls.Add(tbUsername);
            Controls.Add(lbName);
            Controls.Add(label2);
            Controls.Add(pbProfile);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label4);
            Name = "Homepage";
            RightToLeftLayout = true;
            Text = "Event Posting Application";
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbProfile;
        private Label lbName;
        private Label lbPhone;
        private Label btViewAccount;
        private Button btRefresh;
        private DateTimePicker dtpDate;
        private Button btClear;
        private ComboBox cbCategory;
        private TextBox tbUsername;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flpListEvent;
        private Label btMyEvents;
    }
}