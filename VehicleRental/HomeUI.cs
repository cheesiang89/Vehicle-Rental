using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalCA
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private void btnEnquireVehicle_Click(object sender, EventArgs e)
        {
                EnquireStatusUI f = new EnquireStatusUI();
                f.ShowDialog();
        }

        private void btnRentVehicle_Click(object sender, EventArgs e)
        {
                VehicleSelectionForm f = new VehicleSelectionForm();
                f.ShowDialog();
        }

        private void btnReturnVehicle_Click(object sender, EventArgs e)
        {
                ReturnVehicleUI f = new ReturnVehicleUI();
                f.ShowDialog();
        }
    }
}
