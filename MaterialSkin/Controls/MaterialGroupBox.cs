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
            this.SplitLineWeight = 4;
            this.TitleColor = Enabled ? (SkinManager.GetPrimaryTextColor()) : SkinManager.GetDisabledOrHintColor();
        }
        #region Properties
        public Color TitleColor { get; set; }
        public int SplitLineWeight { get; set; }
        #endregion
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
        /// Panel的默认区域
        /// </summary>
        public override Rectangle DisplayRectangle
        {
            get
            {
                return new Rectangle(base.DisplayRectangle.X, base.DisplayRectangle.Y + 20, base.DisplayRectangle.Width, base.DisplayRectangle.Height - 20);
            }
        }
        /// <summary>
        /// 根据配置绘制文字
        /// </summary>
        /// <param name="g"></param>
        private void DrawText(Graphics g)
        {
            //获取文本绘制的区域
            var vSize = g.MeasureString(this.Text.ToUpper(), this.Font);
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
            Pen vPen = new Pen(TitleColor, SplitLineWeight);
            g.DrawLine(vPen, 0, (int)vSize.Height + 16, g.VisibleClipBounds.Width, (int)vSize.Height + 16);
        }
    }
}
