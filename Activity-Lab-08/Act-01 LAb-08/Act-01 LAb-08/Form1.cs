using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Act_01_LAb_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //comboBox_country.Items.Add("Pakistan");
            //comboBox_country.Items.Add("India");
            //comboBox_country.Items.Add("Bangladesh");
            // comboBox_country.Items.Add("Nepal");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
         
            string Gender="", Hobby, Status = "";

          


            if (radioButton_Male.Checked)
            {
                
                Gender = "Male";
            }
            else if(radioButton_Female.Checked)
            {
                Gender = "Female";
            }

            if (checkBox_Read.Checked) Hobby = "Reading";
            else Hobby = "Painting";


            if (radioButton_married.Checked)
            {

                Status = "Married";
            }
            else if (radioButton_unmarried.Checked)
            {
                Status = "Unmarried";
            }

            try
            {
                Class1 myclass = new Class1();

                myclass.CheckCustomerName(textBox_Name.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            
                Form2 form2 = new Form2();

                form2.SetValues(textBox_Name.Text, comboBox_country.Text, Gender, Hobby, Status);
                form2.Show();
            

            
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadCustomer()
        {
            //open connection
            string strConnection = "Data Source=AUMC-LAB3-09\\SQLEXPRESS; initial Catalog=CustomerDB" + "Integrated Security=true";

            SqlConnection ObjConnection = new SqlConnection(strConnection);
            ObjConnection.Open();

            //Fire a Command

            string strCommand = "Select * From CustomerDetail";
            SqlCommand ObjCommand = new SqlCommand(strCommand, ObjConnection);

            //Bind Data with UI
            DataSet objDataSet=new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(ObjCommand);
            objAdapter.Fill(objDataSet);

            dtgCustomer.DataSource = objDataSet.Tables[0];


            //close Connectio
            ObjConnection.Close();
        }


    }
}
