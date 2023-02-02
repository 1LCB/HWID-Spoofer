using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyHWIDValues : Form
    {
        public MyHWIDValues()
        {
            InitializeComponent();
        }

        private void MyHWIDValues_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(Spoofer.DiskSerials.GetValues());
            txtMachineGuid.Text = Spoofer.MachineGuid.GetValue();
            txtComputerName.Text = Spoofer.ComputerName.GetValue();
            txtHWID.Text = Spoofer.HardwareProfile.GetValue();
            txtMacAddress.Text = Spoofer.MacAddress.GetValue();
            txtProductID.Text = Spoofer.ProductID.GetValue();
            txtID.Text = Spoofer.InstallDate.GetValue();
            txtIT.Text = Spoofer.InstallTime.GetValue();
        }
    }
}
