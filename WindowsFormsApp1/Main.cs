using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/1LCB");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you like to save your current regedit values first?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Save();

            if (MessageBox.Show("Are you sure you want to Spoof those items?", "Are you sure? 😳", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            string result = "💥 SPOOFED COMPONENTS 💥\n\n";

            _ = Spoofer.ComputerName.Spoof(chkComputerName.Checked) ? result += "Computer Name: ✔\n" : result += "Computer Name: ✖\n";
            _ = Spoofer.DiskSerials.Spoof(chkDisks.Checked) ? result += "Disk Serial Numbers: ✔\n" : result += "Disk Serial Numbers: ✖\n";
            _ = Spoofer.HardwareProfile.Spoof(chkHWID.Checked) ? result += "HWID: ✔\n" : result += "HWID: ✖\n";
            _ = Spoofer.MacAddress.Spoof(chkMacAddress.Checked) ? result += "MacAddress: ✔\n" : result += "MacAddress: ✖\n";
            _ = Spoofer.MachineGuid.Spoof(chkMachineGuid.Checked) ? result += "MachineGuid: ✔\n" : result += "MachineGuid: ✖\n";
            _ = Spoofer.ProductID.Spoof(chkProductID.Checked) ? result += "ProductID: ✔\n" : result += "ProductID: ✖\n";
            _ = Spoofer.InstallDate.Spoof(chkInstallDate.Checked) ? result += "InstallDate: ✔\n" : result += "InstallDate: ✖\n";
            _ = Spoofer.InstallTime.Spoof(chkInstallTime.Checked) ? result += "InstallTime: ✔\n" : result += "InstallTime: ✖\n";

            MessageBox.Show(result);

            MessageBox.Show("Restart your pc!", "Restart your pc!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Save()
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Regedit file | *.reg";
                sfd.DefaultExt = "reg";
                sfd.AddExtension = true;
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.Title = "Save your backup";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Backup.Save(sfd.FileName);

                    MessageBox.Show("Your backup has been saved successfully!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyHWIDValues form = new MyHWIDValues();
            form.ShowDialog();
        }
    }
}
