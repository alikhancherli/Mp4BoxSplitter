using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace Mp4BoxSplitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tFileName.Text = openFileDialog1.FileName;
                this.axWindowsMediaPlayer1.URL = tFileName.Text;
            }
        }


        private void BStartTime_Click(object sender, EventArgs e)
        {
            tStartTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString("0.##");
        }

        private void BEndTime_Click(object sender, EventArgs e)
        {
            tEndTime.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPosition.ToString("0.##");
        }

        private void BCutSave_Click(object sender2, EventArgs e)
        {
            string sStartTime = decimal.Parse(tStartTime.Text).ToString("0.##").Replace(",", ".");
            string sEndTime = decimal.Parse(tEndTime.Text).ToString("0.##").Replace(",", ".");
            DevideVideo(sStartTime,sEndTime);
        }


        private void DevideVideo(string start , string end)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            //pokličem mp4box.exe s parametri                        
            Process p = new Process();
            p.StartInfo.FileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mp4box", @"mp4box.exe");

            string sStartTime = start;
            string sEndTime = end;

            string inFileName = tFileName.Text;
            string outFileName = inFileName.Substring(0, inFileName.LastIndexOf(".")) + "_" + sStartTime + "-" + sEndTime + inFileName.Substring(inFileName.LastIndexOf("."));

            string @params = "-splitx " + sStartTime + ":" + sEndTime + " " + inFileName + " -out " + outFileName;

            Debug.WriteLine(p.StartInfo.FileName + " " + @params);

            p.StartInfo.Arguments = @params;

            var sb = new StringBuilder();
            sb.AppendLine("mp4box.exe results:");
            // redirect the output
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            // hookup the eventhandlers to capture the data that is received
            p.OutputDataReceived += (sender, args) =>
            {
                if (args.Data != null && !args.Data.StartsWith("Splitting:") && !args.Data.StartsWith("ISO File Writing:"))
                {
                    sb.AppendLine(args.Data);
                }
            };
            p.ErrorDataReceived += (sender, args) =>
            {
                if (args.Data != null && !args.Data.StartsWith("Splitting:") && !args.Data.StartsWith("ISO File Writing:"))
                {
                    sb.AppendLine(args.Data);
                }
            };

            // direct start
            p.StartInfo.UseShellExecute = false;

            p.Start();
            // start our event pumps
            p.BeginOutputReadLine();
            p.BeginErrorReadLine();

            // until we are done
            p.WaitForExit();
            tResult.Text = sb.ToString();
        }

        private void TFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.axWindowsMediaPlayer1.URL = tFileName.Text;
            }
        }

        private void TFileName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void TFileName_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                tFileName.Text = files[0];
                this.axWindowsMediaPlayer1.URL = tFileName.Text;
            }
        }

        private void BMinus1Sec_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 1;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BMinus5Sec_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 5;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BMinus10s_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 10;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BToStart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = 0;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BPlus1Sec_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 1;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BPlus5Sec_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 5;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BPlus10Sec_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 10;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BToEnd_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration;
            axWindowsMediaPlayer1.Refresh();
        }


        private void BMinusDot5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 0.5;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BMinusDot2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition -= 0.2;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BPlusDot5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 0.5;
            axWindowsMediaPlayer1.Refresh();
        }

        private void BPlusDot2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition += 0.2;
            axWindowsMediaPlayer1.Refresh();

        }

        private void BPlusFrame_Click(object sender, EventArgs e)
        {
            ((IWMPControls2)axWindowsMediaPlayer1.Ctlcontrols).step(1);
            axWindowsMediaPlayer1.Refresh();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void BPlayPart_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = double.Parse(tStartTime.Text);
            double dInterval = (double.Parse(tEndTime.Text) - double.Parse(tStartTime.Text)) * 1000;

            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Interval = dInterval;

            axWindowsMediaPlayer1.Ctlcontrols.play();
            aTimer.Enabled = true;

        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            var timer = (System.Timers.Timer)sender;
            timer.Dispose();
        }

        private void BExplore_Click(object sender, EventArgs e)
        {
            string sFolderPath = Path.GetDirectoryName(tFileName.Text);

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = sFolderPath,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia.duration < 60)
            {
                MessageBox.Show("File duration must be greater than 1 minute");
            }
            else
            {
                double duration = axWindowsMediaPlayer1.currentMedia.duration;
                int times = (int)Math.Ceiling((double)duration / 60);
                if (duration > 60)
                {
                    double LatestVideo = (times * 60) - duration;
                    for (int i = 1; i < times; i++)
                    {
                        DevideVideo(((i - 1) * 60).ToString(), ((i) * 60).ToString());
                    }
                    DevideVideo(((times - 1) * 60).ToString(), ((times * 60) - LatestVideo).ToString());
                }
            }
           
        }

        
    }
}