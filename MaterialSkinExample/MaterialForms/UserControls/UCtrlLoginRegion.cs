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

namespace MaterialSkinExample.UserControls
{
    public partial class UCtrlLoginRegion : MaterialUserControl
    {
        public UCtrlLoginRegion()
        {
            InitializeComponent();
            m_btnDataCenter.Click += (sender, e) =>
            {
                ServiceCenterForm dialog = new ServiceCenterForm();
                dialog.ShowDialog();
            };
            m_btnLogin.Click += (sender, e) =>
            {
                //TODO:登录校验
                OwenForm.Hide();
                HomePage home = new HomePage();
                home.Show();
                //TODO:初始化首页数据

            };
            m_btnCancel.Click += (sender, e) =>
            {
                OwenForm.Close();
            };
        }
        #region Properties
        private MaterialForm m_OwenForm = null;
        public MaterialForm OwenForm
        {
            get
            {
                if (m_OwenForm == null)
                    m_OwenForm = GetOwenForm(this);
                return m_OwenForm;
            }
        }
        #endregion
        private static MaterialForm GetOwenForm(Control ctrl)
        {
            if (ctrl.Parent != null)
            {
                if (!(ctrl.Parent is MaterialForm form))
                    return GetOwenForm(ctrl.Parent);
                else
                    return form;
            }
            else
            {
                return null;
            }
        }
    }
}
