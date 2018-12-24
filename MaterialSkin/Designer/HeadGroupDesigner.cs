using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace MaterialSkin.Designer
{
    public class HeadGroupDesigner : ParentControlDesigner
    {
        private MaterialHeadGroup _control;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            //_control = (MaterialHeadGroup)component;
            //var Panel1Enable = this.EnableDesignMode(_control.FlowLayoutPanel1, "flowLayoutPanel1");
            //var Panel2Enable = this.EnableDesignMode(_control.FlowLayoutPanel2, "flowLayoutPanel2");
            //if (!(Panel1Enable && Panel2Enable))
            //    throw new Exception("加载控件失败");
        }
    }
}
