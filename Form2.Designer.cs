namespace EthernetLoopDetector {
    partial class Form2 {
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
            this.label5 = new System.Windows.Forms.Label();
            this.tlpNg = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpOk.SuspendLayout();
            this.tlpNg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Interval = 333;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lNumReceived, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lNumDict, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lNumDupes, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "受信パケット数：";
            // 
            // lNumReceived
            // 
            this.lNumReceived.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumReceived.AutoSize = true;
            this.lNumReceived.Location = new System.Drawing.Point(193, 9);
            this.lNumReceived.Name = "lNumReceived";
            this.lNumReceived.Size = new System.Drawing.Size(11, 12);
            this.lNumReceived.TabIndex = 1;
            this.lNumReceived.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "蓄積数：";
            // 
            // lNumDict
            // 
            this.lNumDict.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDict.AutoSize = true;
            this.lNumDict.Location = new System.Drawing.Point(193, 39);
            this.lNumDict.Name = "lNumDict";
            this.lNumDict.Size = new System.Drawing.Size(11, 12);
            this.lNumDict.TabIndex = 3;
            this.lNumDict.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "重複数：";
            // 
            // lNumDupes
            // 
            this.lNumDupes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDupes.AutoSize = true;
            this.lNumDupes.Location = new System.Drawing.Point(193, 69);
            this.lNumDupes.Name = "lNumDupes";
            this.lNumDupes.Size = new System.Drawing.Size(11, 12);
            this.lNumDupes.TabIndex = 5;
            this.lNumDupes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "デバイス：";
            // 
            // lDev
            // 
            this.lDev.AutoSize = true;
            this.lDev.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lDev.Location = new System.Drawing.Point(67, 9);
            this.lDev.Name = "lDev";
            this.lDev.Size = new System.Drawing.Size(23, 12);
            this.lDev.TabIndex = 2;
            this.lDev.Text = "...";
            // 
            // tlpOk
            // 
            this.tlpOk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpOk.ColumnCount = 2;
            this.tlpOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpOk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOk.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpOk.Controls.Add(this.label5, 1, 0);
            this.tlpOk.Location = new System.Drawing.Point(12, 135);
            this.tlpOk.Name = "tlpOk";
            this.tlpOk.RowCount = 1;
            this.tlpOk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOk.Size = new System.Drawing.Size(318, 47);
            this.tlpOk.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 12);
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
            this.tlpNg.Location = new System.Drawing.Point(12, 188);
            this.tlpNg.Name = "tlpNg";
            this.tlpNg.RowCount = 1;
            this.tlpNg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNg.Size = new System.Drawing.Size(318, 47);
            this.tlpNg.TabIndex = 4;
            this.tlpNg.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "ループの兆候が有り、危険な状態です。";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 277);
            this.Controls.Add(this.tlpNg);
            this.Controls.Add(this.tlpOk);
            this.Controls.Add(this.lDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[Ethernet ループ検出] 監視中";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpOk.ResumeLayout(false);
            this.tlpOk.PerformLayout();
            this.tlpNg.ResumeLayout(false);
            this.tlpNg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}