using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MultiFaceRec
{
    public partial class reg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP\logindata.mdf;Integrated Security=True;Connect Timeout=30");
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\IP\DataBase\logindata.mdf;Integrated Security=True;Connect Timeout=30";
        public reg()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
                MessageBox.Show("please fill mandatory fields");
            else if (txtPassword.Text != txtConfirmPassword.Text)
                MessageBox.Show("Password do not match");
            else
            {

                try
                {
                    con.Open();

                    //int id = '';
                    string qry = "insert into userdata(FirstName,LastName,Contact,Address,Username,Password) values('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtContact.Text + "','" + txtAddress.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "')";
                    SqlCommand sce = new SqlCommand(qry, con);
                    int i = sce.ExecuteNonQuery();

                    if (i >= 1)
                    {

                        //MessageBox.Show("Registration is successfull");
                        MessageBox.Show("Registration is successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }

                    else
                        MessageBox.Show("Registration is failed", "Failed", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    //MessageBox.Show("Registration is failed");
                    
                    con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                finally
                {
                    con.Close();

                }
                // MessageBox.Show("Registration is successfull");
                // Clear();
            

                }
            
        }
        
            
private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginnew mm = new loginnew();
            mm.Show();
        }
    
    void Clear()
        {
            txtFirstName.Text = txtLastName.Text = txtContact.Text = txtAddress.Text = txtUsername.Text = txtPassword.Text = txtConfirmPassword.Text = "";

        }
    }
}
