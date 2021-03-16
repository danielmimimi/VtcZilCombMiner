using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CombMiner
{
    public class MainPrg
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Arguments { get; set; } = string.Empty;

        public StreamReader Reader { get; set; }

        public void Start()
        {
            Process startInfo = new Process();
            startInfo.StartInfo.CreateNoWindow = false;
            startInfo.StartInfo.UseShellExecute = false;
            startInfo.StartInfo.FileName = Path;
            startInfo.StartInfo.Arguments = Arguments;
            startInfo.StartInfo.RedirectStandardOutput = true;
            //startInfo.OutputDataReceived += new DataReceivedEventHandler((sender, e) =>
            //{
            //    // Prepend line numbers to each line of the output.
            //    if (!String.IsNullOrEmpty(e.Data))
            //    {
            //        Console.WriteLine(e.Data);
            //    }
            //});
            startInfo.Start();
            // Reader = startInfo.StandardOutput;
            startInfo.BeginOutputReadLine();
            startInfo.WaitForExit();
        }
    }
}
