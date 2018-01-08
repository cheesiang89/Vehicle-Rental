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
    public partial class ReturnVehicleUI : Form
    {
        public ReturnVehicleUI()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (VehUtil.isEmpty(txtCarPlateNo.Text))
                {
                    MessageBox.Show(VehMessage.EmptyCarPlateNumber);
                    return;
                }

                ReturnVehicleControl c = new ReturnVehicleControl();
                c.ReturnTransaction(txtCarPlateNo.Text);
            }

            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
                MessageBox.Show(VehMessage.GeneralErrorMsg);
            }


        }

    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReturnVehicleUI_Load(object sender, EventArgs e)
        {
            lblAlert.Visible = false;
        }
    }
}
