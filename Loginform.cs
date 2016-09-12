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

namespace HotelManagementSystem
{
    public partial class Authentification : MetroFramework.Forms.MetroForm
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private Form Registerform; 
        private void metroLabel3_Click(object sender, EventArgs e)
        {
            Registerform = new Register();
            Registerform.Show();
        }


        private Form moreForm;
        private Form xdr;

        private void metroButton1_Click(object sender, EventArgs e)
        {




            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True";
            sql = "Select * from Admins Where Email = '" + metroTextBox1.Text + "' AND  Password = '" + metroTextBox2.Text + "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("You Have Successfully Login !");

                 //   textBox1.Text = (dataReader.GetValue(0).ToString());


                }
                dataReader.Close();
                command.Dispose();
                connection.Close();

                xdr = new Authentification();
                xdr.Hide();
                
                moreForm = new Form2();
                moreForm.Show();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }





        }
    }
}
