using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateCharacterCount();
        }   

            private void updateCharacterCount()
            {
                int remainingChars = 160 - textBox1.TextLength;
                label2.Text = $"{remainingChars}";

            if (remainingChars <= 0)
            {
                MessageBox.Show("Character Space Finish!","Space",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            }
        }
    }

