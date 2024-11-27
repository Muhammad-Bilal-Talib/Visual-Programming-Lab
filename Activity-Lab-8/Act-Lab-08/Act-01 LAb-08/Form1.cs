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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Configuration;
//using DataAccess;

namespace Act_01_LAb_08
{
    public partial class Form1 : Form
    {
        string Gender = "", Hobby, Status = "", country;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadCustomer();
            comboBox_country.Items.Add("Pakistan");
            comboBox_country.Items.Add("India");
            comboBox_country.Items.Add("Bangladesh");
            comboBox_country.Items.Add("Nepal");
            combo_country.SelectedIndex = 0;
        }


        private bool data_validation()
        {

            try
            {
                Class1 myclass = new Class1();

                myclass.CheckCustomerName(textBox_Name.Text);
                myclass.checkGender(radioButton_Male, radioButton_Female);
                myclass.checkHobby(checkBox_Read, checkBox_Paint);
                myclass.checkStatus(radioButton_married, radioButton_unmarried);



                if (radioButton_Male.Checked)
                    Gender = radioButton_Male.Text;
                else
                    Gender = radioButton_Female.Text;

                if (checkBox_Read.Checked)
                    Hobby = "Reading";
                else
                    Hobby = "Painting";

                if (radioButton_married.Checked)
                    status = radioButton_married.Text;
                else
                    status = radioButton_unmarried.Text;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Validation", MessageBoxButtons.OK);
                return false;
            }
        }

        private void btn_preview_Click(object sender, EventArgs e)
        {
            if (data_validation())
            {
                Form2 form2 = new Form2();

                form2.SetValues(textBox_Name.Text,comboBox_country.Text, Gender, Hobby, Status);
                form2.ShowDialog();
            }
            
        }

        private void comboBox_country_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void loadCustomer()
        {
            //AUMC - LAB3 - 09\\SQLEXPRESS
            //open connection

            try
            {
                string strConnection = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS; initial Catalog=CustomerDB" + "Integrated Security=true";

                SqlConnection ObjConnection = new SqlConnection(strConnection);
                ObjConnection.Open();

                //Fire a Command

                string strCommand = "Select * From CustomerDetail";
                SqlCommand ObjCommand = new SqlCommand(strCommand, ObjConnection);

                //Bind Data with UI
                DataSet objDataSet = new DataSet();
                SqlDataAdapter objAdapter = new SqlDataAdapter(ObjCommand);
                objAdapter.Fill(objDataSet);

                dtgCustomer.DataSource = objDataSet.Tables[0];


                //close Connection
                ObjConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occur", MessageBoxButtons.OK);
            }



            //clsSqlServer obj = new clsSqlServer();            // declaring an object of clsSqlServer
            //DataSet ds = clsSqlServer.getCustomerData();     //getting all the data from database via DataAccess layer 
            //dtgCustomer.DataSource = ds.Tables[0];         //setting the datasource of your data grid
        }

        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            try {
                
            if (radioButton_Male.Checked) Gender = "Male";
            else Gender = "Female";
            if (checkBox_Read.Checked) Hobby = "Reading";
            else Hobby = "Painting";
            if (radioButton_married.Checked) Status = "1";
            else Status = "0";

            // Open a Connection
            string strConnection = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=CustomerDB;" + "Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            // Fire a Command
            string strCommand = "insert into CustomerTable values('" + textBox_Name.Text + "', '" + comboBox_country.Text + "','"
            + Gender + "', '"
            + Hobby + "', "
            + Status + " )";

            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            int affected_rows = objCommand.ExecuteNonQuery();

            if (affected_rows > 0)
            {
                MessageBox.Show("Customer Data Saved Successfully", "Successfull", MessageBoxButtons.OK);
            }
                // Close the Connection
                objConnection.Close();
                loadCustomer();
                clearForm();
        }
        catch(Exception ex)
        {
                MessageBox.Show(ex.Message, "Error Occur", MessageBoxButtons.OK);
        }
           
           
    }

        private void dtgCellClick(object sender, DataGridViewCellEventArgs e)
        {
            clearForm();
            string CustomerName = dtgCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            displayCustomer(CustomerName);
        }

        private void clearForm()
        {
            textBox_Name.Text = "";
            comboBox_country.Text = "";
            radioButton_Male.Checked = false;
            radioButton_Female.Checked = false;
            checkBox_Paint.Checked = false;
            checkBox_Read.Checked = false;
            radioButton_married.Checked = false;
            radioButton_unmarried.Checked = false;
        }

        private void displayCustomer(string strCustomer)
        {
            // Open a Connection
            string strConnection = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=CustomerDB;" + "Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();

            // Fire a Command
            string strCommand = "Select * From CustomerDetail where CustomerName = '" + strCustomer + "'";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);

            // Bind Data with UI
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);
            objConnection.Close();

            textBox_Name.Text = objDataSet.Tables[0].Rows[0][0].ToString();

            comboBox_country.Text = objDataSet.Tables[0].Rows[0][1].ToString();

            string Gender = objDataSet.Tables[0].Rows[0][2].ToString();

            if (Gender.Equals("Male")) radioButton_Male.Checked = true;
            else radioButton_Female.Checked = true;

            string Hobby = objDataSet.Tables[0].Rows[0][3].ToString();

            if (Hobby.Equals("Reading")) checkBox_Read.Checked = true;
            else checkBox_Paint.Checked = true;

            string Married = objDataSet.Tables[0].Rows[0][4].ToString();

            if (Married.Equals("True")) radioButton_married.Checked = true;
            else radioButton_unmarried.Checked = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                // Open a Connection
                string strConnection = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=CustomerDB;" + "Integrated Security=True";
                SqlConnection objConnection = new SqlConnection(strConnection);
                objConnection.Open();

                // Fire a Command
                string strCommand = "Delete from CustomerTable where CustomerName = '" + textBox_Name.Text + "'";
                SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
                objCommand.ExecuteNonQuery();

                // Close the Connection
                objConnection.Close();
                clearForm();
                loadCustomer();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error Occur", MessageBoxButtons.OK);
            }
        }
    }
}
