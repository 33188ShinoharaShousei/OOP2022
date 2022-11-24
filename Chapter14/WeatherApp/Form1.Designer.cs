
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btWeathorGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.weatherPic = new System.Windows.Forms.PictureBox();
            this.Area = new System.Windows.Forms.Label();
            this.psOffices = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeathorGet
            // 
            this.btWeathorGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btWeathorGet.Location = new System.Drawing.Point(12, 12);
            this.btWeathorGet.Name = "btWeathorGet";
            this.btWeathorGet.Size = new System.Drawing.Size(112, 39);
            this.btWeathorGet.TabIndex = 1;
            this.btWeathorGet.Text = "取得";
            this.btWeathorGet.UseVisualStyleBackColor = true;
            this.btWeathorGet.Click += new System.EventHandler(this.btWeathorGet_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域";
            // 
            // cbarea
            // 
            this.cbarea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Location = new System.Drawing.Point(244, 22);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(149, 20);
            this.cbarea.TabIndex = 6;
            this.cbarea.SelectedIndexChanged += new System.EventHandler(this.cbarea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(462, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "発表者";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(10, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 26);
            this.label8.TabIndex = 7;
            this.label8.Text = "概要";
            // 
            // weatherPic
            // 
            this.weatherPic.BackColor = System.Drawing.Color.Transparent;
            this.weatherPic.Image = global::WeatherApp.Properties.Resources.mark_tenki_hare;
            this.weatherPic.Location = new System.Drawing.Point(478, 85);
            this.weatherPic.Name = "weatherPic";
            this.weatherPic.Size = new System.Drawing.Size(309, 235);
            this.weatherPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherPic.TabIndex = 10;
            this.weatherPic.TabStop = false;
            this.weatherPic.Click += new System.EventHandler(this.weatherPic_Click);
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.Transparent;
            this.Area.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Area.Location = new System.Drawing.Point(415, 12);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(372, 39);
            this.Area.TabIndex = 11;
            // 
            // psOffices
            // 
            this.psOffices.BackColor = System.Drawing.Color.Transparent;
            this.psOffices.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.psOffices.Location = new System.Drawing.Point(540, 408);
            this.psOffices.Name = "psOffices";
            this.psOffices.Size = new System.Drawing.Size(247, 26);
            this.psOffices.TabIndex = 12;
            // 
            // data
            // 
            this.data.AutoEllipsis = true;
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.data.Location = new System.Drawing.Point(66, 269);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(378, 172);
            this.data.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.スクリーンショット__6_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.psOffices);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.weatherPic);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeathorGet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "天気概況アプリ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btWeathorGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox weatherPic;
        private System.Windows.Forms.Label Area;
        private System.Windows.Forms.Label psOffices;
        private System.Windows.Forms.Label data;
    }
}

