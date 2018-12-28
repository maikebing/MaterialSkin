using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    public partial class HomePage : MaterialForm
    {
        public HomePage()
        {
            InitializeComponent();
            this.pictureBox1.MouseMove += (sender, e) =>
             {
                 OnMouseMove(e);
             };
            this.materialLabel1.MouseMove += (sender, e) =>
            {
                OnMouseMove(e);
            };
            this.m_flowPanelLeftMenu.MouseMove += (sender, e) =>
            {
                OnMouseMove(e);
            };
            this.m_flowPanelTopMenu.MouseMove += (sender, e) =>
            {
                OnMouseMove(e);
            };
        }
        private void materialIconButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                //这里一定要判断鼠标左键按下状态，否则会出现一个很奇葩的BUG，不信邪可以试一下~~
                ReleaseCapture();
                SendMessage(Handle, 0x00A1, 2, 0);
            }
        }
    }
}
