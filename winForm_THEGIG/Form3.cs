using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace winForm_THEGIG
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			int[][] MyArr = new int[][]
	{
		new int[] {1, 3, 5, 7, 9},
		new int[] {0, 2, 4, 6},
		new int[] {11, 22}
	};

			label1.Text = "";   // เคลียร์ข้อความเดิม

			for (int i = 0; i < MyArr.Length; i++)
			{
				int sum = 0;

				for (int j = 0; j < MyArr[i].Length; j++)
				{
					label1.Text += MyArr[i][j] + " ";
					sum += MyArr[i][j];
				}

				label1.Text += Environment.NewLine;
				label1.Text += "Sum = " + sum + Environment.NewLine;
				label1.Text += "---end---" + Environment.NewLine;
			}
		}
    }
}
