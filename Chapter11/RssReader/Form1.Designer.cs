﻿
namespace RssReader {
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
            this.btRssGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.btBack = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.wvBrowser = new Microsoft.Toolkit.Forms.UI.Controls.WebView();
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).BeginInit();
            this.SuspendLayout();
            // 
            // btRssGet
            // 
            this.btRssGet.Location = new System.Drawing.Point(900, 11);
            this.btRssGet.Name = "btRssGet";
            this.btRssGet.Size = new System.Drawing.Size(75, 23);
            this.btRssGet.TabIndex = 0;
            this.btRssGet.Text = "取得";
            this.btRssGet.UseVisualStyleBackColor = true;
            this.btRssGet.Click += new System.EventHandler(this.btRssGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 42);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(202, 580);
            this.lbRssTitle.TabIndex = 1;
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(13, 13);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(881, 20);
            this.cbRssUrl.TabIndex = 3;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(985, 11);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(32, 23);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "←";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.bt_Click);
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(1023, 11);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(30, 23);
            this.btForward.TabIndex = 5;
            this.btForward.Text = "→";
            this.btForward.UseVisualStyleBackColor = true;
            // 
            // wvBrowser
            // 
            this.wvBrowser.Location = new System.Drawing.Point(239, 42);
            this.wvBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wvBrowser.Name = "wvBrowser";
            this.wvBrowser.Size = new System.Drawing.Size(814, 580);
            this.wvBrowser.TabIndex = 6;
            this.wvBrowser.NavigationCompleted += new System.EventHandler<Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs>(this.wvBrowser_NavigationCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 656);
            this.Controls.Add(this.wvBrowser);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btRssGet);
            this.Name = "Form1";
            this.Text = "RSSReader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvBrowser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRssGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btForward;
        private Microsoft.Toolkit.Forms.UI.Controls.WebView wvBrowser;
    }
}

