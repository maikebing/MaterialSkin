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
    public class MaterialGroupBox : GroupBox, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public MaterialGroupBox()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //绘制文本
            DrawText(e.Graphics);
            //绘制分割线（根据theme）
            DrawSplitLine(e.Graphics);
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
        }
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);
        }
        /// <summary>
        /// 根据配置绘制文字
        /// </summary>
        /// <param name="g"></param>
        private void DrawText(Graphics g)
        {
            //获取文本绘制的区域
            var vSize = g.MeasureString(this.Text, this.Font);
            Rectangle textRectangle = new Rectangle(0, 10, (int)vSize.Width + 16, (int)vSize.Height);
            g.DrawString(
            Text.ToUpper(),
            SkinManager.ROBOTO_MEDIUM_10,
            Enabled ? (false ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(), textRectangle,
            new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
            );
        }
        /// <summary>
        /// 根据配置绘制文字
        /// </summary>
        /// <param name="g"></param>
        private void DrawSplitLine(Graphics g)
        {
            //获取文本绘制的区域
            var vSize = g.MeasureString(this.Text, this.Font);
            Pen vPen = new Pen(Color.LightBlue, 4);
            g.DrawLine(vPen, 0, (int)vSize.Height + 16, g.VisibleClipBounds.Width, (int)vSize.Height + 16);
        }
    }
}
