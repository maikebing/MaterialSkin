using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialIconButton : Label, IMaterialControl, IIconControl
    {
        public MaterialIconButton()
        {

        }
        public int Depth { get; set; }

        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        public MouseState MouseState { get; set; }
        public ContentAlignment IconAlign { get; set; } = ContentAlignment.MiddleLeft;
        public Size IconSize { get; set; }
        public ToolStripItemDisplayStyle DisplayStyle { get; set; }
        public Padding IconMargin { get; set; }
        public bool Primary { get; set; }
        private SizeF _textSize;

        private Image _icon;
        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                if (AutoSize)
                    Size = GetPreferredSize();
                Invalidate();
            }
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                _textSize = CreateGraphics().MeasureString(value.ToUpper(), SkinManager.ROBOTO_MEDIUM_10);
                if (AutoSize)
                    Size = GetPreferredSize();
                Invalidate();
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            //Icon
            var iconRect = new Rectangle(8, 6, 24, 24);

            if (string.IsNullOrEmpty(Text))
                // Center Icon
                iconRect.X += 2;
            if (Icon != null)
                g.DrawImage(Icon, iconRect);
            //Text
            var textRect = ClientRectangle;

            if (Icon != null)
            {
                //
                // Resize and move Text container
                //

                // First 8: left padding
                // 24: icon width
                // Second 4: space between Icon and Text
                // Third 8: right padding
                textRect.Width -= 8 + 24 + 4 + 8;

                // First 8: left padding
                // 24: icon width
                // Second 4: space between Icon and Text
                textRect.X += 8 + 24 + 4;
            }

            g.DrawString(
                Text.ToUpper(),
                SkinManager.ROBOTO_MEDIUM_10,
                Enabled ? (false ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(),
                textRect,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
            //base.OnPaint(e);
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ForeColor = SkinManager.GetPrimaryTextColor();
            Font = SkinManager.ROBOTO_REGULAR_11;
            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }
        protected void OnDrawIcon(Graphics g)
        {
            if (Icon == null)
                return;
            if (DisplayStyle == ToolStripItemDisplayStyle.None || DisplayStyle == ToolStripItemDisplayStyle.Text)
                return;

        }
        protected void OnDrawText(Graphics g)
        {

        }
        private Size GetPreferredSize()
        {
            return GetPreferredSize(new Size(0, 0));
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            // Provides extra space for proper padding for content
            var extra = 16;

            if (Icon != null)
                // 24 is for icon size
                // 4 is for the space between icon & text
                extra += 24 + 4;

            return new Size((int)Math.Ceiling(_textSize.Width) + extra, 36);
        }
    }
}
