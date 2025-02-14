using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace VRC_SnapArchive
{
    public class FileCompressor
    {
        // lossless=true なら高圧縮（完全可逆）、false なら標準圧縮
        public static void CompressDirectory(string sourceDir, string outputFile, bool lossless)
        {
            // 7z.exe が PATH に含まれている前提です
            string compressionLevel = lossless ? "9" : "5";
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\7-Zip\7z.exe", // 7z.exeの絶対パス
                Arguments = $"a \"{outputFile}\" \"{sourceDir}\\*\" -t7z -mx={compressionLevel}",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
                // 必要に応じて処理結果の検証やログ出力を実装
            }
        }
    }
}
