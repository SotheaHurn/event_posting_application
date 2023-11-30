namespace EventWindow
{
    partial class HomepageEventCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            lbTitle = new Label();
            lbDate = new Label();
            lbLocation = new Label();
            btLike = new Button();
            btComments = new Button();
            lbLikes = new Label();
            lbComments = new Label();
            tbComment = new TextBox();
            btSend = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.ErrorImage = Properties.Resources.image_holder;
            pbLogo.Image = Properties.Resources.image_holder;
            pbLogo.InitialImage = Properties.Resources.image_holder;
            pbLogo.Location = new Point(15, 19);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(90, 90);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Kantumruy Pro Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(121, 14);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(49, 23);
            lbTitle.TabIndex = 13;
            lbTitle.Text = "Title";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(121, 52);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(37, 19);
            lbDate.TabIndex = 14;
            lbDate.Text = "Date";
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lbLocation.Location = new Point(121, 97);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(62, 19);
            lbLocation.TabIndex = 15;
            lbLocation.Text = "Location";
            // 
            // btLike
            // 
            btLike.BackColor = Color.FromArgb(0, 0, 192);
            btLike.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btLike.ForeColor = Color.White;
            btLike.Location = new Point(490, 19);
            btLike.Name = "btLike";
            btLike.Size = new Size(96, 32);
            btLike.TabIndex = 16;
            btLike.Text = "Likes";
            btLike.UseVisualStyleBackColor = false;
            // 
            // btComments
            // 
            btComments.BackColor = Color.MediumAquamarine;
            btComments.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btComments.ForeColor = Color.White;
            btComments.Location = new Point(601, 19);
            btComments.Name = "btComments";
            btComments.Size = new Size(96, 32);
            btComments.TabIndex = 17;
            btComments.Text = "Comments";
            btComments.UseVisualStyleBackColor = false;
            // 
            // lbLikes
            // 
            lbLikes.AutoSize = true;
            lbLikes.Enabled = false;
            lbLikes.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbLikes.Location = new Point(524, 54);
            lbLikes.Name = "lbLikes";
            lbLikes.Size = new Size(20, 21);
            lbLikes.TabIndex = 18;
            lbLikes.Text = "0";
            // 
            // lbComments
            // 
            lbComments.AutoSize = true;
            lbComments.Font = new Font("Kantumruy Pro Medium", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbComments.Location = new Point(640, 54);
            lbComments.Name = "lbComments";
            lbComments.Size = new Size(20, 21);
            lbComments.TabIndex = 19;
            lbComments.Text = "0";
            // 
            // tbComment
            // 
            tbComment.Font = new Font("Kantumruy Pro", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbComment.Location = new Point(490, 86);
            tbComment.MaxLength = 255;
            tbComment.Name = "tbComment";
            tbComment.PlaceholderText = "Comment";
            tbComment.Size = new Size(150, 23);
            tbComment.TabIndex = 20;
            // 
            // btSend
            // 
            btSend.BackColor = Color.FromArgb(0, 0, 192);
            btSend.Font = new Font("Kantumruy Pro SemiBold", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btSend.ForeColor = Color.White;
            btSend.Location = new Point(646, 85);
            btSend.Name = "btSend";
            btSend.Size = new Size(51, 26);
            btSend.TabIndex = 21;
            btSend.Text = "Send";
            btSend.UseVisualStyleBackColor = false;
            // 
            // HomepageEventCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(btSend);
            Controls.Add(tbComment);
            Controls.Add(lbComments);
            Controls.Add(lbLikes);
            Controls.Add(btComments);
            Controls.Add(btLike);
            Controls.Add(lbLocation);
            Controls.Add(lbDate);
            Controls.Add(lbTitle);
            Controls.Add(pbLogo);
            Name = "HomepageEventCard";
            Size = new Size(708, 127);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lbTitle;
        private Label lbDate;
        private Label lbLocation;
        private Button btLike;
        private Button btComments;
        private Label lbLikes;
        private Label lbComments;
        private TextBox tbComment;
        private Button btSend;
    }
}
