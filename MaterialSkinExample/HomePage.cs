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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme =
                new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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
            seedListView();
        }
        private void seedListView()
        {
            materialListView1.Columns.Add(new ColumnHeader() { Text = "内容", Name = "Col1", Width = materialListView1.Width - 110 });
            materialListView1.Columns.Add(new ColumnHeader() { Text = "详情", Name = "Col2", Width = 80 });
            //Define
            var data = new[]
            {
                new []{"[网办]这是测试消息1！","详情"},
                new []{"[网办]这是测试消息2！","详情"},
                new []{"[网办]这是测试消息3！","详情"},
                new []{"[网办]这是测试消息4！","详情"},
                new []{"[网办]这是测试消息5！","详情"},
                new []{"[网办]这是测试消息6！","详情"},
                new []{"[网办]这是测试消息7！","详情"},
                new []{"[网办]这是测试消息8！","详情"},
                new []{"[网办]这是测试消息9！","详情"},
            };
            //Add
            foreach (string[] version in data)
            {
                var item = new ListViewItem(version);
                materialListView1.Items.Add(item);
            }
            //Columns
            int width = (int)((materialListView2.Width - 20) / 5);
            materialListView2.Columns.Add(new ColumnHeader() { Text = "申报类型", Name = "Col1", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "申报日期", Name = "Col2", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "所属日期", Name = "Col1", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "金额", Name = "Col2", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "状态", Name = "Col1", Width = width });
            //Define
            var data2 = new[]
            {
                new []{"日常项目录入","2018-01-07","2018-01至2018-12","54321.00","申请成功"},
                new []{"基础信息录入","2018-01-07","2018-01至2018-12","54321.00","申请成功"},
                new []{"日常项目录入","2018-01-07","2018-01至2018-12","54321.00","申请成功"},
                new []{"基础信息录入","2018-01-07","2018-01至2018-12","54321.00","申请成功"},
                new []{"日常项目录入","2018-01-07","2018-01至2018-12","54321.00","申请成功"},
                new []{"基础信息录入","2018-01-07","2018-01至2018-12","54321.00","申请成功"},
            };
            //Add
            foreach (string[] version in data2)
            {
                var item = new ListViewItem(version);
                materialListView2.Items.Add(item);
            }
        }
        private void materialIconButton10_Click(object sender, EventArgs e)
        {
            this.Close();
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
