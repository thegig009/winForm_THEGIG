using System.Security.Cryptography.Xml;

namespace winForm_THEGIG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to THEGIG!", "hello");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye from THEGIG!", "bye");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White; button1.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
            label2.Text = textBox1.Text.Length.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.Yellow;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label3.BackColor = Color.Black;
        }

        private void btngo_Click(object sender, EventArgs e)
        {
            double radius = 0.0;
            double area = 0.0;
            double circumference = 0.0;
            if (double.TryParse(textBox4.Text, out radius))
            {
                area = Math.PI * radius * radius;
                circumference = 2 * Math.PI * radius;
                label6.Text = $"พื้นที่วงกลมมีค่าเท่ากับ {area:F2}" + Environment.NewLine +
                               $"เส้นรอบวงมีค่าเท่ากับ {circumference:F2}";
            }
            else
            {
                MessageBox.Show("กรุณาใส่ค่ารัศมีที่ถูกต้อง", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
			
		
			double baseLength, height;

			// ตรวจสอบความยาวฐาน
			if (!double.TryParse(textBox3.Text.Trim(), out baseLength) || baseLength <= 0)
			{
				MessageBox.Show("ความยาวฐานต้องเป็นตัวเลขและ > 0");
				return;
			}

			// ตรวจสอบความสูง
			if (!double.TryParse(textBox5.Text.Trim(), out height) || height <= 0)
			{
				MessageBox.Show("ความสูงต้องเป็นตัวเลขและ > 0");
				return;
			}

			// คำนวณพื้นที่สามเหลี่ยม
			double area = 0.5 * baseLength * height;

			// แสดงผล (เลือก label ของคุณ เช่น label8)
			label9.Text = "พื้นที่สามเหลี่ยม = " + area.ToString("0.##");
		}


	}
}

