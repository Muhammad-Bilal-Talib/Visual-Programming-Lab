using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_05
{
    public partial class Form1 : Form
    {
        int a;
        int result = 1;
        //a=1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            a=int.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=1; i <=a; i++)
            {
                result = result*i;
            }

            textBox2.Text=result.ToString();
        }
    }
}
