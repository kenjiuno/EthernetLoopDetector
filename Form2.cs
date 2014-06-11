using PcapDotNet.Core;
using PcapDotNet.Packets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthernetLoopDetector {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        PacketCommunicator comm;

        public void Run(PcapDotNet.Core.LivePacketDevice device) {
            comm = device.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000);
            comm.SetFilter("ip");
            comm.NonBlocking = true;
            lDev.Text = device.Description;
        }

        private void Form2_Load(object sender, EventArgs e) {
            t.Start();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {
            t.Stop();

            comm.Dispose();
        }

        private void t_Tick(object sender, EventArgs e) {
            int n0 = numReceived;
            int n2 = numDupe;

            Packet p;
            while (comm.ReceivePacket(out p) == PacketCommunicatorReceiveResult.Ok) {
                PacketHandler(p);
            }

            lNumReceived.Text = numReceived.ToString("#,##0");
            lNumDict.Text = hash2.Count.ToString("#,##0");
            lNumDupes.Text = numDupe.ToString("#,##0");

            int d0 = numReceived - n0;
            int d2 = numDupe - n2;

            DANGER = (d0 / 10 < d2);
        }

        bool DANGER {
            set {
                tlpOk.Visible = !value;
                tlpNg.Visible = value;
            }
        }

        int numReceived = 0, numDupe = 0;

        SortedDictionary<string, DateTime> hash2 = new SortedDictionary<string, DateTime>();

        private void PacketHandler(Packet packet) {
            String k = HUt.Hash(packet.Buffer);
            if (hash2.ContainsKey(k)) {
                numDupe++;
            }
            hash2[k] = DateTime.Now;
            numReceived++;
        }

        class HUt {
            public static string Hash(byte[] bin) {
                string s = "";
                foreach (byte b in bin) s += b.ToString("x2");
                return s;
            }
        }
    }
}
