using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin
{
    public interface IIconControl
    {
        Image Icon { get; set; }
        ContentAlignment IconAlign { get; set; }
        Size IconSize { get; set; }
        ToolStripItemDisplayStyle DisplayStyle { get; set; }
        Padding IconMargin { get; set; }
    }
    public static class IIconControlExtensions
    {
        public static void DrawIcon(this IIconControl control, Graphics g)
        {
            if (control.Icon == null)
                return;
            if (control.DisplayStyle == ToolStripItemDisplayStyle.None || control.DisplayStyle == ToolStripItemDisplayStyle.Text)
                return;
            var iconMargin = control.IconMargin;
            var iconSize = control.IconSize;
            var controlRange = g.VisibleClipBounds;
            int PointX = 0;
            int PointY = 0;
            switch (control.IconAlign)
            {
                case ContentAlignment.BottomCenter:
                    PointX = (int)Math.Ceiling((controlRange.Width - iconSize.Width) / 2);
                    PointY = (int)Math.Ceiling(controlRange.Height - iconMargin.Bottom - iconSize.Height);
                    break;
                case ContentAlignment.BottomLeft:
                    PointX = iconMargin.Left;
                    PointY = (int)Math.Ceiling(controlRange.Height - iconMargin.Bottom - iconSize.Height);
                    break;
                case ContentAlignment.BottomRight:
                    PointX = (int)Math.Ceiling(controlRange.Width - iconSize.Width - iconMargin.Right);
                    PointY = (int)Math.Ceiling(controlRange.Height - iconMargin.Bottom - iconSize.Height);
                    break;
                case ContentAlignment.MiddleCenter:
                    PointX = (int)Math.Ceiling((controlRange.Width - iconSize.Width) / 2);
                    PointY = (int)Math.Ceiling((controlRange.Height - iconSize.Height) / 2);
                    break;
                default:
                case ContentAlignment.MiddleLeft:
                    PointX = iconMargin.Left;
                    PointY = (int)Math.Ceiling((controlRange.Height - iconSize.Height) / 2);
                    break;
                case ContentAlignment.MiddleRight:
                    PointX = (int)Math.Ceiling(controlRange.Width - iconSize.Width - iconMargin.Right);
                    PointY = (int)Math.Ceiling((controlRange.Height - iconSize.Height) / 2);
                    break;
                case ContentAlignment.TopCenter:
                    PointX = (int)Math.Ceiling((controlRange.Width - iconSize.Width) / 2);
                    PointY = iconMargin.Top;
                    break;
                case ContentAlignment.TopLeft:
                    PointX = iconMargin.Left;
                    PointY = iconMargin.Top;
                    break;
                case ContentAlignment.TopRight:
                    PointX = (int)Math.Ceiling(controlRange.Width - iconSize.Width - iconMargin.Right);
                    PointY = iconMargin.Top;
                    break;

            }
            var iconRect = new Rectangle(PointX, PointY, iconSize.Width, iconSize.Height);
            g.DrawImage(control.Icon, iconRect);
        }
    }
}
