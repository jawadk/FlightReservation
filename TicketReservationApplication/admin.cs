using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_AdminPanal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginObj = new Login();
            LoginObj.Show();
        }

        private void btn_UserPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReserveFlights reserveobj = new ReserveFlights();
            reserveobj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
