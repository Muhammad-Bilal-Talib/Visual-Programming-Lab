using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_06
{
    public partial class Form1 : Form
    {
        private Timer timer;
        int sec_t;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sec_t>0)
            {
                sec_t--;
                label3.Text = $"{sec_t} Seconds";

            }
            else
            {
                timer1.Stop();

                MessageBox.Show("Time Over!","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                label3.Text = " 0 Seconds";
            }
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = $"{sec_t} Seconds";
            timer1_Tick(sender, e);
            timer1.Start();
        }


        private void sec_time_ValueChanged(object sender, EventArgs e)
        {
            sec_t = (int)sec_time.Value;
        }




    }
}
