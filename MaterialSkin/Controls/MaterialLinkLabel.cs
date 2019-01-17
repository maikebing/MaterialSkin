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
    public class MaterialLinkLabel : LinkLabel, IMaterialControl, ITextControl, IIconControl
    {
        public MaterialLinkLabel()
        {
            this.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            this.IconAlign = ContentAlignment.MiddleLeft;
            this.IconSize = new Size(24, 24);
        }

        #region Properties
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private Rectangle m_TextRectangle;
        public Rectangle TextRectangle
        {
            get
            {
                return m_TextRectangle;
            }
            set
            {
                m_TextRectangle = value;
            }
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        [Browsable(false)]
        public Image Icon { get { return Image; } set { Image = value; } }
        [Browsable(false)]
        public ContentAlignment IconAlign { get; set; }
        [Browsable(false)]
        public Size IconSize { get; set; }
        [Browsable(false)]
        public ToolStripItemDisplayStyle DisplayStyle { get; set; }
        [Browsable(false)]
        public Padding IconMargin { get; set; }
        #endregion

        public override Size GetPreferredSize(Size proposedSize)
        {
            return this.GetTextSize(this.CreateGraphics());
        }
        protected override void OnCreateControl()
        {
            this.BackColor = Parent != null ? Parent.BackColor : this.BackColor;
            this.ForeColor = SkinManager.GetPrimaryTextColor();
            this.Font = SkinManager.ROBOTO_MEDIUM_10;
            base.OnCreateControl();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
            var textSize = this.GetTextSize(e.Graphics);
            this.IconSize = new Size(textSize.Height, textSize.Height);
            this.TextRectangle = new Rectangle(new Point(IconSize.Width, 0), textSize);
            this.DrawIcon(e.Graphics, e.ClipRectangle);
            this.DrawText(e.Graphics);
        }
        protected override void OnMouseHover(EventArgs e)
        {
            this.ForeColor = SkinManager.ColorScheme.AccentColor;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = SkinManager.GetPrimaryTextColor();
        }
    }
}
