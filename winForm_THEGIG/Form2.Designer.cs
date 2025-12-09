namespace winForm_THEGIG
{
    partial class BMI
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            btnCal = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblResult = new Label();
            txtHeight = new TextBox();
            txtWeight = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCal);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblResult);
            groupBox1.Controls.Add(txtHeight);
            groupBox1.Controls.Add(txtWeight);
            groupBox1.Location = new Point(71, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(909, 666);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(163, 554);
            label9.Name = "label9";
            label9.Size = new Size(166, 20);
            label9.TabIndex = 12;
            label9.Text = "ผอมเกินไป = น้อยกว่า 18.5";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(163, 508);
            label8.Name = "label8";
            label8.Size = new Size(207, 20);
            label8.TabIndex = 11;
            label8.Text = "น้ำหนักปกติ เหมาะสม = 18.6 - 24";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(163, 458);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 10;
            label7.Text = "อ้วน = 25.0 - 29.9";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 417);
            label1.Name = "label1";
            label1.Size = new Size(137, 20);
            label1.TabIndex = 9;
            label1.Text = "อ้วนมาก = 30.0 ขึ้นไป";
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.FromArgb(128, 255, 255);
            btnCal.ForeColor = SystemColors.ActiveCaptionText;
            btnCal.Location = new Point(163, 270);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(94, 29);
            btnCal.TabIndex = 8;
            btnCal.Text = "คำนวน";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(177, 97);
            label6.Name = "label6";
            label6.Size = new Size(162, 20);
            label6.TabIndex = 7;
            label6.Text = "อ้วนมากไปจนถึงผอมเกินไป";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(177, 63);
            label5.Name = "label5";
            label5.Size = new Size(473, 20);
            label5.TabIndex = 6;
            label5.Text = "และส่วนสูง (เซนติเมตร) ซึ่งสามารถระบุได้ว่า ตอนนี้รูปร่างของคนคนนั้นอยู่ในระดับใด";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(177, 32);
            label4.Name = "label4";
            label4.Size = new Size(374, 20);
            label4.TabIndex = 5;
            label4.Text = "ค่า BMI คือค่าดัชนีที่ใช้ชี้วัดความสมดุลของน้ำหนักตัว (กิโลกรัม)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 226);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "ส่วนสูง :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 165);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "น้ำหนัก :";
            // 
            // lblResult
            // 
            lblResult.Location = new Point(163, 320);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(388, 63);
            lblResult.TabIndex = 2;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(163, 219);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(321, 27);
            txtHeight.TabIndex = 1;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(163, 158);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(321, 27);
            txtWeight.TabIndex = 0;
            // 
            // BMI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 747);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "BMI";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtHeight;
        private TextBox txtWeight;
        private Label label3;
        private Label label2;
        private Label lblResult;
        private Label label4;
        private Button btnCal;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}