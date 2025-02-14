namespace VRC_SnapArchive
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // 既存のコントロール
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        private System.Windows.Forms.ToolTip toolTip1;

        // 既存のグループ用コントロール
        private System.Windows.Forms.Label labelGroupHeader;
        private System.Windows.Forms.CheckBox checkBoxFileDetail;
        private System.Windows.Forms.GroupBox groupBoxFolderGrouping;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonDay;

        // 新規追加：圧縮先選択用のコントロール
        private System.Windows.Forms.Label labelCompressDestination;
        private System.Windows.Forms.TextBox textBoxCompress;
        private System.Windows.Forms.Button btnCompressBrowse;
        private System.Windows.Forms.PictureBox pictureBoxCompressInfo;
        
        // 新規追加：7Zip圧縮方式選択用のコントロール
        private System.Windows.Forms.Label labelCompressionMethod;
        private System.Windows.Forms.RadioButton radioButtonLossless;
        private System.Windows.Forms.RadioButton radioButtonStandard;
        private System.Windows.Forms.Label labelLosslessNote;

        // 変数宣言部に以下を追加
        private System.Windows.Forms.PictureBox pictureBoxFileDetailInfo;

        // 新規追加：月ごとにファイルを圧縮するチェックボックス
        private System.Windows.Forms.CheckBox checkBoxCompress;

        // 新規追加：終了ボタンと適応ボタン
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;

        // 新規追加：出力先指定用のコントロール
        private System.Windows.Forms.CheckBox checkBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnOutputBrowse;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棋する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelGroupHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxFileDetailInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxCompressInfo = new System.Windows.Forms.PictureBox();
            this.checkBoxFileDetail = new System.Windows.Forms.CheckBox();
            this.groupBoxFolderGrouping = new System.Windows.Forms.GroupBox();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.labelCompressDestination = new System.Windows.Forms.Label();
            this.textBoxCompress = new System.Windows.Forms.TextBox();
            this.btnCompressBrowse = new System.Windows.Forms.Button();
            this.labelCompressionMethod = new System.Windows.Forms.Label();
            this.radioButtonLossless = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.labelLosslessNote = new System.Windows.Forms.Label();
            this.checkBoxCompress = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.checkBoxOutput = new System.Windows.Forms.CheckBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnOutputBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileDetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressInfo)).BeginInit();
            this.groupBoxFolderGrouping.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGroupHeader
            // 
            this.labelGroupHeader.AutoSize = true;
            this.labelGroupHeader.Font = new System.Drawing.Font("ＭＳ 明朝", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelGroupHeader.Location = new System.Drawing.Point(12, 10);
            this.labelGroupHeader.Name = "labelGroupHeader";
            this.labelGroupHeader.Size = new System.Drawing.Size(110, 24);
            this.labelGroupHeader.TabIndex = 0;
            this.labelGroupHeader.Text = "ファイル";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ゲーム内写真の保存先(参照)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 25);
            this.textBox1.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(620, 75);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "参照...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfo.Image")));
            this.pictureBoxInfo.Location = new System.Drawing.Point(287, 36);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInfo.TabIndex = 18;
            this.pictureBoxInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxInfo, "ここでVRCの写真の保存先を指定してください\n※選択されたファイルのパスが表示されます。");
            // 
            // pictureBoxFileDetailInfo
            // 
            this.pictureBoxFileDetailInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFileDetailInfo.Image")));
            this.pictureBoxFileDetailInfo.Location = new System.Drawing.Point(220, 113);
            this.pictureBoxFileDetailInfo.Name = "pictureBoxFileDetailInfo";
            this.pictureBoxFileDetailInfo.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxFileDetailInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFileDetailInfo.TabIndex = 17;
            this.pictureBoxFileDetailInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxFileDetailInfo, "チェックを入れると、単位ごとにフォルダ分けされます。");
            // 
            // pictureBoxCompressInfo
            // 
            this.pictureBoxCompressInfo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCompressInfo.Image")));
            this.pictureBoxCompressInfo.Location = new System.Drawing.Point(235, 346);
            this.pictureBoxCompressInfo.Name = "pictureBoxCompressInfo";
            this.pictureBoxCompressInfo.Size = new System.Drawing.Size(24, 24);
            this.pictureBoxCompressInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCompressInfo.TabIndex = 16;
            this.pictureBoxCompressInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCompressInfo, "月ごとに圧縮しファイル容量を削減します");
            // 
            // checkBoxFileDetail
            // 
            this.checkBoxFileDetail.AutoSize = true;
            this.checkBoxFileDetail.Location = new System.Drawing.Point(12, 115);
            this.checkBoxFileDetail.Name = "checkBoxFileDetail";
            this.checkBoxFileDetail.Size = new System.Drawing.Size(202, 22);
            this.checkBoxFileDetail.TabIndex = 4;
            this.checkBoxFileDetail.Text = "ファイルを細かく保存する";
            // 
            // groupBoxFolderGrouping
            // 
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonMonth);
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonWeek);
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonDay);
            this.groupBoxFolderGrouping.Enabled = false;
            this.groupBoxFolderGrouping.Location = new System.Drawing.Point(12, 140);
            this.groupBoxFolderGrouping.Name = "groupBoxFolderGrouping";
            this.groupBoxFolderGrouping.Size = new System.Drawing.Size(300, 60);
            this.groupBoxFolderGrouping.TabIndex = 5;
            this.groupBoxFolderGrouping.TabStop = false;
            this.groupBoxFolderGrouping.Text = "フォルダ分け";
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Location = new System.Drawing.Point(10, 25);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(83, 22);
            this.radioButtonMonth.TabIndex = 0;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "月単位";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Location = new System.Drawing.Point(100, 25);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(83, 22);
            this.radioButtonWeek.TabIndex = 1;
            this.radioButtonWeek.TabStop = true;
            this.radioButtonWeek.Text = "週単位";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Location = new System.Drawing.Point(190, 25);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(83, 22);
            this.radioButtonDay.TabIndex = 2;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "日単位";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // labelCompressDestination
            // 
            this.labelCompressDestination.AutoSize = true;
            this.labelCompressDestination.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompressDestination.Location = new System.Drawing.Point(12, 280);
            this.labelCompressDestination.Name = "labelCompressDestination";
            this.labelCompressDestination.Size = new System.Drawing.Size(229, 20);
            this.labelCompressDestination.TabIndex = 6;
            this.labelCompressDestination.Text = "圧縮先のフォルダ(参照)";
            // 
            // textBoxCompress
            // 
            this.textBoxCompress.Location = new System.Drawing.Point(12, 315);
            this.textBoxCompress.Name = "textBoxCompress";
            this.textBoxCompress.Size = new System.Drawing.Size(600, 25);
            this.textBoxCompress.TabIndex = 7;
            // 
            // btnCompressBrowse
            // 
            this.btnCompressBrowse.Location = new System.Drawing.Point(620, 315);
            this.btnCompressBrowse.Name = "btnCompressBrowse";
            this.btnCompressBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnCompressBrowse.TabIndex = 8;
            this.btnCompressBrowse.Text = "参照...";
            this.btnCompressBrowse.UseVisualStyleBackColor = true;
            this.btnCompressBrowse.Click += new System.EventHandler(this.btnCompressBrowse_Click);
            // 
            // labelCompressionMethod
            // 
            this.labelCompressionMethod.AutoSize = true;
            this.labelCompressionMethod.Font = new System.Drawing.Font("ＭＳ 明朝", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCompressionMethod.Location = new System.Drawing.Point(12, 380);
            this.labelCompressionMethod.Name = "labelCompressionMethod";
            this.labelCompressionMethod.Size = new System.Drawing.Size(109, 20);
            this.labelCompressionMethod.TabIndex = 12;
            this.labelCompressionMethod.Text = "圧縮方式：";
            this.labelCompressionMethod.Visible = false;
            // 
            // radioButtonLossless
            // 
            this.radioButtonLossless.AutoSize = true;
            this.radioButtonLossless.Location = new System.Drawing.Point(140, 380);
            this.radioButtonLossless.Name = "radioButtonLossless";
            this.radioButtonLossless.Size = new System.Drawing.Size(84, 22);
            this.radioButtonLossless.TabIndex = 13;
            this.radioButtonLossless.TabStop = true;
            this.radioButtonLossless.Text = "ロスレス";
            this.radioButtonLossless.UseVisualStyleBackColor = true;
            this.radioButtonLossless.Visible = false;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(220, 380);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(101, 22);
            this.radioButtonStandard.TabIndex = 14;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "標準圧縮";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            this.radioButtonStandard.Visible = false;
            // 
            // labelLosslessNote
            // 
            this.labelLosslessNote.AutoSize = true;
            this.labelLosslessNote.Font = new System.Drawing.Font("ＭＳ 明朝", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelLosslessNote.ForeColor = System.Drawing.Color.Red;
            this.labelLosslessNote.Location = new System.Drawing.Point(12, 410);
            this.labelLosslessNote.Name = "labelLosslessNote";
            this.labelLosslessNote.Size = new System.Drawing.Size(512, 17);
            this.labelLosslessNote.TabIndex = 15;
            this.labelLosslessNote.Text = "※完全可逆圧縮を選択すると、解凍時に画質劣化を防げます。";
            this.labelLosslessNote.Visible = false;
            // 
            // checkBoxCompress
            // 
            this.checkBoxCompress.AutoSize = true;
            this.checkBoxCompress.Location = new System.Drawing.Point(12, 350);
            this.checkBoxCompress.Name = "checkBoxCompress";
            this.checkBoxCompress.Size = new System.Drawing.Size(217, 22);
            this.checkBoxCompress.TabIndex = 9;
            this.checkBoxCompress.Text = "月ごとにファイルを圧縮する";
            this.checkBoxCompress.UseVisualStyleBackColor = true;
            this.checkBoxCompress.CheckedChanged += new System.EventHandler(this.checkBoxCompress_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(680, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(560, 400);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 30);
            this.btnApply.TabIndex = 21;
            this.btnApply.Text = "適応";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkBoxOutput
            // 
            this.checkBoxOutput.AutoSize = true;
            this.checkBoxOutput.Location = new System.Drawing.Point(12, 210);
            this.checkBoxOutput.Name = "checkBoxOutput";
            this.checkBoxOutput.Size = new System.Drawing.Size(163, 22);
            this.checkBoxOutput.TabIndex = 6;
            this.checkBoxOutput.Text = "出力先を指定する";
            this.checkBoxOutput.UseVisualStyleBackColor = true;
            this.checkBoxOutput.CheckedChanged += new System.EventHandler(this.checkBoxOutput_CheckedChanged);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 240);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(600, 25);
            this.textBoxOutput.TabIndex = 7;
            this.textBoxOutput.Visible = false;
            // 
            // btnOutputBrowse
            // 
            this.btnOutputBrowse.Location = new System.Drawing.Point(620, 240);
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnOutputBrowse.TabIndex = 8;
            this.btnOutputBrowse.Text = "参照...";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Visible = false;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxOutput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.btnOutputBrowse);
            this.Controls.Add(this.checkBoxCompress);
            this.Controls.Add(this.labelLosslessNote);
            this.Controls.Add(this.radioButtonStandard);
            this.Controls.Add(this.radioButtonLossless);
            this.Controls.Add(this.labelCompressionMethod);
            this.Controls.Add(this.pictureBoxCompressInfo);
            this.Controls.Add(this.btnCompressBrowse);
            this.Controls.Add(this.textBoxCompress);
            this.Controls.Add(this.labelCompressDestination);
            this.Controls.Add(this.groupBoxFolderGrouping);
            this.Controls.Add(this.pictureBoxFileDetailInfo);
            this.Controls.Add(this.checkBoxFileDetail);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelGroupHeader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileDetailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressInfo)).EndInit();
            this.groupBoxFolderGrouping.ResumeLayout(false);
            this.groupBoxFolderGrouping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

