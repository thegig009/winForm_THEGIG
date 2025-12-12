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
                result = "น้ำหนักน้อย / ผอม : น้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย การรับประทานอาหารให้เพียงพอ และการออกกำลังกายเพื่อเสริมสร้างกล้ามเนื้อสามารถช่วยเพิ่มค่า BMI ให้อยู่ในเกณฑ์ปกติได้";
            else if (bmi < 23)
                result = "น้ำหนักปกติ : น้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-24 จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด และควรตรวจสุขภาพทุกปี";
            else if (bmi < 25)
                result = "น้ำหนักเกิน : อ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง ควรปรับพฤติกรรมการทานอาหาร ออกกำลังกาย และตรวจสุขภาพ";
            else if (bmi < 30)
                result = "อ้วน : ค่อนข้างอันตราย เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน หากค่า BMI อยู่ในระดับนี้ จะต้องปรับพฤติกรรมการทานอาหาร และควรเริ่มออกกำลังกาย และหากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น ควรไปตรวจสุขภาพ และปรึกษาแพทย์";
            else
                result = "อ้วนมาก  ";


            lblResult.Text = $"BMI = {bmi:F2}   ({result})";
        }
    }
}
