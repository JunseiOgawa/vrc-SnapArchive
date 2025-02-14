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
            this.tabPageCompress = new System.Windows.Forms.TabPage();
            // 新規追加：タブの生成
            this.tabPageExtract = new System.Windows.Forms.TabPage();
            this.tabPagePhotoInfo = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileDetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCompressInfo)).BeginInit();
            this.groupBoxFolderGrouping.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.tabPageCompress.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGroupHeader
            // 
            resources.ApplyResources(this.labelGroupHeader, "labelGroupHeader");
            this.labelGroupHeader.Name = "labelGroupHeader";
            this.toolTip1.SetToolTip(this.labelGroupHeader, resources.GetString("labelGroupHeader.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.toolTip1.SetToolTip(this.textBox1, resources.GetString("textBox1.ToolTip"));
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.toolTip1.SetToolTip(this.btnBrowse, resources.GetString("btnBrowse.ToolTip"));
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
            this.toolTip1.SetToolTip(this.checkBoxFileDetail, resources.GetString("checkBoxFileDetail.ToolTip"));
            this.checkBoxFileDetail.CheckedChanged += new System.EventHandler(this.checkBoxFileDetail_CheckedChanged);
            // 
            // groupBoxFolderGrouping
            // 
            resources.ApplyResources(this.groupBoxFolderGrouping, "groupBoxFolderGrouping");
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonMonth);
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonWeek);
            this.groupBoxFolderGrouping.Controls.Add(this.radioButtonDay);
            this.groupBoxFolderGrouping.Name = "groupBoxFolderGrouping";
            this.groupBoxFolderGrouping.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBoxFolderGrouping, resources.GetString("groupBoxFolderGrouping.ToolTip"));
            // 
            // radioButtonMonth
            // 
            resources.ApplyResources(this.radioButtonMonth, "radioButtonMonth");
            this.radioButtonMonth.Checked = true;
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonMonth, resources.GetString("radioButtonMonth.ToolTip"));
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            resources.ApplyResources(this.radioButtonWeek, "radioButtonWeek");
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.toolTip1.SetToolTip(this.radioButtonWeek, resources.GetString("radioButtonWeek.ToolTip"));
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonDay
            // 
            resources.ApplyResources(this.radioButtonDay, "radioButtonDay");
            this.radioButtonDay.Name = "radioButtonDay";
            this.toolTip1.SetToolTip(this.radioButtonDay, resources.GetString("radioButtonDay.ToolTip"));
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // labelCompressDestination
            // 
            resources.ApplyResources(this.labelCompressDestination, "labelCompressDestination");
            this.labelCompressDestination.Name = "labelCompressDestination";
            this.toolTip1.SetToolTip(this.labelCompressDestination, resources.GetString("labelCompressDestination.ToolTip"));
            // 
            // textBoxCompress
            // 
            resources.ApplyResources(this.textBoxCompress, "textBoxCompress");
            this.textBoxCompress.Name = "textBoxCompress";
            this.toolTip1.SetToolTip(this.textBoxCompress, resources.GetString("textBoxCompress.ToolTip"));
            // 
            // btnCompressBrowse
            // 
            resources.ApplyResources(this.btnCompressBrowse, "btnCompressBrowse");
            this.btnCompressBrowse.Name = "btnCompressBrowse";
            this.toolTip1.SetToolTip(this.btnCompressBrowse, resources.GetString("btnCompressBrowse.ToolTip"));
            this.btnCompressBrowse.UseVisualStyleBackColor = true;
            this.btnCompressBrowse.Click += new System.EventHandler(this.btnCompressBrowse_Click);
            // 
            // labelCompressionMethod
            // 
            resources.ApplyResources(this.labelCompressionMethod, "labelCompressionMethod");
            this.labelCompressionMethod.Name = "labelCompressionMethod";
            this.toolTip1.SetToolTip(this.labelCompressionMethod, resources.GetString("labelCompressionMethod.ToolTip"));
            // 
            // radioButtonLossless
            // 
            resources.ApplyResources(this.radioButtonLossless, "radioButtonLossless");
            this.radioButtonLossless.Name = "radioButtonLossless";
            this.radioButtonLossless.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonLossless, resources.GetString("radioButtonLossless.ToolTip"));
            this.radioButtonLossless.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandard
            // 
            resources.ApplyResources(this.radioButtonStandard, "radioButtonStandard");
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.TabStop = true;
            this.toolTip1.SetToolTip(this.radioButtonStandard, resources.GetString("radioButtonStandard.ToolTip"));
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // labelLosslessNote
            // 
            resources.ApplyResources(this.labelLosslessNote, "labelLosslessNote");
            this.labelLosslessNote.ForeColor = System.Drawing.Color.Red;
            this.labelLosslessNote.Name = "labelLosslessNote";
            this.toolTip1.SetToolTip(this.labelLosslessNote, resources.GetString("labelLosslessNote.ToolTip"));
            // 
            // checkBoxCompress
            // 
            resources.ApplyResources(this.checkBoxCompress, "checkBoxCompress");
            this.checkBoxCompress.Name = "checkBoxCompress";
            this.toolTip1.SetToolTip(this.checkBoxCompress, resources.GetString("checkBoxCompress.ToolTip"));
            this.checkBoxCompress.UseVisualStyleBackColor = true;
            this.checkBoxCompress.CheckedChanged += new System.EventHandler(this.checkBoxCompress_CheckedChanged);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.toolTip1.SetToolTip(this.btnExit, resources.GetString("btnExit.ToolTip"));
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnApply
            // 
            resources.ApplyResources(this.btnApply, "btnApply");
            this.btnApply.Name = "btnApply";
            this.toolTip1.SetToolTip(this.btnApply, resources.GetString("btnApply.ToolTip"));
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // checkBoxOutput
            // 
            resources.ApplyResources(this.checkBoxOutput, "checkBoxOutput");
            this.checkBoxOutput.Name = "checkBoxOutput";
            this.toolTip1.SetToolTip(this.checkBoxOutput, resources.GetString("checkBoxOutput.ToolTip"));
            this.checkBoxOutput.UseVisualStyleBackColor = true;
            this.checkBoxOutput.CheckedChanged += new System.EventHandler(this.checkBoxOutput_CheckedChanged);
            // 
            // textBoxOutput
            // 
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.Name = "textBoxOutput";
            this.toolTip1.SetToolTip(this.textBoxOutput, resources.GetString("textBoxOutput.ToolTip"));
            // 
            // btnOutputBrowse
            // 
            resources.ApplyResources(this.btnOutputBrowse, "btnOutputBrowse");
            this.btnOutputBrowse.Name = "btnOutputBrowse";
            this.toolTip1.SetToolTip(this.btnOutputBrowse, resources.GetString("btnOutputBrowse.ToolTip"));
            this.btnOutputBrowse.UseVisualStyleBackColor = true;
            this.btnOutputBrowse.Click += new System.EventHandler(this.btnOutputBrowse_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabControlMain
            // 
            resources.ApplyResources(this.tabControlMain, "tabControlMain");
            this.tabControlMain.Controls.Add(this.tabPageFile);
            this.tabControlMain.Controls.Add(this.tabPageCompress);
            // 新規追加：追加タブの登録
            this.tabControlMain.Controls.Add(this.tabPageExtract);
            this.tabControlMain.Controls.Add(this.tabPagePhotoInfo);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControlMain, resources.GetString("tabControlMain.ToolTip"));
            // 
            // tabPageFile
            // 
            resources.ApplyResources(this.tabPageFile, "tabPageFile");
            this.tabPageFile.Controls.Add(this.labelGroupHeader);
            this.tabPageFile.Controls.Add(this.label1);
            this.tabPageFile.Controls.Add(this.textBox1);
            this.tabPageFile.Controls.Add(this.btnBrowse);
            this.tabPageFile.Controls.Add(this.pictureBoxInfo);
            this.tabPageFile.Controls.Add(this.checkBoxFileDetail);
            this.tabPageFile.Controls.Add(this.groupBoxFolderGrouping);
            this.tabPageFile.Controls.Add(this.pictureBoxFileDetailInfo);
            this.tabPageFile.Controls.Add(this.checkBoxOutput);
            this.tabPageFile.Controls.Add(this.textBoxOutput);
            this.tabPageFile.Controls.Add(this.btnOutputBrowse);
            this.tabPageFile.Name = "tabPageFile";
            this.toolTip1.SetToolTip(this.tabPageFile, resources.GetString("tabPageFile.ToolTip"));
            // 
            // tabPageCompress
            // 
            resources.ApplyResources(this.tabPageCompress, "tabPageCompress");
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
            this.tabPageCompress.Name = "tabPageCompress";
            this.toolTip1.SetToolTip(this.tabPageCompress, resources.GetString("tabPageCompress.ToolTip"));
            // 
            // 新規追加：tabPageExtract の設定
            this.tabPageExtract.Text = "解凍";
            // 必要に応じてコントロール追加やプロパティ設定を実施
            // this.tabPageExtract.Controls.Add(...);
            
            // 新規追加：tabPagePhotoInfo の設定
            this.tabPagePhotoInfo.Text = "撮影情報";
            // 必要に応じてコントロール追加やプロパティ設定を実施
            // this.tabPagePhotoInfo.Controls.Add(...);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnApply);
            this.Name = "Form1";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
    }
}

