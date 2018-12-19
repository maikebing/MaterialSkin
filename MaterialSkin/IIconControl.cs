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
        public static void DrawIcon(this IIconControl ctrl, Graphics g)
        {
            if (ctrl.Icon == null)
                return;
            if (ctrl.DisplayStyle == ToolStripItemDisplayStyle.None || ctrl.DisplayStyle == ToolStripItemDisplayStyle.Text)
                return;
            var iconRect = GetUsedRectangle(ctrl, g);
            g.DrawImage(ctrl.Icon, iconRect);
        }

        public static Rectangle GetRestRectangle(this IIconControl ctrl, Graphics g)
        {
            var ClientRectangle = g.VisibleClipBounds;
            int tempX = (int)ClientRectangle.X,
                tempY = (int)ClientRectangle.Y,
                tempWidth = (int)ClientRectangle.Width,
                tempHeight = (int)ClientRectangle.Height;
            var usedSize = GetUsedSize(ctrl);
            switch (ctrl.DisplayStyle)
            {
                default:
                case ToolStripItemDisplayStyle.None:
                case ToolStripItemDisplayStyle.Image:
                    //无需绘制其他元素
                    tempX = tempY = tempWidth = tempHeight = 0;
                    break;
                case ToolStripItemDisplayStyle.Text:
                case ToolStripItemDisplayStyle.ImageAndText:
                    switch (ctrl.IconAlign)
                    {
                        default:
                        case ContentAlignment.MiddleCenter:
                        case ContentAlignment.TopLeft:
                        case ContentAlignment.TopRight:
                        case ContentAlignment.BottomRight:
                        case ContentAlignment.BottomLeft:
                            break;
                        case ContentAlignment.TopCenter:
                            tempY = usedSize.Height;
                            tempHeight -= tempY;
                            break;
                        case ContentAlignment.BottomCenter:
                            tempHeight -= usedSize.Height;
                            break;
                        case ContentAlignment.MiddleRight:
                            tempWidth -= usedSize.Width;
                            break;
                        case ContentAlignment.MiddleLeft:
                            tempX = usedSize.Width;
                            tempWidth -= tempX;
                            break;
                    }
                    break;
            }
            return new Rectangle(tempX, tempY, tempWidth, tempHeight);
        }
        public static Rectangle GetUsedRectangle(this IIconControl ctrl, Graphics g)
        {
            var iconMargin = ctrl.IconMargin;
            var iconSize = ctrl.IconSize;
            var controlRange = g.VisibleClipBounds;
            int PointX = 0;
            int PointY = 0;
            switch (ctrl.IconAlign)
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
            return new Rectangle(PointX, PointY, iconSize.Width, iconSize.Height);
        }
        public static Size GetUsedSize(this IIconControl ctrl)
        {
            return new Size(ctrl.IconSize.Width + ctrl.IconMargin.Left + ctrl.IconMargin.Right, ctrl.IconSize.Height + ctrl.IconMargin.Top + ctrl.IconMargin.Bottom);
        }
    }
}
