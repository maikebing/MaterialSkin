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
    public partial class UCtrlLoginRegion : MaterialUserControl
    {
        public UCtrlLoginRegion()
        {
            InitializeComponent();
            this.materialComboBox1.Items.Add("2017");
            this.materialComboBox1.Items.Add("2018");
            this.materialComboBox1.Items.Add("2019");
            m_btnLogin.Click += (sender, e) =>
            {
                //TODO:登录校验
                OwenForm.Hide();
                HomePage home = new HomePage();
                home.Show();
                //TODO:初始化首页数据

            };
        }
    }
}
