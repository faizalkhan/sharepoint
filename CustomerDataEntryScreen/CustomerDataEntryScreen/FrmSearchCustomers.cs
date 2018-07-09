using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace CustomerDataEntryScreen
{
    public partial class FrmSearchCustomers : Form
    {
        public FrmSearchCustomers()
        {
            InitializeComponent();
        }

        private void FrmSearchCustomers_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            // write some code which will fetch data
            // from SQL Server
           //Data Source = localhost; Initial Catalog = CustDb; Integrated Security = True; Pooling = False
            // open a connection
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();
            
            // Fire the command object
            // Command -- SQL - SQl server
            SqlCommand objCommand = new SqlCommand("Select * from CustomerTable", objConnection);
            DataSet objDataset = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);

            objAdapter.Fill(objDataset);

            // Bind the data to the UI
            dataGridView1.DataSource = objDataset.Tables[0];
            
            // Close the connection
            objConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //// create the object of the class
        //CommonCode obj = new CommonCode();
        //if (obj.CheckValidation(txtSearchCustomer.Text) == false)
        //{
        //    MessageBox.Show("Customer name is compulsory");
        //    return;
        //}
        //// here the executionwill not come if the customer name is 
        //// not entered
    }
}
