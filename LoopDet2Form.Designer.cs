namespace EthernetLoopDetector {
    partial class LoopDet2Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.t = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lNumReceived = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNumDict = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lNumDupes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lDev = new System.Windows.Forms.Label();
            this.tlpOk = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tlpNg = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lTick = new System.Windows.Forms.Label();
            this.lNumReceivedPS = new System.Windows.Forms.Label();
            this.lNumDictPS = new System.Windows.Forms.Label();
            this.lNumDupesPS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lNumBCPS = new System.Windows.Forms.Label();
            this.lNumBC = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpOk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpNg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Interval = 1000;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lNumReceived, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lNumDict, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lNumDupes, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lNumReceivedPS, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lNumDictPS, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lNumDupesPS, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lNumBCPS, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lNumBC, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(521, 156);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "受信パケット数：";
            // 
            // lNumReceived
            // 
            this.lNumReceived.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumReceived.AutoSize = true;
            this.lNumReceived.Location = new System.Drawing.Point(497, 27);
            this.lNumReceived.Name = "lNumReceived";
            this.lNumReceived.Size = new System.Drawing.Size(21, 22);
            this.lNumReceived.TabIndex = 1;
            this.lNumReceived.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "一意数：";
            // 
            // lNumDict
            // 
            this.lNumDict.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDict.AutoSize = true;
            this.lNumDict.Location = new System.Drawing.Point(497, 60);
            this.lNumDict.Name = "lNumDict";
            this.lNumDict.Size = new System.Drawing.Size(21, 22);
            this.lNumDict.TabIndex = 3;
            this.lNumDict.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "重複検出数：";
            // 
            // lNumDupes
            // 
            this.lNumDupes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDupes.AutoSize = true;
            this.lNumDupes.Location = new System.Drawing.Point(497, 93);
            this.lNumDupes.Name = "lNumDupes";
            this.lNumDupes.Size = new System.Drawing.Size(21, 22);
            this.lNumDupes.TabIndex = 5;
            this.lNumDupes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "デバイス：";
            // 
            // lDev
            // 
            this.lDev.AutoSize = true;
            this.lDev.Location = new System.Drawing.Point(134, 9);
            this.lDev.Name = "lDev";
            this.lDev.Size = new System.Drawing.Size(21, 22);
            this.lDev.TabIndex = 2;
            this.lDev.Text = "・";
            // 
            // tlpOk
            // 
            this.tlpOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOk.ColumnCount = 2;
            this.tlpOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOk.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpOk.Controls.Add(this.label5, 1, 0);
            this.tlpOk.Location = new System.Drawing.Point(12, 223);
            this.tlpOk.Name = "tlpOk";
            this.tlpOk.RowCount = 1;
            this.tlpOk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOk.Size = new System.Drawing.Size(406, 47);
            this.tlpOk.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EthernetLoopDetector.Properties.Resources._109_AllAnnotations_Complete_32x32_72;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(347, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "ループの兆候はなく、大丈夫の様です。";
            // 
            // tlpNg
            // 
            this.tlpNg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNg.ColumnCount = 2;
            this.tlpNg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNg.Controls.Add(this.pictureBox2, 0, 0);
            this.tlpNg.Controls.Add(this.label6, 1, 0);
            this.tlpNg.Location = new System.Drawing.Point(12, 276);
            this.tlpNg.Name = "tlpNg";
            this.tlpNg.RowCount = 1;
            this.tlpNg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNg.Size = new System.Drawing.Size(406, 47);
            this.tlpNg.TabIndex = 4;
            this.tlpNg.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::EthernetLoopDetector.Properties.Resources._109_AllAnnotations_Warning_32x32_72;
            this.pictureBox2.Location = new System.Drawing.Point(3, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "ループの兆候が有り、危険な状態です。";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lTick
            // 
            this.lTick.AutoSize = true;
            this.lTick.Location = new System.Drawing.Point(8, 9);
            this.lTick.Name = "lTick";
            this.lTick.Size = new System.Drawing.Size(21, 22);
            this.lTick.TabIndex = 6;
            this.lTick.Text = "・";
            // 
            // lNumReceivedPS
            // 
            this.lNumReceivedPS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumReceivedPS.AutoSize = true;
            this.lNumReceivedPS.Location = new System.Drawing.Point(327, 27);
            this.lNumReceivedPS.Name = "lNumReceivedPS";
            this.lNumReceivedPS.Size = new System.Drawing.Size(21, 22);
            this.lNumReceivedPS.TabIndex = 1;
            this.lNumReceivedPS.Text = "0";
            // 
            // lNumDictPS
            // 
            this.lNumDictPS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDictPS.AutoSize = true;
            this.lNumDictPS.Location = new System.Drawing.Point(327, 60);
            this.lNumDictPS.Name = "lNumDictPS";
            this.lNumDictPS.Size = new System.Drawing.Size(21, 22);
            this.lNumDictPS.TabIndex = 3;
            this.lNumDictPS.Text = "0";
            // 
            // lNumDupesPS
            // 
            this.lNumDupesPS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDupesPS.AutoSize = true;
            this.lNumDupesPS.Location = new System.Drawing.Point(327, 93);
            this.lNumDupesPS.Name = "lNumDupesPS";
            this.lNumDupesPS.Size = new System.Drawing.Size(21, 22);
            this.lNumDupesPS.TabIndex = 5;
            this.lNumDupesPS.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(486, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "計";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "毎秒";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "ブロードキャスト数：";
            // 
            // lNumBCPS
            // 
            this.lNumBCPS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumBCPS.AutoSize = true;
            this.lNumBCPS.Location = new System.Drawing.Point(327, 127);
            this.lNumBCPS.Name = "lNumBCPS";
            this.lNumBCPS.Size = new System.Drawing.Size(21, 22);
            this.lNumBCPS.TabIndex = 5;
            this.lNumBCPS.Text = "0";
            // 
            // lNumBC
            // 
            this.lNumBC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumBC.AutoSize = true;
            this.lNumBC.Location = new System.Drawing.Point(497, 127);
            this.lNumBC.Name = "lNumBC";
            this.lNumBC.Size = new System.Drawing.Size(21, 22);
            this.lNumBC.TabIndex = 5;
            this.lNumBC.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(591, 394);
            this.Controls.Add(this.lTick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlpNg);
            this.Controls.Add(this.tlpOk);
            this.Controls.Add(this.lDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[Ethernet ループ検出] 監視中";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpOk.ResumeLayout(false);
            this.tlpOk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tlpNg.ResumeLayout(false);
            this.tlpNg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer t;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lNumReceived;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNumDict;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNumDupes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lDev;
        private System.Windows.Forms.TableLayoutPanel tlpOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tlpNg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lTick;
        private System.Windows.Forms.Label lNumReceivedPS;
        private System.Windows.Forms.Label lNumDictPS;
        private System.Windows.Forms.Label lNumDupesPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lNumBCPS;
        private System.Windows.Forms.Label lNumBC;
    }
}