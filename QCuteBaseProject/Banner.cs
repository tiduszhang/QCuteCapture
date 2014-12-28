using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QCuteBaseProject
{
    public partial class Banner : Form
    {
        public Banner()
        {
            InitializeComponent();
        }

        private void Banner_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Banner bar = new Banner();
            bar.Show();
        }
        
        private Point offset;               //鼠标位置记录

        #region  //窗体移动
        //鼠标按下，获取位置
        private void Client_MouseDown(object sender, MouseEventArgs e)
        {
            offset = new Point(-e.X, -e.Y);
        }

        //改变窗体位置
        private void Client_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(offset.X, offset.Y);
                this.Location = mousePosition;
            }
        }
        #endregion

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
