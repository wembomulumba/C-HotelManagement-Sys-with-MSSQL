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

namespace HotelManagementSystem
{
    public partial class Guest : MetroFramework.Forms.MetroForm
    {
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.Hotelguest' table. You can move, or remove it, as needed.
            this.hotelguestTableAdapter.Fill(this.hotelManagementDataSet.Hotelguest);

        }

        private void newReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 mygotm = new Form2();
            mygotm.Show();
        }
    }
}
