using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act_01_LAb_08
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void enterCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            obj1.ShowDialog();
        }
    }
}
