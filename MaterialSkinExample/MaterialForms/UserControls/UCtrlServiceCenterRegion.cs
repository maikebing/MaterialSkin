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
                  InitDataGrid();
              };
            this.m_btnAdd.Click += (sender, e) => Add();
            this.m_btnRemove.Click += (sender, e) => Remove();
            this.m_btnSave.Click += (sender, e) => Save();
            this.m_btnLinkTest.Click += (sender, e) => LinkTest();
            this.m_btnSelectService.Click += (sender, e) => SelectService();
            this.m_btnCancel.Click += (sender, e) => this.OwenForm.Close();
        }
        private void InitDataGrid()
        {
            m_grid.AllowUserToResizeColumns=false;
            m_grid.AllowUserToDeleteRows=false;
            m_grid.AllowUserToOrderColumns=false;
            m_grid.AllowUserToResizeRows=false;
            m_grid.AutoGenerateColumns=false;
            m_grid.AutoSizeColumnsMode= DataGridViewAutoSizeColumnsMode.Fill;
            m_grid.MultiSelect=false;
            m_grid.Columns.Add("name", "名称");
            m_grid.Columns.Add("ip", "服务地址");
            m_grid.Columns.Add("port", "服务端口");
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
