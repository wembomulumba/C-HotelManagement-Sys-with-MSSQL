using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace HotelManagementSystem
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private Form loginform;
        private void button2_Click(object sender, EventArgs e)
        {
            loginform = new Register();
            loginform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True"))
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO Admins (FirstName, LastName, Email, Password,Accessnumber) VALUES (@FirstName, @LastName, @Email, @Password, @Accessnumber)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@FirstName", metroTextBox1.Text);
                CmdSql.Parameters.AddWithValue("@LastName", metroTextBox2.Text);
                CmdSql.Parameters.AddWithValue("@Email", metroTextBox3.Text);
                CmdSql.Parameters.AddWithValue("@Password", metroTextBox4.Text);
                CmdSql.Parameters.AddWithValue("@Accessnumber", metroTextBox5.Text);

                CmdSql.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Account Created");
            }
        }
    }
}
