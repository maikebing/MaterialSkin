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
    /// <summary>
    /// 
    /// </summary>
    public class MaterialLinkLabel : LinkLabel, IMaterialControl, ITextControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public Rectangle TextRectangle
        {
            get
            {
                return ClientRectangle;
            }
            set
            {

            }
        }
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.BackColor = Parent != null ? Parent.BackColor : this.BackColor;
            this.Font = SkinManager.ROBOTO_MEDIUM_10;
            e.Graphics.Clear(this.BackColor);
            this.DrawText(e.Graphics);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            this.ForeColor = SkinManager.ColorScheme.AccentColor;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = SkinManager.ColorScheme.PrimaryColor;
        }
    }
}
