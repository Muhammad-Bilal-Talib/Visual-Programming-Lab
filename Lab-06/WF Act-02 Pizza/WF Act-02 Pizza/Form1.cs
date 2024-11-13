using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WF_Act_02_Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Focus();
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Medium");
            comboBox1.Items.Add("Large");
            comboBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void order_button_Click(object sender, EventArgs e)
        {
            string combo_item= "";

            detail_label1.Text = $"Customer Name: {txtbox_name.Text}\n";


            if(comboBox1.SelectedIndex==0)
            {
                combo_item = "Small";
                detail_label2.Text = $"Pizza Size: {combo_item}\n";
            }
            else if(comboBox1.SelectedIndex == 1)
            {
                combo_item = "Medium";
                detail_label2.Text = $"Pizza Size: {combo_item}\n";
            }
            else
            {
                combo_item = "Large";
                detail_label2.Text = $"Pizza Size: {combo_item}\n";
            }


            if(checkBox1.Checked = true)
            {
                detail_label3.Text = $"Pizza Flavour: {checkBox1.Text}\n";
            }
            else if(checkBox2.Checked = true)
            {
                detail_label3.Text = $"Pizza Flavour: {checkBox2.Text}\n";
            }
            else
            {
                detail_label3.Text = $"Pizza Flavour: {checkBox3.Text}\n";
            }



            if (radioButton1.Checked = true)
            {
                detail_label4.Text = $"Crust Type: {radioButton1.Text}\n";
            }

            if(radioButton2.Checked = true)
            {
                detail_label4.Text = $"Crust Type: {radioButton2.Text}\n";
            }

        }

        private void detail_label_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void detail_label3_Click(object sender, EventArgs e)
        {

        }
    }
}
