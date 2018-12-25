using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialSkin
{
    public interface ITextControl
    {
        string Text { get; set; }
        Font Font { get; set; }
        Rectangle TextRectangle { get; set; }
        Color ForeColor { get; set; }
    }
    public static class ITextControlExtensions
    {
        public static void DrawText(this ITextControl ctrl, Graphics g)
        {
            if (string.IsNullOrEmpty(ctrl.Text))
                return;
            g.DrawString(
            ctrl.Text.ToUpper(),
            ctrl.Font,
          new SolidBrush(ctrl.ForeColor), ctrl.TextRectangle,
            new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center }
            );
        }
        public static Size GetTextSize(this ITextControl ctrl, Graphics g)
        {
            var sizef = g.MeasureString(ctrl.Text.ToUpper(), ctrl.Font);
            return new Size((int)sizef.Width + 16, (int)sizef.Height);
        }
    }
}
