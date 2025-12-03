namespace winForm_THEGIG
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            textBox4 = new TextBox();
            label6 = new Label();
            btngo = new Button();
            label5 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(621, 28);
            button1.Name = "button1";
            button1.Size = new Size(114, 30);
            button1.TabIndex = 0;
            button1.Text = "ทดสอบ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.DragLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(412, 30);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 2;
            label1.Text = "โปรดกรอกข้อความ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 94);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GrayText;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(104, 129);
            label3.Name = "label3";
            label3.Size = new Size(119, 105);
            label3.TabIndex = 4;
            label3.Text = "หลอดไฟ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(71, 247);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "เปิด";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(171, 247);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "ปิด";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 313);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(201, 145);
            textBox2.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 255, 128);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btngo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(412, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 311);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวนพืนที่สามเหลี่ยม";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 30);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(128, 255, 128);
            label6.Location = new Point(42, 140);
            label6.Name = "label6";
            label6.Size = new Size(363, 139);
            label6.TabIndex = 4;
            // 
            // btngo
            // 
            btngo.BackColor = Color.Silver;
            btngo.Location = new Point(333, 79);
            btngo.Name = "btngo";
            btngo.Size = new Size(94, 29);
            btngo.TabIndex = 3;
            btngo.Text = "Go";
            btngo.UseVisualStyleBackColor = false;
            btngo.Click += btngo_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(250, 82);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 2;
            label5.Text = "เชนติเมคร";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 82);
            label4.Name = "label4";
            label4.Size = new Size(81, 23);
            label4.TabIndex = 1;
            label4.Text = "รัศมีวงกลม";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 529);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "THEGIG";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            MouseClick += Form1_MouseClick;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox textBox3;
        private Label label6;
        private Button btngo;
        private Label label5;
        private TextBox textBox4;
    }
}
