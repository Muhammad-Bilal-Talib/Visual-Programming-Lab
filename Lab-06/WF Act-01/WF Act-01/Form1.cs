using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Act_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Focus();
            comboBox1.Items.Add("Day");
            comboBox1.Items.Add("Month");
            comboBox1.Items.Add("Year");
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void greetbutton_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox1.Text))
            {
                messagelabel.Text = $"Hello, {textBox1.Text} Welcome!";

            }
            else
            {
                messagelabel.Text = $"Please Enter Your Name!";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
               

                foreach (int i in arr)
                {
                    comboBox2.Items.Add(i);
                } 
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                int[] arr1 = {1,2,3,4,5,6,7,8,9,10,11,12};

                foreach (int i in arr1)
                {
                    comboBox2.Items.Add(i);
                }
            }

            else
            {
                comboBox2.Items.Clear();
                int[] arr2 = {2020,2021,2022,2023,2024};

                foreach (int i in arr2)
                {
                    comboBox2.Items.Add(i);
                }
            }
        }
    }
}
