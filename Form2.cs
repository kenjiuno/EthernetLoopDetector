using SharpPcap;
using SharpPcap.WinPcap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EthernetLoopDetector {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        WinPcapDevice comm;

        public void Run(WinPcapDevice device) {
            comm = device;
            device.Open(OpenFlags.Promiscuous, 1, null);
            comm.Filter = ("arp");
            comm.NonBlockingMode = true;
            lDev.Text = device.Description;
        }

        private void Form2_Load(object sender, EventArgs e) {
            t.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            t.Stop();

            comm.StopCapture();
        }

        int tick = 0;

        DateTime dtPrev = DateTime.MinValue;

        SortedDictionary<string, string> dDup = new SortedDictionary<string, string>();

        private void t_Tick(object sender, EventArgs e) {
            int prevReceived = totalReceived;

            RawCapture p;
            while (null != (p = comm.GetNextPacket())) {
                PacketHandler(p);
            }

            dDup.Clear();
            for (int t = 0; t < nPackets; t++) {
                dDup[HUt.Hash(hash.ComputeHash(packets[(100 + iPacket - 1 - t) % 100]))] = null;
            }
            numDup = dDup.Count;

            var dtCur = DateTime.Now;
            int d0 = totalReceived - prevReceived;
            if (dtPrev != DateTime.MinValue && dtPrev != dtCur) {
                var nSpeed = (d0 / dtCur.Subtract(dtPrev).TotalSeconds);
                lSpeed.Text = nSpeed.ToString("#,##0");

                DANGER = nSpeed > 100;
            }
            else DANGER = false;

            lNumReceived.Text = totalReceived.ToString("#,##0");
            lNumDup.Text = numDup.ToString("#,##0");

            lTick.Text = "―＼｜／"[tick & 3] + "";
            tick++;

            dtPrev = dtCur;
        }

        bool DANGER {
            set {
                tlpOk.Visible = !value;
                tlpNg.Visible = value;
            }
        }

        int totalReceived = 0;
        int numDup = 0;

        MD5 hash = MD5.Create();

        private void PacketHandler(RawCapture packet) {
            totalReceived++;

            packets[iPacket] = packet.Data;
            nPackets++;
            if (nPackets > 100) nPackets = 100;

            iPacket++;
            if (iPacket == 100) iPacket = 0;
        }

        byte[][] packets = new byte[100][];
        int iPacket = 0;
        int nPackets = 0;

        class HUt {
            public static string Hash(byte[] bin) {
                string s = "";
                foreach (byte b in bin) s += b.ToString("x2");
                return s;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            totalReceived = 0;
        }
    }
}
