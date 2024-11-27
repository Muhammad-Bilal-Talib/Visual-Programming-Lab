using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class clsSqlServer
    {
        public DataSet getCustomerData()
        {
            string strConnection = "Data Source=DESKTOP-8BL3MIG\\SQLEXPRESS;Initial Catalog=CustomerDB;" + "Integrated Security=True";
            SqlConnection objConnection = new SqlConnection(strConnection);
            objConnection.Open();
            SqlCommand objCommand = new SqlCommand("select * from CustomerTable", objConnection);
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            DataSet ds = new DataSet();
            objAdapter.Fill(ds);
            return ds;
        }
    }
}
