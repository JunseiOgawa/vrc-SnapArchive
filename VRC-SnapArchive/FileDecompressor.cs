using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace VRC_SnapArchive
{
    public static class FileDecompressor
    {
        public static void DecompressArchive(string archiveFile, string outputFolder)
        {
            // 7z.exe が PATH に含まれている前提
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\7-Zip\7z.exe", // 7z.exeの絶対パス
                Arguments = $"x \"{archiveFile}\" -o\"{outputFolder}\"",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            using (Process process = Process.Start(psi))
            {
                process.WaitForExit();
            }
        }
    }
}
