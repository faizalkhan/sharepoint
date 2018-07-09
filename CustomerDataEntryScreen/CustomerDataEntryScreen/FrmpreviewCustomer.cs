using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomerDataEntryScreen
{
    public partial class FrmpreviewCustomer : Form
    {
        public FrmpreviewCustomer()
        {
            InitializeComponent();
        }

        private void FrmpreviewCustomer_Load(object sender, EventArgs e)
        {

        }

        public void SetValues(string CustomerName, 
                              string CountryName, 
                              string gender, 
                              string hobbies, string status)
        {
            lblCustomerData.Text = CustomerName;
            lblCountryNamedata.Text = CountryName;
            lblGenderData.Text = gender;
            lblHobbiesData.Text = hobbies;
            lblStatusData.Text = status;
        }
    }
}
