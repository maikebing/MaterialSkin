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
            var controlRange = g.VisibleClipBounds;
            int PointX = 0;
            int PointY = 0;
            //switch (control.IconAlign)
            //{
            //    case ContentAlignment.BottomCenter
            //}
            var iconRect = new Rectangle(PointX, PointY, control.Icon.Width, control.Icon.Height);
            g.DrawImage(control.Icon, iconRect);
        }
    }
}
