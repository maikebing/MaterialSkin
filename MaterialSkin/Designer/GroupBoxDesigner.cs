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
    public class GroupBoxDesigner : ParentControlDesigner
    {
        private MaterialGroupBox _control;

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            _control = (MaterialGroupBox)component;
            var titlePanel1Enable = this.EnableDesignMode(_control.TitlePanel, "rightPanel");
            if (!(titlePanel1Enable))
                throw new Exception("加载控件失败");
        }

    }

}
