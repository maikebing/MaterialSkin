using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialSplitContainer : SplitContainer, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        public MaterialSplitContainer()
        {

        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
         private void DrawFocus(Graphics g, Rectangle r) {
            r.Inflate (-1, -1);
            ControlPaint.DrawFocusRectangle(g, r, this.ForeColor, this.BackColor);
        }
    }
}
