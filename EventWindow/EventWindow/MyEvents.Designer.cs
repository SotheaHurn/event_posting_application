namespace EventWindow
{
    partial class MyEvents
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
            label3 = new Label();
            flpListEvent = new FlowLayoutPanel();
            btCreate = new Button();
            btRefresh = new Button();
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
            label1.TabIndex = 3;
            label1.Text = "Event Posting \r\n  Application";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Kantumruy Pro Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(294, 52);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 14;
            label3.Text = "My Events";
            // 
            // flpListEvent
            // 
            flpListEvent.AutoScroll = true;
            flpListEvent.Location = new Point(12, 90);
            flpListEvent.Name = "flpListEvent";
            flpListEvent.Size = new Size(794, 484);
            flpListEvent.TabIndex = 39;
            // 
            // btCreate
            // 
            btCreate.BackColor = Color.FromArgb(0, 0, 192);
            btCreate.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btCreate.ForeColor = Color.White;
            btCreate.Location = new Point(684, 52);
            btCreate.Name = "btCreate";
            btCreate.Size = new Size(96, 32);
            btCreate.TabIndex = 40;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = false;
            // 
            // btRefresh
            // 
            btRefresh.BackColor = Color.Red;
            btRefresh.Font = new Font("Kantumruy Pro SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            btRefresh.ForeColor = Color.White;
            btRefresh.Location = new Point(568, 52);
            btRefresh.Name = "btRefresh";
            btRefresh.Size = new Size(96, 32);
            btRefresh.TabIndex = 41;
            btRefresh.Text = "Refresh";
            btRefresh.UseVisualStyleBackColor = false;
            // 
            // MyEvents
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 579);
            Controls.Add(btRefresh);
            Controls.Add(btCreate);
            Controls.Add(flpListEvent);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "MyEvents";
            Text = "Event Posting Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private FlowLayoutPanel flpListEvent;
        private Button btCreate;
        private Button btRefresh;
    }
}