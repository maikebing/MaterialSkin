using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkinExample
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme =
                new ColorScheme(Primary.LightBlue300, Primary.LightBlue300, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);
            this.Load += (sender, e) =>
              {
                  for (int i = 0; i < 10; i++)
                  {
                      //创建HeadGroup
                      MaterialHeadGroup headGroup = new MaterialHeadGroup();
                      headGroup.Text = "这是一条测试消息!";
                      headGroup.LeftTag = 1;
                      headGroup.RightText = "详情";
                      headGroup.RightTag = 1;

                      this.flowLayoutPanel1.Controls.Add(headGroup);
                  }
              };
        }
    }
}
