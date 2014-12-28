#define _debug1
#define _stream1
#define _localfile1
using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.Profiles;
using Microsoft.Expression.Encoder.ScreenCapture;
using System.Threading;
using System.Windows.Forms;
using System.Security.Permissions;

namespace QCuteBaseProject
{
    public partial class QCuteCapture : Form
    {
        public string path = @"e:\QCuteCapture" + Guid.NewGuid().ToString();//临时工作目录
        public string savePath = @"e:\QCuteCapture"; //转码后的保存路径
        private Thread trans;//建立转码线程对象

        public QCuteCapture()
        {
            InitializeComponent();
        }
        private void QCuteCapture_Load(object sender, EventArgs e)
        {
            //设置BtnStopJob按键不可用
            Banner lg = new Banner();
            lg.Show();

            BtnStopJob.Enabled=false;
        }
        //定义屏幕截图任务
        ScreenCaptureJob SCJ = new ScreenCaptureJob();

       
        /// <summary>
        /// 开始录制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartJob_Click(object sender, EventArgs e)
        {

            
            SCJ.OutputPath = path;
            Collection<EncoderDevice> audioDevs = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            foreach (EncoderDevice device in audioDevs)
            {
                try
                {
                    SCJ.AddAudioDeviceSource(device);//记录声音
                }
                catch (Exception myerr)
                {
                    //设备异常

                }
            }

            //开始录制
            SCJ.Start();
            BtnStartJob.Enabled = false;
            BtnStopJob.Enabled = true;
            //隐藏窗体
            this.Visible = false;
            
        }


        /// <summary>
        /// 停止录制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStopJob_Click(object sender, EventArgs e)
        {

            //隐藏窗体
            this.Visible = true;
            BtnStartJob.Enabled = true;
            BtnStopJob.Enabled = false ;
            SCJ.Stop();                                 //停止录制
            trans = new Thread(new ThreadStart(this.Trans_Code));//实例化线程对象
            trans.Start(); //开始转码
        }

        /// <summary>
        /// 转换结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Trans_EncodeCompleted(object sender, EncodeCompletedEventArgs e)
        {
            MessageBox.Show("Completed!");
            trans.Abort();//关闭线程
        }

        private void Trans_Code()
        {
            
            string xescfile = GetxescPath();            //获取录制文件路径

            MediaItem src = new MediaItem(xescfile);    //加入媒体转换

            Rectangle rectangle = new Rectangle();
            rectangle = Screen.PrimaryScreen.Bounds;    //获得屏幕信息

            //重新定义视频格式
            src.OutputFormat = new WindowsMediaOutputFormat();
            src.OutputFormat.VideoProfile = new AdvancedVC1VideoProfile();
            src.OutputFormat.VideoProfile.Bitrate = new VariableConstrainedBitrate(1000, 1500);
            src.OutputFormat.VideoProfile.Size = new Size(rectangle.Width, rectangle.Height);
            src.OutputFormat.VideoProfile.FrameRate = 30;
            src.OutputFormat.VideoProfile.KeyFrameDistance = new TimeSpan(0, 0, 4);


            //重新定义音频格式
            src.OutputFormat.AudioProfile = new WmaAudioProfile();
            src.OutputFormat.AudioProfile.Bitrate = new VariableConstrainedBitrate(128, 192);
            src.OutputFormat.AudioProfile.Codec = AudioCodec.WmaProfessional;
            src.OutputFormat.AudioProfile.BitsPerSample = 24;

            Job encoderjob = new Job();//实例化转换作业
            encoderjob.MediaItems.Add(src);//添加xesc文件
#warning    //encoderjob.ApplyPreset(Presets.VC1HD720pVBR);//设置视频编码
            encoderjob.CreateSubfolder = false;//不创建文件夹
            encoderjob.OutputDirectory = savePath;//转换完后的文件保存目录

            encoderjob.EncodeCompleted += Trans_EncodeCompleted;

            encoderjob.Encode();
            if (File.Exists(xescfile))
            {
                File.Delete(xescfile);
            }
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
            
        }
        /// <summary>
        /// 获取录像文件路径
        /// </summary>
        /// <returns></returns>
        private string GetxescPath()
        {
            string result = "";
            FileInfo[] filelist = new DirectoryInfo(path).GetFiles("*.xesc");
            foreach (FileInfo NextFile in filelist)
            {
                result = NextFile.FullName;
                break;
            }
            return result;
        }
       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }


        //选择转码后文件保存路径
        private void lklbl__LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fbdChoosePath.ShowDialog();
            if(fbdChoosePath.SelectedPath!=null)
            {
                savePath = fbdChoosePath.SelectedPath.ToString();
            }

        }

        private void BtnMore_Click(object sender, EventArgs e)
        {
            More more = new More();
            more.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Banner banner = new Banner();
            banner.Show();
        }


    }
}
