using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winForm_THEGIG
{
    public partial class BMI : Form
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {



            double weight, height, bmi;


            if (!double.TryParse(txtWeight.Text, out weight))
            {
                MessageBox.Show("กรุณากรอกน้ำหนักเป็นตัวเลข");
                return;
            }

            if (!double.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("กรุณากรอกส่วนสูงเป็นตัวเลข");
                return;
            }


            height = height / 100;


            bmi = weight / (height * height);


            string result = "";
            if (bmi < 18.5)
                result = "น้ำหนักน้อย / ผอม";
            else if (bmi < 23)
                result = "น้ำหนักปกติ";
            else if (bmi < 25)
                result = "น้ำหนักเกิน";
            else if (bmi < 30)
                result = "อ้วน";
            else
                result = "อ้วนมาก";

            
            lblResult.Text = $"BMI = {bmi:F2}   ({result})";
        }
    }
}

