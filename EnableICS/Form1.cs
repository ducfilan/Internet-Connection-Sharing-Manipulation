using System;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using IcsManagerLibrary;
using NETCONLib;

namespace EnableICS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
        }

        void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshConnections();

                ApplySharing();

                Close();
            }
            catch (UnauthorizedAccessException)
            {
                RestartElevated();
                Close();
            }
            catch (NotImplementedException)
            {
                MessageBox.Show("This program is not supported on your operating system.");
                Close();
            }
        }

        public void RestartElevated()
        {
            var startInfo = new ProcessStartInfo
            {
                UseShellExecute = true,
                CreateNoWindow = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process.Start(startInfo);
            }
            catch { }

            Application.Exit();
        }

        private void ApplySharing()
        {
            ConnectionItem sharedConnectionItem = (from object item in cbSharedConnection.Items 
                                                   select item as ConnectionItem)
                                                   .FirstOrDefault(connItem => connItem.ToString().Contains("Wi-Fi"));

            ConnectionItem homeConnectionItem = (from object item in cbHomeConnection.Items 
                                                 select item as ConnectionItem)
                                                 .FirstOrDefault(connItem => connItem.ToString().Contains("Local Area Connection"));

            if ((sharedConnectionItem == null) || (homeConnectionItem == null))
            {
                MessageBox.Show(@"Please select both connections.");
                return;
            }
            if (sharedConnectionItem.Connection == homeConnectionItem.Connection)
            {
                MessageBox.Show(@"Please select different connections.");
                return;
            }

            IcsManager.ShareConnection(sharedConnectionItem.Connection, homeConnectionItem.Connection);
            RefreshConnections();
        }


        private void RefreshConnections()
        {
            foreach (var nic in IcsManager.GetAllIPv4Interfaces())
            {
                AddNic(nic);
            }
        }

        private void AddNic(NetworkInterface nic)
        {
            var connItem = new ConnectionItem(nic);
            cbSharedConnection.Items.Add(connItem);
            cbHomeConnection.Items.Add(connItem);
            var netShareConnection = connItem.Connection;
            if (netShareConnection != null)
            {
                var sc = IcsManager.GetConfiguration(netShareConnection);
                if (sc.SharingEnabled)
                {
                    switch (sc.SharingConnectionType)
                    {
                        case tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PUBLIC:
                            cbSharedConnection.SelectedIndex = cbSharedConnection.Items.Count - 1;
                            break;
                        case tagSHARINGCONNECTIONTYPE.ICSSHARINGTYPE_PRIVATE:
                            cbHomeConnection.SelectedIndex = cbSharedConnection.Items.Count - 1;
                            break;
                    }
                }
            }
        }
    }
}
