namespace EthernetLoopDetector {
    partial class LoopDet1Form {
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
            this.label3 = new System.Windows.Forms.Label();
            this.lSpeed = new System.Windows.Forms.Label();
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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lNumDup = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpOk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tlpNg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Interval = 333;
            this.t.Tick += new System.EventHandler(this.t_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lNumReceived, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lSpeed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lNumDup, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 57);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 112);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARP 受信パケット数：";
            // 
            // lNumReceived
            // 
            this.lNumReceived.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumReceived.AutoSize = true;
            this.lNumReceived.Location = new System.Drawing.Point(358, 9);
            this.lNumReceived.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lNumReceived.Name = "lNumReceived";
            this.lNumReceived.Size = new System.Drawing.Size(17, 18);
            this.lNumReceived.TabIndex = 1;
            this.lNumReceived.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "速度：";
            // 
            // lSpeed
            // 
            this.lSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lSpeed.AutoSize = true;
            this.lSpeed.Location = new System.Drawing.Point(358, 46);
            this.lSpeed.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lSpeed.Name = "lSpeed";
            this.lSpeed.Size = new System.Drawing.Size(17, 18);
            this.lSpeed.TabIndex = 3;
            this.lSpeed.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "デバイス：";
            // 
            // lDev
            // 
            this.lDev.AutoSize = true;
            this.lDev.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lDev.Location = new System.Drawing.Point(155, 14);
            this.lDev.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDev.Name = "lDev";
            this.lDev.Size = new System.Drawing.Size(35, 18);
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
            this.tlpOk.Location = new System.Drawing.Point(20, 202);
            this.tlpOk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tlpOk.Name = "tlpOk";
            this.tlpOk.RowCount = 1;
            this.tlpOk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOk.Size = new System.Drawing.Size(530, 70);
            this.tlpOk.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EthernetLoopDetector.Properties.Resources._109_AllAnnotations_Complete_32x32_72;
            this.pictureBox1.Location = new System.Drawing.Point(5, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 18);
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
            this.tlpNg.Location = new System.Drawing.Point(20, 282);
            this.tlpNg.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tlpNg.Name = "tlpNg";
            this.tlpNg.RowCount = 1;
            this.tlpNg.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNg.Size = new System.Drawing.Size(530, 70);
            this.tlpNg.TabIndex = 4;
            this.tlpNg.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::EthernetLoopDetector.Properties.Resources._109_AllAnnotations_Warning_32x32_72;
            this.pictureBox2.Location = new System.Drawing.Point(5, 11);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "ループの兆候が有り、危険な状態です。";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 363);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lTick
            // 
            this.lTick.AutoSize = true;
            this.lTick.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F);
            this.lTick.Location = new System.Drawing.Point(20, 14);
            this.lTick.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lTick.Name = "lTick";
            this.lTick.Size = new System.Drawing.Size(17, 18);
            this.lTick.TabIndex = 6;
            this.lTick.Text = ".";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "パケット／秒";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "ARP ユニーク数(直近 100 個)：";
            // 
            // lNumDup
            // 
            this.lNumDup.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lNumDup.AutoSize = true;
            this.lNumDup.Location = new System.Drawing.Point(358, 84);
            this.lNumDup.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lNumDup.Name = "lNumDup";
            this.lNumDup.Size = new System.Drawing.Size(17, 18);
            this.lNumDup.TabIndex = 6;
            this.lNumDup.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 423);
            this.Controls.Add(this.lTick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlpNg);
            this.Controls.Add(this.tlpOk);
            this.Controls.Add(this.lDev);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lSpeed;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lNumDup;
    }
}