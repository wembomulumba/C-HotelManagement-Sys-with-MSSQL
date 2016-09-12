using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using DevComponents;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar.Metro;

using System.Data.SqlClient;




namespace HotelManagementSystem
{
    public partial class CreateRoom : Form
    {
        public CreateRoom()
        {
            InitializeComponent();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelManagementDataSet);

        }

        private void CreateRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myform2 = new Form2();
            myform2.Show();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
