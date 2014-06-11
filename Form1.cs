using PcapDotNet.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthernetLoopDetector {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
            foreach (var device in allDevices) {
                Button b = new Button();
                b.Text = device.Description + "\n" + String.Join("\n", device.Addresses.Select(p => p.Address + "").ToArray());
                b.AutoSize = true;
                b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                b.TextAlign = ContentAlignment.TopLeft;
                b.Click += b_Click;
                b.Tag = device;
                flp1.Controls.Add(b);
            }
            tlpNodev.Visible = allDevices.Count == 0;
        }

        void b_Click(object sender, EventArgs e) {
            LivePacketDevice device = (LivePacketDevice)((Button)sender).Tag;
            Form2 form = new Form2();
            form.Run(device);
            form.Show(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(ttUrl.GetToolTip((Control)sender));
        }
    }
}
