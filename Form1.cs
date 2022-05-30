using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using SharpPcap;
using SharpPcap.LibPcap;
using Autofac.Features.AttributeFilters;

namespace EthernetLoopDetector
{
    public partial class Form1 : Form
    {
        private readonly Func<ILiveDevice, Form> loopDetFormFactory;

        public Form1(
            [KeyFilter("LoopDet")] Func<ILiveDevice, Form> loopDetFormFactory
        )
        {
            this.loopDetFormFactory = loopDetFormFactory;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 0;
            foreach (ILiveDevice device in CaptureDeviceList.Instance)
            {
                Button b = new Button();
                b.Text = device.Description + "\n" + GetDetail(device);
                b.AutoSize = true;
                b.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                b.TextAlign = ContentAlignment.TopLeft;
                b.Click += b_Click;
                b.Tag = device;
                flp1.Controls.Add(b);
                n++;
            }
            tlpNodev.Visible = n == 0;
        }

        private string GetDetail(ILiveDevice device)
        {
            if (device is LibPcapLiveDevice pcap)
            {
                return string.Join("\n", pcap.Addresses.Select(p => p.Addr + ""));
            }
            return "";
        }

        void b_Click(object sender, EventArgs e)
        {
            ILiveDevice device = (ILiveDevice)((Button)sender).Tag;
            var form = loopDetFormFactory(device);
            form.Show(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(ttUrl.GetToolTip((Control)sender));
        }
    }
}
