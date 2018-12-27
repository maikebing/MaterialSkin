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

namespace MaterialSkinExample.MaterialForms.UserControls
{
    public partial class UCtrlBusinessTrackingRegion : MaterialUserControl
    {
        public UCtrlBusinessTrackingRegion()
        {
            InitializeComponent();
            SeedListView();
        }
        private void SeedListView()
        {

            //Columns
            int width = (int)((materialListView2.Width - 25) / 5);
            materialListView2.Columns.Add(new ColumnHeader() { Text = "申报类型", Name = "Col11", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "申报日期", Name = "Col12", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "所属日期", Name = "Col13", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "金额", Name = "Col14", Width = width });
            materialListView2.Columns.Add(new ColumnHeader() { Text = "状态", Name = "Col15", Width = width });
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
            //materialListView2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
    }
}
