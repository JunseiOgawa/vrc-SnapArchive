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

        // 新規追加：TabControl 等の生成
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.TabPage tabPageCompress;
        // 新規追加：追加のタブ
        private System.Windows.Forms.TabPage tabPageExtract;
        private System.Windows.Forms.TabPage tabPagePhotoInfo;

        // 新規追加：解凍タブ用のコントロール
        private System.Windows.Forms.Button btnSelectArchives;
        private System.Windows.Forms.ListBox listBoxArchives;
        private System.Windows.Forms.TextBox textBoxExtractDest;

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
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPageCompress = new System.Windows.Forms.TabPage();
            this.tabPageExtract = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectArchives = new System.Windows.Forms.Button();
            this.listBoxArchives = new System.Windows.Forms.ListBox();
            this.textBoxExtractDest = new System.Windows.Forms.TextBox();
            this.tabPagePhotoInfo = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileDetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressInfo)).BeginInit();
            this.groupBoxFolderGrouping.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.tabPageCompress.SuspendLayout();
            this.tabPageExtract.SuspendLayout();
            this.tabPagePhotoInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGroupHeader
            // 
            resources.ApplyResources(this.labelGroupHeader, "labelGroupHeader");
            this.labelGroupHeader.Name = "labelGroupHeader";
            this.labelGroupHeader.Click += new System.EventHandler(this.labelGroupHeader_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pictureBoxInfo
            // 
            resources.ApplyResources(this.pictureBoxInfo, "pictureBoxInfo");
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxInfo, resources.GetString("pictureBoxInfo.ToolTip"));
            // 
            // pictureBoxFileDetailInfo
            // 
            resources.ApplyResources(this.pictureBoxFileDetailInfo, "pictureBoxFileDetailInfo");
            this.pictureBoxFileDetailInfo.Name = "pictureBoxFileDetailInfo";
            this.pictureBoxFileDetailInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxFileDetailInfo, resources.GetString("pictureBoxFileDetailInfo.ToolTip"));
            this.pictureBoxFileDetailInfo.Click += new System.EventHandler(this.pictureBoxFileDetailInfo_Click);
            // 
            // pictureBoxCompressInfo
            // 
            resources.ApplyResources(this.pictureBoxCompressInfo, "pictureBoxCompressInfo");
            this.pictureBoxCompressInfo.Name = "pictureBoxCompressInfo";
            this.pictureBoxCompressInfo.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBoxCompressInfo, resources.GetString("pictureBoxCompressInfo.ToolTip"));
            // 
            // checkBoxFileDetail
            // 
            resources.ApplyResources(this.checkBoxFileDetail, "checkBoxFileDetail");
            this.checkBoxFileDetail.Name = "checkBoxFileDetail";
            this.checkBoxFileDetail.CheckedChanged += new System.EventHandler(this.checkBoxFileDetail_CheckedChanged);
            // 
            // groupBoxFolderGrouping
            // 
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonMonth);
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonWeek);
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonDay);
            resources.ApplyResources(this.groupBoxFolderGrouping, "groupBoxFolderGrouping");
            this.groupBoxFolderGrouping.Name = "groupBoxFolderGrouping";
            this.groupBoxFolderGrouping.TabStop = false;
            // 
            // radioButtonMonth
            // 
            resources.ApplyResources(this.radioButtonMonth, "radioButtonMonth");
            this.radioButtonMonth.Checked = true;
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            resources.ApplyResources(this.radioButtonWeek, "radioButtonWeek");
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            resources.ApplyResources(this.radioButtonDay, "radioButtonDay");
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // labelCompressDestination
            // 
            resources.ApplyResources(this.labelCompressDestination, "labelCompressDestination");
            this.labelCompressDestination.Name = "labelCompressDestination";
            // 
            // textBoxCompress
            // 
            resources.ApplyResources(this.textBoxCompress, "textBoxCompress");
            this.textBoxCompress.Name = "textBoxCompress";
            // 
            // btnCompressBrowse
            // 
            resources.ApplyResources(this.btnCompressBrowse, "btnCompressBrowse");
            this.btnCompressBrowse.Name = "btnCompressBrowse";
            this.btnCompressBrowse.UseVisualStyleBackColor = true;
            this.btnCompressBrowse.Click += new System.EventHandler(this.btnCompressBrowse_Click);
            // 
            // labelCompressionMethod
            // 
            resources.ApplyResources(this.labelCompressionMethod, "labelCompressionMethod");
            this.labelCompressionMethod.Name = "labelCompressionMethod";
            // 
            // radioButtonLossless
            // 
            resources.ApplyResources(this.radioButtonLossless, "radioButtonLossless");
            this.radioButtonLossless.Name = "radioButtonLossless";
            this.radioButtonLossless.TabStop = true;
            this.radioButtonLossless.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandard
            // 
            resources.ApplyResources(this.radioButtonStandard, "radioButtonStandard");
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // labelLosslessNote
            // 
            resources.ApplyResources(this.labelLosslessNote, "labelLosslessNote");
            this.labelLosslessNote.ForeColor = System.Drawing.Color.Red;
            this.labelLosslessNote.Name = "labelLosslessNote";
            // 
            // checkBoxCompress
            // 
            resources.ApplyResources(this.checkBoxCompress, "checkBoxCompress");
            this.checkBoxCompress.Name = "checkBoxCompress";
            this.checkBoxCompress.UseVisualStyleBackColor = true;
            this.checkBoxCompress.CheckedChanged += new System.EventHandler(this.checkBoxCompress_CheckedChanged);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkBoxOutput
            // 
            resources.ApplyResources(this.checkBoxOutput, "checkBoxOutput");
            this.checkBoxOutput.Name = "checkBoxOutput";
            this.checkBoxOutput.UseVisualStyleBackColor = true;
            this.checkBoxOutput.CheckedChanged += new System.EventHandler(this.checkBoxOutput_CheckedChanged);
            // 
            // textBoxOutput
            // 
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // btnOutputBrowse
            // 
            resources.ApplyResources(this.btnOutputBrowse, "btnOutputBrowse");
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControlMain
            // 
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.tabPageFile);
            this.tabControlMain.Controls.Add(this.tabPageCompress);
            this.tabControlMain.Controls.Add(this.tabPageExtract);
            this.tabControlMain.Controls.Add(this.tabPagePhotoInfo);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Tag = "";
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.pictureBox2);
            this.tabPageFile.Controls.Add(this.pictureBox1);
            this.tabPageFile.Controls.Add(this.comboBox1);
            this.tabPageFile.Controls.Add(this.pictureBoxFileDetailInfo);
            this.tabPageFile.Controls.Add(this.checkBox1);
            this.tabPageFile.Controls.Add(this.labelGroupHeader);
            this.tabPageFile.Controls.Add(this.label1);
            this.tabPageFile.Controls.Add(this.textBox1);
            this.tabPageFile.Controls.Add(this.btnBrowse);
            this.tabPageFile.Controls.Add(this.pictureBoxInfo);
            this.tabPageFile.Controls.Add(this.checkBoxFileDetail);
            this.tabPageFile.Controls.Add(this.groupBoxFolderGrouping);
            this.tabPageFile.Controls.Add(this.checkBoxOutput);
            this.tabPageFile.Controls.Add(this.textBoxOutput);
            this.tabPageFile.Controls.Add(this.btnOutputBrowse);
            resources.ApplyResources(this.tabPageFile, "tabPageFile");
            this.tabPageFile.Name = "tabPageFile";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabPageCompress
            // 
            this.tabPageCompress.Controls.Add(this.labelCompressDestination);
            this.tabPageCompress.Controls.Add(this.textBoxCompress);
            this.tabPageCompress.Controls.Add(this.btnCompressBrowse);
            this.tabPageCompress.Controls.Add(this.pictureBoxCompressInfo);
            this.tabPageCompress.Controls.Add(this.checkBoxCompress);
            this.tabPageCompress.Controls.Add(this.labelCompressionMethod);
            this.tabPageCompress.Controls.Add(this.radioButtonLossless);
            this.tabPageCompress.Controls.Add(this.radioButtonStandard);
            this.tabPageCompress.Controls.Add(this.labelLosslessNote);
            this.tabPageCompress.Controls.Add(this.label2);
            resources.ApplyResources(this.tabPageCompress, "tabPageCompress");
            this.tabPageCompress.Name = "tabPageCompress";
            // 
            // tabPageExtract
            // 
            this.tabPageExtract.Controls.Add(this.label3);
            this.tabPageExtract.Controls.Add(this.btnSelectArchives);
            this.tabPageExtract.Controls.Add(this.listBoxArchives);
            this.tabPageExtract.Controls.Add(this.textBoxExtractDest);
            resources.ApplyResources(this.tabPageExtract, "tabPageExtract");
            this.tabPageExtract.Name = "tabPageExtract";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSelectArchives
            // 
            resources.ApplyResources(this.btnSelectArchives, "btnSelectArchives");
            this.btnSelectArchives.Name = "btnSelectArchives";
            this.btnSelectArchives.UseVisualStyleBackColor = true;
            this.btnSelectArchives.Click += new System.EventHandler(this.btnSelectArchives_Click);
            // 
            // listBoxArchives
            // 
            this.listBoxArchives.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxArchives, "listBoxArchives");
            this.listBoxArchives.Name = "listBoxArchives";
            // 
            // textBoxExtractDest
            // 
            resources.ApplyResources(this.textBoxExtractDest, "textBoxExtractDest");
            this.textBoxExtractDest.Name = "textBoxExtractDest";
            // 
            // tabPagePhotoInfo
            // 
            this.tabPagePhotoInfo.Controls.Add(this.label4);
            resources.ApplyResources(this.tabPagePhotoInfo, "tabPagePhotoInfo");
            this.tabPagePhotoInfo.Name = "tabPagePhotoInfo";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileDetailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressInfo)).EndInit();
            this.groupBoxFolderGrouping.ResumeLayout(false);
            this.groupBoxFolderGrouping.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            this.tabPageCompress.ResumeLayout(false);
            this.tabPageCompress.PerformLayout();
            this.tabPageExtract.ResumeLayout(false);
            this.tabPageExtract.PerformLayout();
            this.tabPagePhotoInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

