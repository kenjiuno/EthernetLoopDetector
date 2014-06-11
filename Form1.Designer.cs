namespace EthernetLoopDetector {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tlpNodev = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ttUrl = new System.Windows.Forms.ToolTip(this.components);
            this.flp1.SuspendLayout();
            this.tlpNodev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.Controls.Add(this.tlpNodev);
            this.flp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp1.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.flp1.Location = new System.Drawing.Point(0, 0);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(633, 608);
            this.flp1.TabIndex = 0;
            // 
            // tlpNodev
            // 
            this.tlpNodev.AutoSize = true;
            this.tlpNodev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpNodev.ColumnCount = 2;
            this.tlpNodev.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpNodev.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpNodev.Controls.Add(this.pictureBox1, 0, 0);
            this.tlpNodev.Controls.Add(this.linkLabel1, 1, 0);
            this.tlpNodev.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpNodev.Location = new System.Drawing.Point(3, 3);
            this.tlpNodev.Name = "tlpNodev";
            this.tlpNodev.RowCount = 1;
            this.tlpNodev.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpNodev.Size = new System.Drawing.Size(513, 41);
            this.tlpNodev.TabIndex = 0;
            this.tlpNodev.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EthernetLoopDetector.Properties.Resources._109_AllAnnotations_Warning_32x32_72;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(52, 3);
            this.linkLabel1.Location = new System.Drawing.Point(41, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(469, 41);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "デバイスが見付かりません。\r\n\r\nWinPcapを導入していて、動いているかどうかご確認ください。入手はこちらから。";
            this.ttUrl.SetToolTip(this.linkLabel1, "http://www.winpcap.org/");
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(633, 608);
            this.Controls.Add(this.flp1);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Ethernet ループ検出] デバイスを選択";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flp1.ResumeLayout(false);
            this.flp1.PerformLayout();
            this.tlpNodev.ResumeLayout(false);
            this.tlpNodev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.TableLayoutPanel tlpNodev;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip ttUrl;


    }
}

