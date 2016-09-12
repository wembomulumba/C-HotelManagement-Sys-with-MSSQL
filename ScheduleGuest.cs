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


namespace HotelManagementSystem
{
    public partial class ScheduleGuest : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public ScheduleGuest()
        {
            InitializeComponent();
        }

        private void ScheduleGuest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelManagementDataSet.Rooms);
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Hotelguest' table. You can move, or remove it, as needed.
            this.hotelguestTableAdapter.Fill(this.hotelManagementDataSet.Hotelguest);

        }

        private void ratingItem1_RatingChanged(object sender, EventArgs e)
        {

        }

        private void roomsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
