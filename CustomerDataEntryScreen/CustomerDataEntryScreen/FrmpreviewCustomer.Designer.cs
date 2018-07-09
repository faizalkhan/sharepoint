namespace CustomerDataEntryScreen
{
    partial class FrmpreviewCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerData = new System.Windows.Forms.Label();
            this.lblCountryNamedata = new System.Windows.Forms.Label();
            this.lblCountryName = new System.Windows.Forms.Label();
            this.lblGenderData = new System.Windows.Forms.Label();
            this.lblGenderName = new System.Windows.Forms.Label();
            this.lblHobbiesData = new System.Windows.Forms.Label();
            this.lblHobbiesName = new System.Windows.Forms.Label();
            this.lblStatusData = new System.Windows.Forms.Label();
            this.lblStatusName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 3);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // lblCustomerData
            // 
            this.lblCustomerData.AutoSize = true;
            this.lblCustomerData.Location = new System.Drawing.Point(109, 7);
            this.lblCustomerData.Name = "lblCustomerData";
            this.lblCustomerData.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerData.TabIndex = 1;
            // 
            // lblCountryNamedata
            // 
            this.lblCountryNamedata.AutoSize = true;
            this.lblCountryNamedata.Location = new System.Drawing.Point(109, 34);
            this.lblCountryNamedata.Name = "lblCountryNamedata";
            this.lblCountryNamedata.Size = new System.Drawing.Size(0, 13);
            this.lblCountryNamedata.TabIndex = 3;
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountryName.Location = new System.Drawing.Point(3, 30);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(74, 13);
            this.lblCountryName.TabIndex = 2;
            this.lblCountryName.Text = "Country Name";
            // 
            // lblGenderData
            // 
            this.lblGenderData.AutoSize = true;
            this.lblGenderData.Location = new System.Drawing.Point(109, 67);
            this.lblGenderData.Name = "lblGenderData";
            this.lblGenderData.Size = new System.Drawing.Size(0, 13);
            this.lblGenderData.TabIndex = 5;
            // 
            // lblGenderName
            // 
            this.lblGenderName.AutoSize = true;
            this.lblGenderName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGenderName.Location = new System.Drawing.Point(3, 63);
            this.lblGenderName.Name = "lblGenderName";
            this.lblGenderName.Size = new System.Drawing.Size(25, 13);
            this.lblGenderName.TabIndex = 4;
            this.lblGenderName.Text = "Sex";
            // 
            // lblHobbiesData
            // 
            this.lblHobbiesData.AutoSize = true;
            this.lblHobbiesData.Location = new System.Drawing.Point(109, 102);
            this.lblHobbiesData.Name = "lblHobbiesData";
            this.lblHobbiesData.Size = new System.Drawing.Size(0, 13);
            this.lblHobbiesData.TabIndex = 7;
            // 
            // lblHobbiesName
            // 
            this.lblHobbiesName.AutoSize = true;
            this.lblHobbiesName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHobbiesName.Location = new System.Drawing.Point(3, 98);
            this.lblHobbiesName.Name = "lblHobbiesName";
            this.lblHobbiesName.Size = new System.Drawing.Size(46, 13);
            this.lblHobbiesName.TabIndex = 6;
            this.lblHobbiesName.Text = "Hobbies";
            // 
            // lblStatusData
            // 
            this.lblStatusData.AutoSize = true;
            this.lblStatusData.Location = new System.Drawing.Point(109, 137);
            this.lblStatusData.Name = "lblStatusData";
            this.lblStatusData.Size = new System.Drawing.Size(0, 13);
            this.lblStatusData.TabIndex = 9;
            // 
            // lblStatusName
            // 
            this.lblStatusName.AutoSize = true;
            this.lblStatusName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatusName.Location = new System.Drawing.Point(3, 133);
            this.lblStatusName.Name = "lblStatusName";
            this.lblStatusName.Size = new System.Drawing.Size(37, 13);
            this.lblStatusName.TabIndex = 8;
            this.lblStatusName.Text = "Status";
            // 
            // FrmpreviewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 160);
            this.Controls.Add(this.lblStatusData);
            this.Controls.Add(this.lblStatusName);
            this.Controls.Add(this.lblHobbiesData);
            this.Controls.Add(this.lblHobbiesName);
            this.Controls.Add(this.lblGenderData);
            this.Controls.Add(this.lblGenderName);
            this.Controls.Add(this.lblCountryNamedata);
            this.Controls.Add(this.lblCountryName);
            this.Controls.Add(this.lblCustomerData);
            this.Controls.Add(this.lblCustomerName);
            this.Name = "FrmpreviewCustomer";
            this.Text = "Preview Customer";
            this.Load += new System.EventHandler(this.FrmpreviewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerData;
        private System.Windows.Forms.Label lblCountryNamedata;
        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.Label lblGenderData;
        private System.Windows.Forms.Label lblGenderName;
        private System.Windows.Forms.Label lblHobbiesData;
        private System.Windows.Forms.Label lblHobbiesName;
        private System.Windows.Forms.Label lblStatusData;
        private System.Windows.Forms.Label lblStatusName;
    }
}