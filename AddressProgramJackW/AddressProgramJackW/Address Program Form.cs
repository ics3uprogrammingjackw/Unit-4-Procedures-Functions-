using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressProgramJackW
{
    public partial class frmAddressProgram : Form
    {
        public frmAddressProgram()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string aptNumber = this.txtApt.Text;
            string address = this.txtAddress.Text;
            string city = this.txtCity.Text;
            string province = this.txtProvince.Text;
            string postalCode = this.txtPostalCode.Text;

        }
    }
}
