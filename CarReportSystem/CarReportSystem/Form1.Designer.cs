
namespace CarReportSystem {
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
            this.cbCN = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.rbNissan = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbother = new System.Windows.Forms.RadioButton();
            this.rbForeign = new System.Windows.Forms.RadioButton();
            this.cbRecorder = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.open = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.piDelete = new System.Windows.Forms.Button();
            this.btcorrect = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.piopen = new System.Windows.Forms.Button();
            this.btend = new System.Windows.Forms.Button();
            this.dgvCarReport = new System.Windows.Forms.DataGridView();
            this.pbCar = new System.Windows.Forms.PictureBox();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.ofdOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.終了ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCN
            // 
            this.cbCN.FormattingEnabled = true;
            this.cbCN.Location = new System.Drawing.Point(65, 122);
            this.cbCN.Name = "cbCN";
            this.cbCN.Size = new System.Drawing.Size(291, 20);
            this.cbCN.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(67, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "記録者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "メーカー：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "レポート：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "記事一覧：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "画像：";
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(67, 87);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 4;
            this.rbToyota.TabStop = true;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            this.rbNissan.AutoSize = true;
            this.rbNissan.Location = new System.Drawing.Point(120, 87);
            this.rbNissan.Name = "rbNissan";
            this.rbNissan.Size = new System.Drawing.Size(47, 16);
            this.rbNissan.TabIndex = 4;
            this.rbNissan.TabStop = true;
            this.rbNissan.Text = "日産";
            this.rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(173, 87);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 4;
            this.rbHonda.TabStop = true;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(230, 87);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 4;
            this.rbSubaru.TabStop = true;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbother
            // 
            this.rbother.AutoSize = true;
            this.rbother.Location = new System.Drawing.Point(353, 87);
            this.rbother.Name = "rbother";
            this.rbother.Size = new System.Drawing.Size(54, 16);
            this.rbother.TabIndex = 4;
            this.rbother.TabStop = true;
            this.rbother.Text = "その他";
            this.rbother.UseVisualStyleBackColor = true;
            // 
            // rbForeign
            // 
            this.rbForeign.AutoSize = true;
            this.rbForeign.Location = new System.Drawing.Point(288, 87);
            this.rbForeign.Name = "rbForeign";
            this.rbForeign.Size = new System.Drawing.Size(59, 16);
            this.rbForeign.TabIndex = 4;
            this.rbForeign.TabStop = true;
            this.rbForeign.Text = "外国車";
            this.rbForeign.UseVisualStyleBackColor = true;
            // 
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(65, 57);
            this.cbRecorder.Name = "cbRecorder";
            this.cbRecorder.Size = new System.Drawing.Size(291, 20);
            this.cbRecorder.TabIndex = 0;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(65, 157);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(436, 134);
            this.tbReport.TabIndex = 5;
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(12, 333);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(47, 37);
            this.open.TabIndex = 6;
            this.open.Text = "開く";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.Open_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(12, 376);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(47, 33);
            this.btsave.TabIndex = 7;
            this.btsave.Text = "保存";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(517, 181);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(76, 26);
            this.btadd.TabIndex = 6;
            this.btadd.Text = "追加";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // piDelete
            // 
            this.piDelete.Location = new System.Drawing.Point(776, 25);
            this.piDelete.Name = "piDelete";
            this.piDelete.Size = new System.Drawing.Size(78, 25);
            this.piDelete.TabIndex = 6;
            this.piDelete.Text = "削除";
            this.piDelete.UseVisualStyleBackColor = true;
            // 
            // btcorrect
            // 
            this.btcorrect.Location = new System.Drawing.Point(517, 222);
            this.btcorrect.Name = "btcorrect";
            this.btcorrect.Size = new System.Drawing.Size(76, 28);
            this.btcorrect.TabIndex = 6;
            this.btcorrect.Text = "修正";
            this.btcorrect.UseVisualStyleBackColor = true;
            this.btcorrect.Click += new System.EventHandler(this.btcorrect_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(517, 265);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(76, 26);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // piopen
            // 
            this.piopen.Location = new System.Drawing.Point(694, 25);
            this.piopen.Name = "piopen";
            this.piopen.Size = new System.Drawing.Size(76, 26);
            this.piopen.TabIndex = 6;
            this.piopen.Text = "開く";
            this.piopen.UseVisualStyleBackColor = true;
            // 
            // btend
            // 
            this.btend.Location = new System.Drawing.Point(899, 493);
            this.btend.Name = "btend";
            this.btend.Size = new System.Drawing.Size(76, 26);
            this.btend.TabIndex = 6;
            this.btend.Text = "終了";
            this.btend.UseVisualStyleBackColor = true;
            this.btend.Click += new System.EventHandler(this.btend_Click);
            // 
            // dgvCarReport
            // 
            this.dgvCarReport.AllowUserToAddRows = false;
            this.dgvCarReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReport.Location = new System.Drawing.Point(65, 297);
            this.dgvCarReport.Name = "dgvCarReport";
            this.dgvCarReport.ReadOnly = true;
            this.dgvCarReport.RowTemplate.Height = 21;
            this.dgvCarReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarReport.Size = new System.Drawing.Size(908, 189);
            this.dgvCarReport.TabIndex = 8;
            this.dgvCarReport.Click += new System.EventHandler(this.dgvCarReport_Click);
            // 
            // pbCar
            // 
            this.pbCar.Location = new System.Drawing.Point(668, 57);
            this.pbCar.Name = "pbCar";
            this.pbCar.Size = new System.Drawing.Size(267, 234);
            this.pbCar.TabIndex = 9;
            this.pbCar.TabStop = false;
            // 
            // ofdOpenDialog
            // 
            this.ofdOpenDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了ToolStripMenuItem,
            this.toolStripSeparator2,
            this.終了ToolStripMenuItem1});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くToolStripMenuItem.Text = "開く...";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.Open_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存ToolStripMenuItem.Text = "保存...";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.btSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem.Text = "色設定...";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.ColorSetting_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // 終了ToolStripMenuItem1
            // 
            this.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1";
            this.終了ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.終了ToolStripMenuItem1.Text = "終了";
            this.終了ToolStripMenuItem1.Click += new System.EventHandler(this.btend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "★";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ColorSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbCar);
            this.Controls.Add(this.dgvCarReport);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.piDelete);
            this.Controls.Add(this.btend);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btcorrect);
            this.Controls.Add(this.piopen);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.open);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.rbForeign);
            this.Controls.Add(this.rbother);
            this.Controls.Add(this.rbSubaru);
            this.Controls.Add(this.rbHonda);
            this.Controls.Add(this.rbNissan);
            this.Controls.Add(this.rbToyota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbRecorder);
            this.Controls.Add(this.cbCN);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試験レポート管理システム";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCN;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.RadioButton rbNissan;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbother;
        private System.Windows.Forms.RadioButton rbForeign;
        private System.Windows.Forms.ComboBox cbRecorder;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button piDelete;
        private System.Windows.Forms.Button btcorrect;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button piopen;
        private System.Windows.Forms.Button btend;
        private System.Windows.Forms.DataGridView dgvCarReport;
        private System.Windows.Forms.PictureBox pbCar;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.OpenFileDialog ofdOpenDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}

