using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = $" Number                 Square" + Environment.NewLine + Environment.NewLine;
            for (int i = 1; i <= 10; i++)
            {
                int square = CalculateSquare(i);
                if (i == 10)
                {
                    textBox1.Text += $"{i}                          {square}" + Environment.NewLine;
                }
                else
                {
                    textBox1.Text += $"{i}                            {square}" + Environment.NewLine;
                }
                
            }
        }

        private int CalculateSquare(int number)
        {
            return number * number;
        }
    }
}

