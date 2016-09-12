using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Data.SqlClient;
using System.Xaml;
using System.Windows;
using DevComponents;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar.Metro;




namespace HotelManagementSystem
{
    public partial class Form2 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SearchCode();
        }


        public void SearchCode()
        {





            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True";
            sql = "Select * from HotelGuest Where Code = '" + metroTextBox11.Text + "' OR  FirstName = '" + metroTextBox2.Text + "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                  

                    metroTextBox1.Text = (dataReader.GetValue(2).ToString());
                    metroTextBox2.Text = (dataReader.GetValue(1).ToString());
                    metroTextBox3.Text = (dataReader.GetValue(7).ToString());
                    metroTextBox4.Text = (dataReader.GetValue(3).ToString());
                    metroTextBox5.Text = (dataReader.GetValue(3).ToString());
                    metroTextBox6.Text = (dataReader.GetValue(4).ToString());
                    metroTextBox7.Text = (dataReader.GetValue(5).ToString());
                   
                    metroTextBox9.Text = (dataReader.GetValue(10).ToString());
                    metroTextBox10.Text = (dataReader.GetValue(6).ToString());







                }
                dataReader.Close();
                command.Dispose();
                connection.Close();

                //MetroMessageBox.Show(this, "Do you want to apply for Another Room ?", "Reserved Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
              //  MessageBox.Show("Can not open connection ! ");
            }

            
          
        }





        public void Deletefnc()
        {





            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
        
            connetionString = "Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True";
            sql = "DELETE FROM Hotelguest WHERE Code = '" + metroTextBox11.Text + "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
               command.ExecuteNonQuery();
              
               

                //MetroMessageBox.Show(this, "Do you want to apply for Another Room ?", "Reserved Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
               // MessageBox.Show("Can not open connection ! ");
            }

            
          
        }





        public void UpdateInfo()
        {


            try
            {

                using (SqlConnection conn = new SqlConnection("Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True"))
                {
                    SqlCommand CmdSql = new SqlCommand("UPDATE Hotelguest SET RoomType = @RoomType, Room= @Room , Phonenumber= @Phonenumber ,  RoomCost= @RoomCost,  Status= @Status    Where Code = @Code ", conn);

                    conn.Open();
                    CmdSql.Parameters.AddWithValue("@Code", metroTextBox11.Text);
                    CmdSql.Parameters.AddWithValue("@RoomType", comboBox1.SelectedItem);
                    CmdSql.Parameters.AddWithValue("@Room", metroTextBox12.Text);

                    CmdSql.Parameters.AddWithValue("@Phonenumber", metroTextBox3.Text);
                    CmdSql.Parameters.AddWithValue("@RoomCost", metroTextBox18.Text);
                    CmdSql.Parameters.AddWithValue("@Status", metroTextBox9.Text);
                   

                    CmdSql.ExecuteNonQuery();
                    conn.Close();

                 //   MessageBox.Show("Account Updated");
                }

            }

            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Save Date on Private file ?", "Update Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
            }



          


        }


        private void metroButton5_Click(object sender, EventArgs e)
        {
            Deletefnc();
            MetroMessageBox.Show(this, "Do you want to apply for Another Room ?", "Reserved Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            connetionString = "Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True";
            sql = "Select * from Rateinfo Where RoomType = '" + comboBox1.SelectedItem + "'";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {


                    metroTextBox16.Text = (dataReader.GetValue(1).ToString());
                    metroLabel15.Text = (dataReader.GetValue(2).ToString());


                }
                dataReader.Close();
                command.Dispose();
                connection.Close();

                //MetroMessageBox.Show(this, "Do you want to apply for Another Room ?", "Reserved Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            }
            catch (Exception ex)
            {
                //MessageBox.Show("this type not found : " + comboBox1.SelectedItem);
            }

            


        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {
            int startTime = metroDateTime1.Value.Day;
            int Ends = metroDateTime2.Value.Day;


            int difference = Ends - startTime;

            metroTextBox13.Text = (difference.ToString());

            TotalCalculation();
        }




        public void TotalCalculation()
        {


            try
            {

                double Tax = 0;
                double Roomcost = 0;
                int NightCounts = 1;
                Tax = Convert.ToDouble(metroLabel15.Text);

                Roomcost = Convert.ToDouble(metroTextBox16.Text);
                NightCounts = Convert.ToInt32(metroTextBox13.Text);



                double total = (Roomcost * NightCounts) + Roomcost * Tax;
                String getTotal = Convert.ToString(total);
                metroLabel20.Text = getTotal;
                metroTextBox18.Text = getTotal;
            }


            catch (Exception ex)
            {
               // MessageBox.Show("Please fill in Room type anc Cost ", "");
            }


                

           
        }

        private void metroLabel20_Click(object sender, EventArgs e)
        {
            TotalCalculation();
        }

        private void reservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {



            using (SqlConnection conn = new SqlConnection("Data Source=PERSONHUB-CEO;Initial Catalog=HotelManagement;Integrated Security=True"))
            {
                SqlCommand CmdSql =
                    new SqlCommand("INSERT INTO Hotelguest (Code,LastName,FirstName, Address, City, Zipcode,Passportnumber,Phonenumber,Room, CheckIN, CheckOut,Unit, Status, GuestCount, NightCount,PromotionCode,RoomType, RoomCost)  VALUES (@Code, @LastName,@FirstName, @Address, @City, @Zipcode,@Passportnumber,@Phonenumber,@Room,  @CheckIN, @CheckOut,@Unit, @Status, @GuestCount, @NightCount,@PromotionCode,@RoomType, @RoomCost)", conn); 
               
               
               
                
                conn.Open();
                CmdSql.Parameters.AddWithValue("@Code", metroTextBox11.Text);
                CmdSql.Parameters.AddWithValue("@LastName", metroTextBox2.Text);
                CmdSql.Parameters.AddWithValue("@FirstName", metroTextBox1.Text);
                CmdSql.Parameters.AddWithValue("@Address", metroTextBox4.Text);
                CmdSql.Parameters.AddWithValue("@City", metroTextBox6.Text);
                CmdSql.Parameters.AddWithValue("@Zipcode", metroTextBox7.Text);
                CmdSql.Parameters.AddWithValue("@Passportnumber", metroTextBox10.Text);
                CmdSql.Parameters.AddWithValue("@Phonenumber", metroTextBox3.Text);
                CmdSql.Parameters.AddWithValue("@Room", metroTextBox12.Text);
                CmdSql.Parameters.AddWithValue("@CheckIN", metroDateTime1.Value);
                CmdSql.Parameters.AddWithValue("@CheckOUT", metroDateTime1.Value);

                CmdSql.Parameters.AddWithValue("@Unit", metroTextBox12.Text);
                CmdSql.Parameters.AddWithValue("@Status", metroTextBox9.Text);
                CmdSql.Parameters.AddWithValue("@GuestCount", metroTextBox11.Text);
                CmdSql.Parameters.AddWithValue("@NightCount", metroTextBox13.Text);

                CmdSql.Parameters.AddWithValue("@PromotionCode", metroTextBox15.Text);
                CmdSql.Parameters.AddWithValue("@RoomType", "Normal");
                CmdSql.Parameters.AddWithValue("@RoomCost", metroTextBox18.Text);




                CmdSql.ExecuteNonQuery();
                conn.Close();

              //  MessageBox.Show("Account Created");
            }







        }

        

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.metroTextBox1.Text = "";
            this.metroTextBox2.Text = "";
            this.metroTextBox3.Text = "";
            this.metroTextBox4.Text = "";
            this.metroTextBox5.Text = "";
            this.metroTextBox6.Text = "";
            this.metroTextBox7.Text = "";
            this.metroTextBox8.Text = "";
            this.metroTextBox9.Text = "";
            this.metroTextBox10.Text = "";
            this.metroTextBox11.Text = "";
            this.metroTextBox12.Text = "";


        }

        private void GenerateCode_CheckedChanged(object sender, EventArgs e)
        {

            Random random = new Random();
            float randomNumber1 = random.Next(8000, 9885);
            float randomNumber2 = random.Next(2222, 9005);
            float randomNumber3 = random.Next(1111, 2351);
            float randomNumber4 = random.Next(3001, 8403);

            String mykey = randomNumber1 + "A" + randomNumber4 + "V" + randomNumber1 + "B" + randomNumber1 + "C";

            metroTextBox11.Text = mykey;
        }

      

        private void metroTabItem3_Click(object sender, EventArgs e)
        {
            ScheduleGuest myschedule = new ScheduleGuest();
            myschedule.Show();
        }

        private void metroTabItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            CreateRoom mrooms = new CreateRoom();
            mrooms.Show();
        }

        private void metroShell1_Click(object sender, EventArgs e)
        {

        }
        

       


       
    }
}
