using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialUserControl : UserControl,
        IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private MaterialForm m_OwenForm = null;
        [Browsable(false)]
        public MaterialForm OwenForm
        {
            get
            {
                if (m_OwenForm == null)
                    m_OwenForm = GetOwenForm(this);
                return m_OwenForm;
            }
        }
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
