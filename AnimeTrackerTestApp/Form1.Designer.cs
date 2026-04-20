namespace AnimeTrackerTestApp
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
            lbList = new ListBox();
            lblName = new Label();
            txtName = new TextBox();
            lblList = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbList
            // 
            lbList.FormattingEnabled = true;
            lbList.Location = new Point(533, 69);
            lbList.Name = "lbList";
            lbList.Size = new Size(498, 564);
            lbList.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(68, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(497, 27);
            txtName.TabIndex = 2;
            // 
            // lblList
            // 
            lblList.AutoSize = true;
            lblList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblList.Location = new Point(533, 38);
            lblList.Name = "lblList";
            lblList.Size = new Size(45, 28);
            lblList.TabIndex = 3;
            lblList.Text = "List";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(322, 102);
            button1.Name = "button1";
            button1.Size = new Size(187, 46);
            button1.TabIndex = 4;
            button1.Text = "Add to list";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(button1);
            Controls.Add(lblList);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(lbList);
            MaximumSize = new Size(1080, 720);
            MinimumSize = new Size(1080, 720);
            Name = "Form1";
            Text = "Test Tracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbList;
        private Label lblName;
        private TextBox txtName;
        private Label lblList;
        private Button button1;
    }
}
