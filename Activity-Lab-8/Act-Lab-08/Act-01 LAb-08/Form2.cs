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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void SetValues(string Name,string country,string Gender,string Hobby,String Status)
        {
            label1_Name.Text = Name;
            label2_country.Text =country;
            label3_Gender.Text =Gender;
            label4_Hobby.Text =Hobby;
            label5_Status.Text =Status;

        }
    }
}
