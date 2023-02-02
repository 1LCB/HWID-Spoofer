using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Spoofer
    {
        public static class DiskSerials
        {
            //static string path = @"HARDWARE\DEVICEMAP\Scsi\Scsi Port 0\Scsi Bus 0";
            private static string path = @"HARDWARE\DEVICEMAP\Scsi";
            public static List<string> regedit_paths = new List<string>();
            public static string[] GetValues()
            {
                List<string> values = new List<string>();

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path)) // HKEY_LOCAL_MACHINE\HARDWARE\DEVICEMAP\Scsi
                {
                    var subkeys = key.GetSubKeyNames();

                    foreach (var subkey in subkeys) // HKEY_LOCAL_MACHINE\HARDWARE\DEVICEMAP\Scsi\Scsi Port 0
                    {
                        using (var key2 = key.OpenSubKey(subkey)) 
                        {
                            var subkeys_ = key2.GetSubKeyNames();
                            foreach (var subk in subkeys_) // HKEY_LOCAL_MACHINE\HARDWARE\DEVICEMAP\Scsi\Scsi Port 0\Scsi Bus 0
                            {
                                using (var key3 = key2.OpenSubKey(subk))
                                {
                                    foreach (var target_subkey in key3.GetSubKeyNames())
                                    {
                                        if (target_subkey.StartsWith("Target Id"))
                                        {
                                            using (var key4 = key3.OpenSubKey(target_subkey + @"\Logical Unit Id 0"))
                                            {
                                                if (key4.GetValueNames().Any(x => x == "SerialNumber"))
                                                {
                                                    var value = key4.GetValue("SerialNumber").ToString().Trim(); //get the disk serial number
                                                    regedit_paths.Add(key4.Name);
                                                    values.Add(value);
                                                }
                                            }
                                        }
                                    } 
                                }
                            }
                        }
                    }

                }
                return values.ToArray();
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;

                int i = 0;
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path))
                {
                    var subkeys = key.GetSubKeyNames();

                    foreach (var subkey in subkeys)
                    {
                        using (var key2 = key.OpenSubKey(subkey))
                        {
                            var subkeys_ = key2.GetSubKeyNames();
                            foreach (var subk in subkeys_)
                            {
                                using (var key3 = key2.OpenSubKey(subk))
                                {
                                    foreach (var target_subkey in key3.GetSubKeyNames())
                                    {
                                        if (target_subkey.StartsWith("Target Id"))
                                        {
                                            using (var key4 = key3.OpenSubKey(target_subkey + @"\Logical Unit Id 0"))
                                            {
                                                if (key4.GetValueNames().Any(x => x == "SerialNumber"))
                                                {
                                                    try
                                                    {
                                                        key4.SetValue("SerialNumber", Rand.GenerateString(20, true));
                                                        i++;
                                                    }
                                                    catch (Exception)
                                                    {
                                                        continue;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return i > 0; 
            }
        }
        public static class MachineGuid
        {
            private static string key = "MachineGuid";
            private static string path = @"SOFTWARE\Microsoft\Cryptography";

            private static Regedit reg = new Regedit(path);
            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;
                return reg.SetValue(key, Guid.NewGuid().ToString());
            }
        }
        public static class ProductID
        {
            private static string key = "ProductID";
            private static string path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";

            private static Regedit reg = new Regedit(path);
            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;

                // 00000-00000-00000-000000
                string productID = $"{Rand.GenerateString(5, true)}-{Rand.GenerateString(5, true)}-{Rand.GenerateString(5, true)}-{Rand.GenerateString(5, true)}";
                return reg.SetValue(key, productID);
            }
        }
        public static class ComputerName
        {
            private static string key = "ComputerName";
            private static string path = @"SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName";

            private static Regedit reg = new Regedit(path);

            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;
                return reg.SetValue(key, $"S-{Rand.GenerateString(15)}");
            }
        }
        public static class HardwareProfile
        {
            private static string key = "HwProfileGuid";
            private static string path = @"SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";

            private static Regedit reg = new Regedit(path);
            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;
                return reg.SetValue(key, "{" + Guid.NewGuid() + "}");
            }
        }
        public static class MacAddress {
            private static string key = "NetworkAddress";
            private static string path = @"SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\0012";

            private static Regedit reg = new Regedit(path);

            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;
                return reg.SetValue(key, Rand.GenerateString(12, true));
            }

        }
        public static class InstallTime
        {
            private static string path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            private static string key = "InstallTime";

            private static Regedit reg = new Regedit(path);
            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;
                return reg.SetValue(key, Rand.GenerateString(12, false));
            }
        }
        public static class InstallDate
        {
            private static string path = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            private static string key = "InstallDate";

            private static Regedit reg = new Regedit(path);
            public static string GetValue()
            {
                return reg.Read(key);
            }
            public static bool Spoof(bool confirm)
            {
                if (!confirm)
                    return false;

                return reg.SetValue(key, Rand.GenerateString(12, false));
            }
        }
    }
    public class Backup
    {
        private static string[] diskSerials = { };
        private static string machineGuid = "";
        private static string productID = "";
        private static string computerName = "";
        private static string hardwareProfile = "";
        private static string macAddress = "";
        private static string installTime = "";
        private static string installDate = "";

        //[HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Control\Class\{4d36e972-e325-11ce-bfc1-08002be10318}\0012]
        private static string file_content = "Windows Registry Editor Version 5.00\n\n";

        private static void MakeBackup()
        {
            diskSerials = Spoofer.DiskSerials.GetValues();
            machineGuid = Spoofer.MachineGuid.GetValue();
            productID = Spoofer.ProductID.GetValue();
            computerName = Spoofer.ComputerName.GetValue();
            hardwareProfile = Spoofer.HardwareProfile.GetValue();
            macAddress = Spoofer.MacAddress.GetValue();
            installTime = Spoofer.InstallTime.GetValue();
            installDate = Spoofer.InstallDate.GetValue();

            int i = 0;
            foreach (var item in Spoofer.DiskSerials.regedit_paths)
            {
                file_content += $"[{item}]\n";
                file_content += $"\"SerialNumber\"=\"{diskSerials[i]}\"\n\n";
                i++;
            }
            //machine guid
            file_content += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography]\n";
            file_content += $"\"MachineGuid\"=\"{machineGuid}\"\n\n";

            //product id
            file_content += "[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion]\n";
            file_content += $"\"ProductID\"=\"{productID}\"\n\n";

            //computerName
            file_content += "[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName]\n";
            file_content += $"\"ComputerName\"=\"{computerName}\"\n\n";

            //HWID
            file_content += "[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001]\n";
            file_content += $"\"HwProfileGuid\"=\"{hardwareProfile}\"\n\n";

            //macAddress
            file_content += "[HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Class\\{4D36E972-E325-11CE-BFC1-08002BE10318}\\0012]\n";
            file_content += $"\"NetworkAddress\"=\"{macAddress}\"\n\n";

            file_content += @"[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion]";
            file_content += $"\"InstallTime\"=\"{installTime}\"\n\n";

            file_content += @"[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion]";
            file_content += $"\"InstallDate\"=\"{installDate}\"\n\n";
        }

        public static void Save(string path)
        {
            MakeBackup();

            File.WriteAllText(path, file_content);
        }
    }
    # region Helper
    public class Regedit
    {
        string regedit_path = null;
        public Regedit(string regedit_path)
        {
            this.regedit_path = regedit_path;
        }
        public string Read(string key)
        {
            try
            {
                using (RegistryKey b = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                {
                    var k = b.OpenSubKey(regedit_path);
                    if (k != null)
                        return k.GetValue(key) == null ? "" : k.GetValue(key).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }
        public bool SetValue(string key, object value)
        {
            try
            {
                using (RegistryKey k = Registry.LocalMachine.OpenSubKey(regedit_path, true))
                {
                    k.SetValue(key, value);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }

    public static class Rand
    {
        private static Random rand = new Random();
        private static string Alphabet = "abcdef0123456789";

        public static string GenerateString(int size, bool UPPERCASE = false)
        {
            if (UPPERCASE)
                Alphabet = Alphabet.ToUpper();

            string ran = "";
            for (int i = 0; i < size; i++)
            {
                int x = rand.Next(Alphabet.Length);
                ran += Alphabet[x];
            }
            Debug.WriteLine(ran);
            return ran;
        }
    }
    #endregion
}
