using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using VRC_SnapArchive;

namespace VRC_SnapArchive
{
    public partial class Form1: Form
    {
        // 新規追加：ファイル名リネーム用ラベルのためのフィールド
        private Label labelFileRename;

        public Form1()
        {
            InitializeComponent();
            // 新規追加：ファイル名リネーム用ラベルを作成して追加
            AddFileRenameLabel();
            InitializeFileNameRenamingDropdown();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            // 初期状態の同期（チェック状態により圧縮設定の表示切替）
            checkBoxCompress_CheckedChanged(this, EventArgs.Empty);
        }

        // 新規追加：ファイル名リネーム用ラベルを生成し、フォームに追加
        private void AddFileRenameLabel()
        
        {
            labelFileRename = new Label();
            labelFileRename.Text = "ファイル名をリネームする：";

            labelFileRename.Location = new Point(10, 10);
            labelFileRename.AutoSize = true;
            this.Controls.Add(labelFileRename);
        }

        private void InitializeFileNameRenamingDropdown()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("有効");
            List<string> dateFormats = new List<string>();
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "dateformats.txt");
                if(File.Exists(filePath))
                {
                    // ファイルから日付形式を読み込む
                    string[] lines = File.ReadAllLines(filePath, Encoding.GetEncoding("UTF-8"));
                    dateFormats.AddRange(lines);
                }
                else
                {
                    // ファイルが存在しない場合は既定の形式を追加
                    dateFormats.AddRange(new string[] {
                        "年-月-日-時分-連番",
                        "年/月/日/時分/連番",
                        "年_月_日_時分_連番",
                        "年月日_時分_連番",
                        "和暦年-月-日-時分-連番",
                        "年-月-日-曜日-時分-連番",
                        "日-月-年-時分-連番",
                        "月-日-年-時分-連番",
                        "年.月.日.時分.連番",
                        "時分_年月日_連番"
                    });
                }
            }
            catch (Exception ex)
            {
                // 読み込みでエラーが発生した場合は既定の形式を追加
                dateFormats.AddRange(new string[] {
                    "年-月-日-時分-連番",
                    "年/月/日/時分/連番",
                    "年_月_日_時分_連番",
                    "年月日_時分_連番",
                    "和暦年-月-日-時分-連番",
                    "年-月-日-曜日-時分-連番",
                    "日-月-年-時分-連番",
                    "月-日-年-時分-連番",
                    "年.月.日.時分.連番",
                    "時分_年月日_連番"
                });
            }
            foreach (string format in dateFormats)
            {
                comboBox1.Items.Add(format);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // ※フォルダ指定ダイアログへ変更
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = dlg.SelectedPath;
                }
            }
        }

        private void checkBoxFileDetail_CheckedChanged(object sender, EventArgs e)
        {
            // チェックボックスにチェックがあればグループボックスを有効にする
            groupBoxFolderGrouping.Enabled = checkBoxFileDetail.Checked;
        }

        private void btnCompressBrowse_Click(object sender, EventArgs e)
        {
            // フォルダ選択ダイアログを表示
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                if (folderDlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxCompress.Text = folderDlg.SelectedPath;
                }
            }
        }

        private void checkBoxCompress_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = this.checkBoxCompress.Checked;
            this.labelCompressionMethod.Visible = isChecked;
            this.radioButtonLossless.Visible = isChecked;
            this.radioButtonStandard.Visible = isChecked;
            this.labelLosslessNote.Visible = isChecked;
        }

        private void checkBoxOutput_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = this.checkBoxOutput.Checked;
            this.textBoxOutput.Visible = isChecked;
            this.btnOutputBrowse.Visible = isChecked;
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDlg = new FolderBrowserDialog())
            {
                if(folderDlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxOutput.Text = folderDlg.SelectedPath;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("本当に終了しますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    
        private void btnApply_Click(object sender, EventArgs e)
        {
            // 各設定の値を取得
            string photoSavePath = textBox1.Text;
            string outputPath = checkBoxOutput.Checked && !string.IsNullOrWhiteSpace(textBoxOutput.Text)
                                ? textBoxOutput.Text : photoSavePath;
            
            bool fileDetail = checkBoxFileDetail.Checked;
            string folderGrouping = "なし";
            if(fileDetail)
            {
                if(radioButtonMonth.Checked)
                    folderGrouping = "月単位";
                else if(radioButtonWeek.Checked)
                    folderGrouping = "週単位";
                else if(radioButtonDay.Checked)
                    folderGrouping = "日単位";
            }
            
            string compressPath = textBoxCompress.Text;
            bool compressEnabled = checkBoxCompress.Checked;
            string compressionMethod = "未選択";
            if(compressEnabled)
            {
                if(radioButtonLossless.Checked)
                    compressionMethod = "ロスレス（完全可逆）";
                else if(radioButtonStandard.Checked)
                    compressionMethod = "標準圧縮";
            }
            
            // ----- 新規追加：写真の整頓処理 -----
            if(!string.IsNullOrWhiteSpace(photoSavePath) && Directory.Exists(photoSavePath))
            {
                // "VRChat_" で始まるファイルを探索
                string[] files = Directory.GetFiles(photoSavePath, "VRChat_*", SearchOption.TopDirectoryOnly);
                foreach (var file in files)
                {
                    // 例: "VRChat_2025-02-13_12-24-33.127_3840x2160.jpg"
                    var match = Regex.Match(Path.GetFileName(file), @"VRChat_(\d{4})-(\d{2})-(\d{2})_");
                    if(match.Success)
                    {
                        string year = match.Groups[1].Value;
                        string month = match.Groups[2].Value;
                        string day = match.Groups[3].Value;
                        DateTime dt;
                        if(DateTime.TryParse($"{year}-{month}-{day}", out dt))
                        {
                            string targetFolderName = "";
                            // グループ分けは、細かく保存するチェック状態に依存
                            if(fileDetail)
                            {
                                if(radioButtonMonth.Checked)
                                    targetFolderName = $"{year}-{month}";
                                else if(radioButtonDay.Checked)
                                    targetFolderName = $"{year}-{month}-{day}";
                                else if(radioButtonWeek.Checked)
                                {
                                    // 現在のカルチャ情報から週番号を取得
                                    int week = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        dt, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
                                    targetFolderName = $"{year}-W{week}";
                                }
                            }
                            else
                            {
                                // ファイルを細かく保存しない場合は、既に月ごとフォルダに整理されていると想定
                                targetFolderName = $"{year}-{month}";
                            }
                            
                            string targetFolder = Path.Combine(outputPath, targetFolderName);
                            if(!Directory.Exists(targetFolder))
                                Directory.CreateDirectory(targetFolder);
                                
                            // ファイルを移動する（同名ファイルがあれば上書きやリネームの処理を検討）
                            string targetFile = Path.Combine(targetFolder, Path.GetFileName(file));
                            try
                            {
                                File.Move(file, targetFile);
                            }
                            catch(Exception ex)
                            {
                            }
                        }
                    }
                }
            }
            // ----- 以上、整頓処理 -----
            
            // ----- 新規追加：7zipによる圧縮処理 -----
            if(compressEnabled && Directory.Exists(outputPath))
            {
                // 出力先内の各整理フォルダを圧縮
                string[] directories = Directory.GetDirectories(outputPath);
                foreach(string dir in directories)
                {
                    string archiveFile = Path.Combine(outputPath, Path.GetFileName(dir) + ".7z");
                    FileCompressor.CompressDirectory(dir, archiveFile, radioButtonLossless.Checked);
                    // ※必要に応じて、圧縮後に dir の削除などを検討
                }
            }
            // ----- 以上、圧縮処理 -----
            
            // 既存：設定内容のサマリー表示
            string summary = $"【設定内容】\n" +
                            $"写真保存先： {photoSavePath}\n" +
                            $"出力先： {outputPath}\n" +
                            $"ファイル詳細保存： {(fileDetail ? "有り" : "無し")}" +
                            (fileDetail ? $" 　→ グループ分け： {folderGrouping}\n" : "\n") +
                            $"圧縮先： {compressPath}\n" +
                            $"圧縮設定： {(compressEnabled ? $"有り ({compressionMethod})" : "無し")}";

            MessageBox.Show(summary, "設定の適用", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // 追加処理の結果に応じたエラーチェックやログ出力を必要に応じて実装
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectArchives_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "7Zip ファイル (*.7z)|*.7z";
                dlg.Multiselect = true;
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    listBoxArchives.Items.Clear();
                    foreach (var file in dlg.FileNames)
                    {
                        listBoxArchives.Items.Add(file);
                    }
                }
            }
        }

        private void btnExtractDestBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    textBoxExtractDest.Text = dlg.SelectedPath;
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string outputFolder = textBoxExtractDest.Text;
            if (!Directory.Exists(outputFolder)) return;

            foreach (var item in listBoxArchives.Items)
            {
                string archivePath = item.ToString();
                if (File.Exists(archivePath))
                {
                    FileDecompressor.DecompressArchive(archivePath, outputFolder);
                }
            }
            MessageBox.Show("解凍が完了しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelGroupHeader_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxFileDetailInfo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
