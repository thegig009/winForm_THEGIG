namespace winForm_THEGIG
{
    partial class Form3
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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(487, 147);
            button1.Name = "button1";
            button1.Size = new Size(151, 46);
            button1.TabIndex = 0;
            button1.Text = "คำนวน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 147);
            label1.Name = "label1";
            label1.Size = new Size(284, 431);
            label1.TabIndex = 1;
            label1.Text = "เเสดงผล";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 615);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Jagged Array";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
    }
}