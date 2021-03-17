namespace Mp4BoxSplitter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.bOpen = new System.Windows.Forms.Button();
            this.bStartTime = new System.Windows.Forms.Button();
            this.tStartTime = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tFileName = new System.Windows.Forms.TextBox();
            this.tEndTime = new System.Windows.Forms.TextBox();
            this.bEndTime = new System.Windows.Forms.Button();
            this.bCutSave = new System.Windows.Forms.Button();
            this.tResult = new System.Windows.Forms.TextBox();
            this.bMinus1Sec = new System.Windows.Forms.Button();
            this.bPlus1Sec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bPlus5Sec = new System.Windows.Forms.Button();
            this.bPlus10Sec = new System.Windows.Forms.Button();
            this.bMinus5Sec = new System.Windows.Forms.Button();
            this.bMinus10s = new System.Windows.Forms.Button();
            this.bToStart = new System.Windows.Forms.Button();
            this.bToEnd = new System.Windows.Forms.Button();
            this.bPlayPart = new System.Windows.Forms.Button();
            this.BMinusDot5 = new System.Windows.Forms.Button();
            this.BMinusDot2 = new System.Windows.Forms.Button();
            this.BPlusDot5 = new System.Windows.Forms.Button();
            this.bPlusDot2 = new System.Windows.Forms.Button();
            this.BPlusFrame = new System.Windows.Forms.Button();
            this.BExplore = new System.Windows.Forms.Button();
            this.btnInstagram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1148, 616);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // bOpen
            // 
            this.bOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bOpen.Location = new System.Drawing.Point(12, 654);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(50, 23);
            this.bOpen.TabIndex = 1;
            this.bOpen.Text = "File";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // bStartTime
            // 
            this.bStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bStartTime.Location = new System.Drawing.Point(394, 654);
            this.bStartTime.Name = "bStartTime";
            this.bStartTime.Size = new System.Drawing.Size(72, 23);
            this.bStartTime.TabIndex = 3;
            this.bStartTime.Text = "Start time";
            this.bStartTime.UseVisualStyleBackColor = true;
            this.bStartTime.Click += new System.EventHandler(this.BStartTime_Click);
            // 
            // tStartTime
            // 
            this.tStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tStartTime.Location = new System.Drawing.Point(467, 655);
            this.tStartTime.Name = "tStartTime";
            this.tStartTime.Size = new System.Drawing.Size(69, 20);
            this.tStartTime.TabIndex = 4;
            this.tStartTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp4 Files|*.mp4|mkv Files|*.mkv";
            // 
            // tFileName
            // 
            this.tFileName.AllowDrop = true;
            this.tFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tFileName.Location = new System.Drawing.Point(63, 655);
            this.tFileName.Name = "tFileName";
            this.tFileName.Size = new System.Drawing.Size(279, 20);
            this.tFileName.TabIndex = 5;
            this.tFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tFileName.DragDrop += new System.Windows.Forms.DragEventHandler(this.TFileName_DragDrop);
            this.tFileName.DragEnter += new System.Windows.Forms.DragEventHandler(this.TFileName_DragEnter);
            this.tFileName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TFileName_KeyDown);
            // 
            // tEndTime
            // 
            this.tEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tEndTime.Location = new System.Drawing.Point(613, 655);
            this.tEndTime.Name = "tEndTime";
            this.tEndTime.Size = new System.Drawing.Size(69, 20);
            this.tEndTime.TabIndex = 6;
            this.tEndTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bEndTime
            // 
            this.bEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bEndTime.Location = new System.Drawing.Point(537, 654);
            this.bEndTime.Name = "bEndTime";
            this.bEndTime.Size = new System.Drawing.Size(75, 23);
            this.bEndTime.TabIndex = 7;
            this.bEndTime.Text = "End time";
            this.bEndTime.UseVisualStyleBackColor = true;
            this.bEndTime.Click += new System.EventHandler(this.BEndTime_Click);
            // 
            // bCutSave
            // 
            this.bCutSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bCutSave.Location = new System.Drawing.Point(683, 654);
            this.bCutSave.Name = "bCutSave";
            this.bCutSave.Size = new System.Drawing.Size(75, 23);
            this.bCutSave.TabIndex = 8;
            this.bCutSave.Text = "Cut+Save";
            this.bCutSave.UseVisualStyleBackColor = true;
            this.bCutSave.Click += new System.EventHandler(this.BCutSave_Click);
            // 
            // tResult
            // 
            this.tResult.AllowDrop = true;
            this.tResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tResult.BackColor = System.Drawing.SystemColors.WindowText;
            this.tResult.ForeColor = System.Drawing.SystemColors.Window;
            this.tResult.Location = new System.Drawing.Point(825, 622);
            this.tResult.Multiline = true;
            this.tResult.Name = "tResult";
            this.tResult.Size = new System.Drawing.Size(323, 72);
            this.tResult.TabIndex = 9;
            // 
            // bMinus1Sec
            // 
            this.bMinus1Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bMinus1Sec.Location = new System.Drawing.Point(225, 620);
            this.bMinus1Sec.Name = "bMinus1Sec";
            this.bMinus1Sec.Size = new System.Drawing.Size(40, 23);
            this.bMinus1Sec.TabIndex = 10;
            this.bMinus1Sec.Text = "-1s";
            this.bMinus1Sec.UseVisualStyleBackColor = true;
            this.bMinus1Sec.Click += new System.EventHandler(this.BMinus1Sec_Click);
            // 
            // bPlus1Sec
            // 
            this.bPlus1Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPlus1Sec.Location = new System.Drawing.Point(569, 620);
            this.bPlus1Sec.Name = "bPlus1Sec";
            this.bPlus1Sec.Size = new System.Drawing.Size(40, 23);
            this.bPlus1Sec.TabIndex = 11;
            this.bPlus1Sec.Text = "+1s";
            this.bPlus1Sec.UseVisualStyleBackColor = true;
            this.bPlus1Sec.Click += new System.EventHandler(this.BPlus1Sec_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(357, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "II";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bPlus5Sec
            // 
            this.bPlus5Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPlus5Sec.Location = new System.Drawing.Point(612, 620);
            this.bPlus5Sec.Name = "bPlus5Sec";
            this.bPlus5Sec.Size = new System.Drawing.Size(40, 23);
            this.bPlus5Sec.TabIndex = 13;
            this.bPlus5Sec.Text = "+5s";
            this.bPlus5Sec.UseVisualStyleBackColor = true;
            this.bPlus5Sec.Click += new System.EventHandler(this.BPlus5Sec_Click);
            // 
            // bPlus10Sec
            // 
            this.bPlus10Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPlus10Sec.Location = new System.Drawing.Point(655, 620);
            this.bPlus10Sec.Name = "bPlus10Sec";
            this.bPlus10Sec.Size = new System.Drawing.Size(40, 23);
            this.bPlus10Sec.TabIndex = 14;
            this.bPlus10Sec.Text = "+10s";
            this.bPlus10Sec.UseVisualStyleBackColor = true;
            this.bPlus10Sec.Click += new System.EventHandler(this.BPlus10Sec_Click);
            // 
            // bMinus5Sec
            // 
            this.bMinus5Sec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bMinus5Sec.Location = new System.Drawing.Point(182, 620);
            this.bMinus5Sec.Name = "bMinus5Sec";
            this.bMinus5Sec.Size = new System.Drawing.Size(40, 23);
            this.bMinus5Sec.TabIndex = 15;
            this.bMinus5Sec.Text = "-5s";
            this.bMinus5Sec.UseVisualStyleBackColor = true;
            this.bMinus5Sec.Click += new System.EventHandler(this.BMinus5Sec_Click);
            // 
            // bMinus10s
            // 
            this.bMinus10s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bMinus10s.Location = new System.Drawing.Point(139, 620);
            this.bMinus10s.Name = "bMinus10s";
            this.bMinus10s.Size = new System.Drawing.Size(40, 23);
            this.bMinus10s.TabIndex = 16;
            this.bMinus10s.Text = "-10s";
            this.bMinus10s.UseVisualStyleBackColor = true;
            this.bMinus10s.Click += new System.EventHandler(this.BMinus10s_Click);
            // 
            // bToStart
            // 
            this.bToStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bToStart.Location = new System.Drawing.Point(96, 620);
            this.bToStart.Name = "bToStart";
            this.bToStart.Size = new System.Drawing.Size(40, 23);
            this.bToStart.TabIndex = 17;
            this.bToStart.Text = "Start";
            this.bToStart.UseVisualStyleBackColor = true;
            this.bToStart.Click += new System.EventHandler(this.BToStart_Click);
            // 
            // bToEnd
            // 
            this.bToEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bToEnd.Location = new System.Drawing.Point(698, 620);
            this.bToEnd.Name = "bToEnd";
            this.bToEnd.Size = new System.Drawing.Size(40, 23);
            this.bToEnd.TabIndex = 18;
            this.bToEnd.Text = "End";
            this.bToEnd.UseVisualStyleBackColor = true;
            this.bToEnd.Click += new System.EventHandler(this.BToEnd_Click);
            // 
            // bPlayPart
            // 
            this.bPlayPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPlayPart.Location = new System.Drawing.Point(12, 622);
            this.bPlayPart.Name = "bPlayPart";
            this.bPlayPart.Size = new System.Drawing.Size(59, 23);
            this.bPlayPart.TabIndex = 19;
            this.bPlayPart.Text = "PlayPart";
            this.bPlayPart.UseVisualStyleBackColor = true;
            this.bPlayPart.Click += new System.EventHandler(this.BPlayPart_Click);
            // 
            // BMinusDot5
            // 
            this.BMinusDot5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BMinusDot5.Location = new System.Drawing.Point(268, 620);
            this.BMinusDot5.Name = "BMinusDot5";
            this.BMinusDot5.Size = new System.Drawing.Size(40, 23);
            this.BMinusDot5.TabIndex = 20;
            this.BMinusDot5.Text = "-.5s";
            this.BMinusDot5.UseVisualStyleBackColor = true;
            this.BMinusDot5.Click += new System.EventHandler(this.BMinusDot5_Click);
            // 
            // BMinusDot2
            // 
            this.BMinusDot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BMinusDot2.Location = new System.Drawing.Point(311, 620);
            this.BMinusDot2.Name = "BMinusDot2";
            this.BMinusDot2.Size = new System.Drawing.Size(40, 23);
            this.BMinusDot2.TabIndex = 21;
            this.BMinusDot2.Text = "-.2s";
            this.BMinusDot2.UseVisualStyleBackColor = true;
            this.BMinusDot2.Click += new System.EventHandler(this.BMinusDot2_Click);
            // 
            // BPlusDot5
            // 
            this.BPlusDot5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BPlusDot5.Location = new System.Drawing.Point(526, 620);
            this.BPlusDot5.Name = "BPlusDot5";
            this.BPlusDot5.Size = new System.Drawing.Size(40, 23);
            this.BPlusDot5.TabIndex = 22;
            this.BPlusDot5.Text = "+.5s";
            this.BPlusDot5.UseVisualStyleBackColor = true;
            this.BPlusDot5.Click += new System.EventHandler(this.BPlusDot5_Click);
            // 
            // bPlusDot2
            // 
            this.bPlusDot2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPlusDot2.Location = new System.Drawing.Point(483, 620);
            this.bPlusDot2.Name = "bPlusDot2";
            this.bPlusDot2.Size = new System.Drawing.Size(40, 23);
            this.bPlusDot2.TabIndex = 23;
            this.bPlusDot2.Text = "+.2s";
            this.bPlusDot2.UseVisualStyleBackColor = true;
            this.bPlusDot2.Click += new System.EventHandler(this.BPlusDot2_Click);
            // 
            // BPlusFrame
            // 
            this.BPlusFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BPlusFrame.Location = new System.Drawing.Point(417, 620);
            this.BPlusFrame.Name = "BPlusFrame";
            this.BPlusFrame.Size = new System.Drawing.Size(57, 23);
            this.BPlusFrame.TabIndex = 24;
            this.BPlusFrame.Text = "+f";
            this.BPlusFrame.UseVisualStyleBackColor = true;
            this.BPlusFrame.Click += new System.EventHandler(this.BPlusFrame_Click);
            // 
            // BExplore
            // 
            this.BExplore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BExplore.Location = new System.Drawing.Point(343, 654);
            this.BExplore.Name = "BExplore";
            this.BExplore.Size = new System.Drawing.Size(50, 23);
            this.BExplore.TabIndex = 25;
            this.BExplore.Text = "Folder";
            this.BExplore.UseVisualStyleBackColor = true;
            this.BExplore.Click += new System.EventHandler(this.BExplore_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.Location = new System.Drawing.Point(759, 622);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(60, 61);
            this.btnInstagram.TabIndex = 26;
            this.btnInstagram.Text = "Split to 1m files";
            this.btnInstagram.UseVisualStyleBackColor = true;
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 694);
            this.Controls.Add(this.btnInstagram);
            this.Controls.Add(this.BExplore);
            this.Controls.Add(this.BPlusFrame);
            this.Controls.Add(this.bPlusDot2);
            this.Controls.Add(this.BPlusDot5);
            this.Controls.Add(this.BMinusDot2);
            this.Controls.Add(this.BMinusDot5);
            this.Controls.Add(this.bPlayPart);
            this.Controls.Add(this.bToEnd);
            this.Controls.Add(this.bToStart);
            this.Controls.Add(this.bMinus10s);
            this.Controls.Add(this.bMinus5Sec);
            this.Controls.Add(this.bPlus10Sec);
            this.Controls.Add(this.bPlus5Sec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bPlus1Sec);
            this.Controls.Add(this.bMinus1Sec);
            this.Controls.Add(this.tResult);
            this.Controls.Add(this.bCutSave);
            this.Controls.Add(this.bEndTime);
            this.Controls.Add(this.tEndTime);
            this.Controls.Add(this.tFileName);
            this.Controls.Add(this.tStartTime);
            this.Controls.Add(this.bStartTime);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "Mp4BoxSplitter fast without reencoding (only splits on frames)";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.Button bStartTime;
        private System.Windows.Forms.TextBox tStartTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tFileName;
        private System.Windows.Forms.TextBox tEndTime;
        private System.Windows.Forms.Button bEndTime;
        private System.Windows.Forms.Button bCutSave;
        private System.Windows.Forms.TextBox tResult;
        private System.Windows.Forms.Button bMinus1Sec;
        private System.Windows.Forms.Button bPlus1Sec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bPlus5Sec;
        private System.Windows.Forms.Button bPlus10Sec;
        private System.Windows.Forms.Button bMinus5Sec;
        private System.Windows.Forms.Button bMinus10s;
        private System.Windows.Forms.Button bToStart;
        private System.Windows.Forms.Button bToEnd;
        private System.Windows.Forms.Button bPlayPart;
        private System.Windows.Forms.Button BMinusDot5;
        private System.Windows.Forms.Button BMinusDot2;
        private System.Windows.Forms.Button BPlusDot5;
        private System.Windows.Forms.Button bPlusDot2;
        private System.Windows.Forms.Button BPlusFrame;
        private System.Windows.Forms.Button BExplore;
        private System.Windows.Forms.Button btnInstagram;
    }
}

