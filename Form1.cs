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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string connetionString = null;
            SqlConnection cnn ;
            connetionString = "Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show ("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True";
            sql = "Select * from Hotelguest";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if(dataReader.Read())
                {
                    MessageBox.Show(dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2));

                    textBox1.Text = (dataReader.GetValue(0).ToString());
                

                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True"))
            {
                SqlCommand CmdSql = new SqlCommand("INSERT INTO Hotelguest (Code, LastName, FirstName) VALUES (@Code, @LastName, @FirstName)", conn);
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Code", textBox1.Text);
                CmdSql.Parameters.AddWithValue("@LastName", textBox2.Text);
                CmdSql.Parameters.AddWithValue("@FirstName", textBox3.Text);
                
                CmdSql.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Hello");
            }
        }
        private Form moreForm;
        private void button4_Click(object sender, EventArgs e)
        {
            moreForm = new Authentification();
            moreForm.Show();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelManagementDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);

        }

        private void roomsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
