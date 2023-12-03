namespace EventWindow
{
    partial class MyEventCard
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
            lbLocation = new Label();
            lbDate = new Label();
            lbTitle = new Label();
            pbLogo = new PictureBox();
            btDelete = new Button();
            btUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lbLocation.Location = new Point(122, 94);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(62, 19);
            lbLocation.TabIndex = 19;
            lbLocation.Text = "Location";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Kantumruy Pro", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(122, 49);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(37, 19);
            lbDate.TabIndex = 18;
            lbDate.Text = "Date";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Kantumruy Pro Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(122, 11);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(49, 23);
            lbTitle.TabIndex = 17;
            lbTitle.Text = "Title";
            // 
            // pbLogo
            // 
            pbLogo.ErrorImage = Properties.Resources.image_holder;
            pbLogo.Image = Properties.Resources.image_holder;
            pbLogo.InitialImage = Properties.Resources.image_holder;
            pbLogo.Location = new Point(16, 16);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(90, 90);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 16;
            pbLogo.TabStop = false;
            // 
            // btDelete
            // 
            btDelete.BackColor = Color.Red;
            btDelete.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btDelete.ForeColor = Color.White;
            btDelete.Location = new Point(655, 74);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(67, 32);
            btDelete.TabIndex = 23;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = false;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.FromArgb(0, 0, 192);
            btUpdate.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btUpdate.ForeColor = Color.White;
            btUpdate.Location = new Point(655, 25);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(67, 32);
            btUpdate.TabIndex = 22;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = false;
            // 
            // MyEventCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(btDelete);
            Controls.Add(btUpdate);
            Controls.Add(lbLocation);
            Controls.Add(lbDate);
            Controls.Add(lbTitle);
            Controls.Add(pbLogo);
            Name = "MyEventCard";
            Size = new Size(750, 127);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLocation;
        private Label lbDate;
        private Label lbTitle;
        private PictureBox pbLogo;
        private Button btDelete;
        private Button btUpdate;
    }
}
