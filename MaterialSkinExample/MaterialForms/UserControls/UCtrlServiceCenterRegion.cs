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
    public partial class UCtrlServiceCenterRegion : MaterialUserControl
    {
        public UCtrlServiceCenterRegion()
        {
            InitializeComponent();
            this.Load += (sender, e) =>
              {
                  InitListView();
              };
            this.SizeChanged += (sender, e) =>
              {
                  var width = (int)(this.Width / 3);
                  foreach (ColumnHeader item in materialListView1.Columns)
                  {
                      item.Width = width;
                  }
              };
            this.m_btnAdd.Click += (sender, e) => Add();
            this.m_btnRemove.Click += (sender, e) => Remove();
            this.m_btnSave.Click += (sender, e) => Save();
            this.m_btnLinkTest.Click += (sender, e) => LinkTest();
            this.m_btnSelectService.Click += (sender, e) => SelectService();
            this.m_btnCancel.Click += (sender, e) => this.OwenForm.Close();
        }
        private void InitListView()
        {
            materialListView1.Columns.Clear();
            var width = (int)(this.Width / 3);
            materialListView1.Columns.Add("名称", width, HorizontalAlignment.Left);
            materialListView1.Columns.Add("服务地址", width, HorizontalAlignment.Left);
            materialListView1.Columns.Add("服务端口", width, HorizontalAlignment.Left);
        }
        private void Add()
        {

        }
        private void Remove()
        {

        }
        private void Save()
        {

        }
        private void LinkTest()
        {

        }
        private void SelectService()
        {

        }
    }
}
