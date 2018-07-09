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
using System.Data.Sql;

namespace CustomerDataEntryScreen
{
    public partial class frmCustomerDataEntryScreen : Form
    {
        public frmCustomerDataEntryScreen()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {



            // create the object of the class
            CommonCode obj = new CommonCode();
            if (obj.CheckValidation(txtCustomerName.Text) == false)
            {
                MessageBox.Show("Customer name is compulsory");
                return;
            }
            String gender = "";
            String hobbies = "";
            String Status = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "FeMale";
            }

            if (chkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            if (radioMarried.Checked)
            {
                Status = "0";

            }
            else
            {
                Status = "1";

            }

            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();

            SqlConnection ObjConnection = new SqlConnection(ConnectionString);

            ObjConnection.Open();


            //SqlCommand ObjCommand = new SqlCommand("Select * from CustomerTable");

            string strInsertCommand = "insert into CustomerTable values('"
                                              + txtCustomerName.Text + "' ,'"
                                              + cmbCountries.Text + "' , '"
                                              + gender + "' , '"
                                              + hobbies + "' , "
                                              + Status + ")";



            SqlCommand objCommand = new SqlCommand(strInsertCommand, ObjConnection);

            objCommand.ExecuteNonQuery();

            ObjConnection.Close();

            Loadcustomer();
            ClearData();
        }
        //    FrmpreviewCustomer objs = new FrmpreviewCustomer();
        //   objs.SetValues(txtCustomerName.Text,
        //                cmbCountries.Text.ToString(),
        //               gender,
        //                hobbies,
        //                Status);
        //  objs.ShowDialog();
        //}

        private void frmCustomerDataEntryScreen_Load(object sender, EventArgs e)
        {

            Loadcustomer();
        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {


            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();

            SqlCommand objCommand = new SqlCommand("delete from CustomerTable where CustomerName = '" + txtCustomerName.Text + "'", objConnection);


            objCommand.ExecuteNonQuery();

            objConnection.Close();


            Loadcustomer();

            ClearData();

        }

        private void Loadcustomer()
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();

            SqlCommand objCommand = new SqlCommand("select * from CustomerTable", objConnection);
            DataSet objdataset = new DataSet();
            SqlDataAdapter objadapter = new SqlDataAdapter(objCommand);

            objadapter.Fill(objdataset);


            dataGridView1.DataSource = objdataset.Tables[0];

            objConnection.Close();
        }
    
        private void DisplayCustomer(string CustomerNames)
        {
            string Connectionstring = ConfigurationManager.ConnectionStrings["DbConn"].ToString();
            SqlConnection objConnection = new SqlConnection(Connectionstring);
            objConnection.Open();

            SqlCommand objCommand = new SqlCommand("select * from CustomerTable where CustomerName = '" + CustomerNames + "'", objConnection);
            DataSet objdataset = new DataSet();
            SqlDataAdapter objadapter = new SqlDataAdapter(objCommand);

            objadapter.Fill(objdataset);


            string StrCustomerName = objdataset.Tables[0].Rows[0][0].ToString();
            string StrCountry = objdataset.Tables[0].Rows[0][1].ToString();
            string StrGender = objdataset.Tables[0].Rows[0][2].ToString();
            string StrHobbies = objdataset.Tables[0].Rows[0][3].ToString();
            bool Married = false;

            if(objdataset.Tables[0].Rows[0][4] != DBNull.Value)
            {
               Married = Convert.ToBoolean(objdataset.Tables[0].Rows[0][4].ToString());
            }
            txtCustomerName.Text = StrCustomerName;
            cmbCountries.Text = StrCountry;

            if((StrGender.Length == 0) || (StrGender == "Male"))
            {
                radioMale.Checked = true;
            }
            else
            {
                radioFemale.Checked = true;
            }
            if(StrHobbies == "Reading   ")
            {
                chkPainting.Checked = false;
                chkReading.Checked = true;
            }
            else
            {
                chkReading.Checked = false;
                chkPainting.Checked = true;
            }

            if(Married)
            {

                radioMarried.Checked = true;

            }

            else
            {
                radioUnmarried.Checked = true;
            }

            objConnection.Close();

        }

        private void dtg_customerCellClick(object sender, DataGridViewCellEventArgs e)
        {
            string strCustomerNames = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            DisplayCustomer(strCustomerNames);

        }
        private void ClearData()
        {
            txtCustomerName.Text = "";
            cmbCountries.Text = "";
            radioMarried.Checked = false;
            radioUnmarried.Checked = false;
            chkReading.Checked = false;
            chkPainting.Checked = false;
            radioMale.Checked = false;
            radioFemale.Checked = false;
        }
        private void Updatedata_Click(object sender, EventArgs e)
        {
            // create the object of the class
       
            String gender = "";
            String hobbies = "";
            String Status = "";
            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "FeMale";
            }

            if (chkPainting.Checked)
            {
                hobbies = "Painting";
            }
            else
            {
                hobbies = "Reading";
            }
            if (radioMarried.Checked)
            {
                Status = "0";

            }
            else
            {
                Status = "1";

            }

            string ConnectionString = ConfigurationManager.ConnectionStrings["DbConn"].ToString();

            SqlConnection ObjConnection = new SqlConnection(ConnectionString);

            ObjConnection.Open();


            //SqlCommand ObjCommand = new SqlCommand("Select * from CustomerTable");

            string strUpdateCommand = "update CustomerTable set CustomerName = '"
                                              + txtCustomerName.Text + "',Country='"
                                              + cmbCountries.Text + "' , Gender='"
                                              + gender + "' , Hobbies= '"
                                              + hobbies + "' ,Married ="
                                              + Status + "where CustomerName ='" + txtCustomerName.Text + "'";



            SqlCommand objCommand = new SqlCommand(strUpdateCommand, ObjConnection);

            objCommand.ExecuteNonQuery();

            ObjConnection.Close();

            Loadcustomer();

            ClearData();
        }
    }
}
