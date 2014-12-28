namespace QCuteBaseProject
{
    partial class QCuteCapture
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QCuteCapture));
            this.BtnStopJob = new System.Windows.Forms.Button();
            this.QCuteCaptureNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdChoosePath = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnStartJob = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnMore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.ContextMenuNotify.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStopJob
            // 
            this.BtnStopJob.FlatAppearance.BorderSize = 0;
            this.BtnStopJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStopJob.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStopJob.Location = new System.Drawing.Point(124, 24);
            this.BtnStopJob.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStopJob.Name = "BtnStopJob";
            this.BtnStopJob.Size = new System.Drawing.Size(59, 40);
            this.BtnStopJob.TabIndex = 1;
            this.BtnStopJob.Text = "&Stop";
            this.BtnStopJob.UseVisualStyleBackColor = true;
            this.BtnStopJob.Click += new System.EventHandler(this.BtnStopJob_Click);
            // 
            // QCuteCaptureNotify
            // 
            this.QCuteCaptureNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.QCuteCaptureNotify.BalloonTipText = "Starting Capture Screen!";
            this.QCuteCaptureNotify.BalloonTipTitle = "QCuteCapture";
            this.QCuteCaptureNotify.ContextMenuStrip = this.ContextMenuNotify;
            this.QCuteCaptureNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("QCuteCaptureNotify.Icon")));
            this.QCuteCaptureNotify.Text = "QCuteCapture";
            this.QCuteCaptureNotify.Visible = true;
            // 
            // ContextMenuNotify
            // 
            this.ContextMenuNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.ContextMenuNotify.Name = "ContextMenuNotify";
            this.ContextMenuNotify.Size = new System.Drawing.Size(109, 92);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.stopToolStripMenuItem.Text = "&Stop";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.startToolStripMenuItem.Text = "&Go";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // fbdChoosePath
            // 
            this.fbdChoosePath.Description = "Choose";
            this.fbdChoosePath.SelectedPath = "C:\\Users\\Yong\\Desktop";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnStartJob
            // 
            this.BtnStartJob.AutoEllipsis = true;
            this.BtnStartJob.FlatAppearance.BorderSize = 0;
            this.BtnStartJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStartJob.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStartJob.Location = new System.Drawing.Point(8, 24);
            this.BtnStartJob.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStartJob.Name = "BtnStartJob";
            this.BtnStartJob.Size = new System.Drawing.Size(57, 40);
            this.BtnStartJob.TabIndex = 1;
            this.BtnStartJob.Text = "&Go";
            this.BtnStartJob.UseVisualStyleBackColor = true;
            this.BtnStartJob.Click += new System.EventHandler(this.BtnStartJob_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnMore);
            this.groupBox1.Controls.Add(this.BtnStartJob);
            this.groupBox1.Controls.Add(this.BtnStopJob);
            this.groupBox1.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(309, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Q Dash";
            // 
            // BtnMore
            // 
            this.BtnMore.FlatAppearance.BorderSize = 0;
            this.BtnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMore.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMore.Location = new System.Drawing.Point(239, 24);
            this.BtnMore.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMore.Name = "BtnMore";
            this.BtnMore.Size = new System.Drawing.Size(66, 40);
            this.BtnMore.TabIndex = 4;
            this.BtnMore.Text = "&More";
            this.BtnMore.UseVisualStyleBackColor = true;
            this.BtnMore.Click += new System.EventHandler(this.BtnMore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Attention: Adjust the banner first! ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(344, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel1.Text = "Designed by Youyou! ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(232, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(93, 21);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add a Banner";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel2.Text = "Beta1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Arabic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Default File Path: E:\\QCuteCpature";
            // 
            // QCuteCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 182);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Adobe Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "QCuteCapture";
            this.Text = "QCuteCapture";
            this.Load += new System.EventHandler(this.QCuteCapture_Load);
            this.ContextMenuNotify.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStopJob;
        private System.Windows.Forms.NotifyIcon QCuteCaptureNotify;
        private System.Windows.Forms.ContextMenuStrip ContextMenuNotify;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FolderBrowserDialog fbdChoosePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnStartJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnMore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Label label2;
    }
}

