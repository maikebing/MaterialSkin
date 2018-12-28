using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace MaterialSkinExample.MaterialForms
{
    public partial class UCtrlNoticeRegion : MaterialUserControl
    {
        public UCtrlNoticeRegion()
        {
            InitializeComponent();
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
        }
    }
}
