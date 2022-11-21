
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
            this.btWeathorGet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbarea = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.TextBox();
            this.psOffices = new System.Windows.Forms.TextBox();
            this.Area = new System.Windows.Forms.TextBox();
            this.weatherPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btWeathorGet
            // 
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
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域";
            // 
            // cbarea
            // 
            this.cbarea.FormattingEnabled = true;
            this.cbarea.Location = new System.Drawing.Point(244, 22);
            this.cbarea.Name = "cbarea";
            this.cbarea.Size = new System.Drawing.Size(149, 20);
            this.cbarea.TabIndex = 6;
            this.cbarea.SelectedIndexChanged += new System.EventHandler(this.cbarea_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "発表者";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "概要";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(47, 296);
            this.data.Multiline = true;
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(362, 142);
            this.data.TabIndex = 8;
            // 
            // psOffices
            // 
            this.psOffices.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.psOffices.Location = new System.Drawing.Point(551, 406);
            this.psOffices.Multiline = true;
            this.psOffices.Name = "psOffices";
            this.psOffices.Size = new System.Drawing.Size(237, 32);
            this.psOffices.TabIndex = 8;
            // 
            // Area
            // 
            this.Area.Font = new System.Drawing.Font("MS UI Gothic", 45F);
            this.Area.Location = new System.Drawing.Point(469, 12);
            this.Area.Multiline = true;
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(318, 68);
            this.Area.TabIndex = 9;
            // 
            // weatherPic
            // 
            this.weatherPic.Location = new System.Drawing.Point(47, 90);
            this.weatherPic.Name = "weatherPic";
            this.weatherPic.Size = new System.Drawing.Size(167, 140);
            this.weatherPic.TabIndex = 10;
            this.weatherPic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.スクリーンショット__6_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weatherPic);
            this.Controls.Add(this.Area);
            this.Controls.Add(this.psOffices);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btWeathorGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weatherPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btWeathorGet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox psOffices;
        private System.Windows.Forms.TextBox Area;
        private System.Windows.Forms.PictureBox weatherPic;
    }
}

