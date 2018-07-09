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
    public partial class ArrayWindowScreen : Form
    {
        string[] str = new string[10];
        int[] i;
        public ArrayWindowScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            for(int i=0; i<str.Length; i++)
            {
            
                if(str[i] == null)
                {
                    if (textBox1.Text.Length == 0 && textBox1.Text == "" )
                    {
                        MessageBox.Show("array should not empty");
                        break;
                    }
                    else
                    {
                        str[i] = textBox1.Text;
                        break;
                    }
                      
                }
                          
            }
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox1.DataSource = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
    }
}
