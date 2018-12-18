using System.ComponentModel;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialLabel : Label, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private bool m_Primary = true;

        public bool Primary
        {
            get { return m_Primary; }
            set
            {
                m_Primary = value;
                Invalidate();
            }
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (Primary)
            {
                ForeColor = SkinManager.GetPrimaryTextColor();
                Font = SkinManager.ROBOTO_REGULAR_11;
                BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
            }
        }
    }
}
