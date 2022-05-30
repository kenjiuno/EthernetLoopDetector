using EthernetLoopDetector.Utils;
using SharpPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EthernetLoopDetector
{
    public partial class LoopDet2Form : Form
    {
        public LoopDet2Form(
            ILiveDevice device
        )
        {
            InitializeComponent();

            comm = device;
            device.Open(DeviceModes.Promiscuous, 1);
            comm.Filter = ("ip");
            lDev.Text = device.Description;
        }

        private readonly ILiveDevice comm;
        private readonly PerUnitCounter cNumReceived = new PerUnitCounter(TimeSpan.FromSeconds(1.1));
        private readonly PerUnitCounter cNumDict = new PerUnitCounter(TimeSpan.FromSeconds(1.1));
        private readonly PerUnitCounter cNumDupes = new PerUnitCounter(TimeSpan.FromSeconds(1.1));
        private readonly PerUnitCounter cNumBC = new PerUnitCounter(TimeSpan.FromSeconds(1.1));

        private void Form2_Load(object sender, EventArgs e)
        {
            t.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Stop();

            comm.StopCapture();
        }

        int tick = 0;

        private void t_Tick(object sender, EventArgs e)
        {
            int n0 = numReceived;
            int n2 = numDupe;

            while (true)
            {
                var res = comm.GetNextPacket(out PacketCapture p);
                if (res == GetPacketStatus.PacketRead)
                {
                    PacketHandler(p.GetPacket());
                }
                else
                {
                    break;
                }
            }

            lNumReceived.Text = numReceived.ToString("#,##0");
            lNumDict.Text = hash2.Count.ToString("#,##0");
            lNumDupes.Text = numDupe.ToString("#,##0");
            lNumBC.Text = numBC.ToString("#,##0");

            cNumReceived.Update(numReceived);
            cNumDict.Update(hash2.Count);
            cNumDupes.Update(numDupe);

            lNumReceivedPS.Text = cNumReceived.Per().ToString("#,##0");
            lNumDictPS.Text = cNumDict.Per().ToString("#,##0");
            lNumDupesPS.Text = cNumDupes.Per().ToString("#,##0");
            lNumBCPS.Text = cNumBC.Per().ToString("#,##0");

            int d0 = numReceived - n0;
            int d2 = numDupe - n2;

            DANGER = (d0 / 3 < d2);

            lTick.Text = "－／｜＼"[tick & 3] + "";
            tick++;

            if (hash2.Count >= 100000)
            {
                hash2.Clear();
            }
        }

        bool DANGER
        {
            set
            {
                tlpOk.Visible = !value;
                tlpNg.Visible = value;
            }
        }

        int numReceived = 0, numDupe = 0, numBC = 0;

        SortedDictionary<string, DateTime> hash2 = new SortedDictionary<string, DateTime>();

        private void PacketHandler(RawCapture packet)
        {
            var raw = packet.Data;

            if (packet.LinkLayerType == PacketDotNet.LinkLayers.Ethernet)
            {
                if (raw.Length >= 14
                    && raw[0] == 0xff
                    && raw[1] == 0xff
                    && raw[2] == 0xff
                    && raw[3] == 0xff
                    && raw[4] == 0xff
                    && raw[5] == 0xff
                    )
                {
                    numBC++;
                }
            }

            String k = HUt.Hash(raw);
            if (hash2.ContainsKey(k))
            {
                numDupe++;
            }
            hash2[k] = DateTime.Now;
            numReceived++;
        }

        class HUt
        {
            private static MD5 hashFunc = MD5.Create();

            public static string Hash(byte[] bin)
            {
                return Convert.ToBase64String(hashFunc.ComputeHash(bin));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hash2.Clear();
            numReceived = numDupe = numBC = 0;
        }
    }
}
