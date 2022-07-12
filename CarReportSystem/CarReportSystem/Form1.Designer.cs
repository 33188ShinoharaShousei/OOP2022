
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCN
            // 
            this.cbCN.FormattingEnabled = true;
            this.cbCN.Location = new System.Drawing.Point(65, 122);
            this.cbCN.Name = "cbCN";
            this.cbCN.Size = new System.Drawing.Size(282, 20);
            this.cbCN.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(67, 14);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 19);
            this.dtpDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
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
            this.label9.Location = new System.Drawing.Point(653, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "画像：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(67, 87);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "トヨタ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(120, 87);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "日産";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(173, 87);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 16);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ホンダ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(230, 87);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 16);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "スバル";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(353, 87);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(54, 16);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "その他";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(288, 87);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(59, 16);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "外国車";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // cbRecorder
            // 
            this.cbRecorder.FormattingEnabled = true;
            this.cbRecorder.Location = new System.Drawing.Point(65, 52);
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
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(12, 376);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(47, 33);
            this.btsave.TabIndex = 7;
            this.btsave.Text = "保存";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // btadd
            // 
            this.btadd.Location = new System.Drawing.Point(517, 181);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(76, 26);
            this.btadd.TabIndex = 6;
            this.btadd.Text = "追加";
            this.btadd.UseVisualStyleBackColor = true;
            // 
            // piDelete
            // 
            this.piDelete.Location = new System.Drawing.Point(835, 13);
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
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(517, 265);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(76, 26);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // piopen
            // 
            this.piopen.Location = new System.Drawing.Point(739, 12);
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
            // 
            // dgvCarReport
            // 
            this.dgvCarReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarReport.Location = new System.Drawing.Point(65, 297);
            this.dgvCarReport.Name = "dgvCarReport";
            this.dgvCarReport.RowTemplate.Height = 21;
            this.dgvCarReport.Size = new System.Drawing.Size(908, 189);
            this.dgvCarReport.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(668, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 247);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 531);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
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
            this.Name = "Form1";
            this.Text = "試験レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

