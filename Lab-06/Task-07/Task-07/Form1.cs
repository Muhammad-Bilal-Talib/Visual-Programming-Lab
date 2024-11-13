using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Get current date and time
            DateTime now = DateTime.Now;

            // Format the date and time as desired
            string formattedDate = now.ToString("dddd, MMMM dd, yyyy");
            string formattedTime = now.ToString("hh:mm:ss tt");

            // Display the formatted date and time in a label
            label1.Text = $"{formattedDate}" +Environment.NewLine+ Environment.NewLine + $"{formattedTime}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
