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
    public class MaterialIconButton : Label, IMaterialControl, IIconControl
    {
        public MaterialIconButton()
        {
            //初始化缺省配置
            IconAlign = ContentAlignment.MiddleLeft;
            IconSize = new Size(24, 24);
            DisplayStyle = ToolStripItemDisplayStyle.None;
        }
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public ContentAlignment IconAlign { get; set; }
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
                Size = GetPreferredSize();
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            this.DrawIcon(e.Graphics);
            //绘制文本
            this.DrawText(e.Graphics);
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            ForeColor = SkinManager.GetPrimaryTextColor();
            Font = SkinManager.ROBOTO_REGULAR_11;
            BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
        }
        private Size GetPreferredSize()
        {
            if (AutoSize)
                return GetPreferredSize(new Size(0, 0));
            else
                return Size;
        }
        /// <summary>
        /// 计算适合控件的矩形区域
        /// </summary>
        /// <param name="proposedSize"></param>
        /// <returns></returns>
        public override Size GetPreferredSize(Size proposedSize)
        {
            int tempWidth = 0,
                tempHeight = 0;
            switch (DisplayStyle)
            {
                case ToolStripItemDisplayStyle.ImageAndText:
                    if (Icon != null && !string.IsNullOrEmpty(Text))
                    {
                        switch (IconAlign)
                        {
                            case ContentAlignment.TopCenter:
                            case ContentAlignment.BottomCenter:
                                tempWidth += Math.Max((IconSize.Width + IconMargin.Left + IconMargin.Right), (int)_textSize.Width+16);
                                tempHeight += IconSize.Height + IconMargin.Top + IconMargin.Bottom + (int)_textSize.Height;
                                break;
                            case ContentAlignment.TopLeft:
                            case ContentAlignment.TopRight:
                            case ContentAlignment.BottomRight:
                            case ContentAlignment.BottomLeft:
                                tempWidth += ((IconSize.Width + IconMargin.Left + IconMargin.Right) + (int)_textSize.Width+16);
                                tempHeight += IconSize.Height + IconMargin.Top + IconMargin.Bottom + (int)_textSize.Height;
                                break;
                            case ContentAlignment.MiddleCenter:
                                tempWidth += Math.Max((IconSize.Width + IconMargin.Left + IconMargin.Right), (int)_textSize.Width+16);
                                tempHeight += Math.Max(IconSize.Height + IconMargin.Top + IconMargin.Bottom, (int)_textSize.Height);
                                break;
                            default:
                            case ContentAlignment.MiddleRight:
                            case ContentAlignment.MiddleLeft:
                                tempWidth += ((IconSize.Width + IconMargin.Left + IconMargin.Right) + (int)_textSize.Width+16);
                                tempHeight += Math.Max(IconSize.Height + IconMargin.Top + IconMargin.Bottom, (int)_textSize.Height);
                                break;
                        }
                    }
                    break;
                default:
                case ToolStripItemDisplayStyle.None:
                    break;
                case ToolStripItemDisplayStyle.Image:
                    tempWidth += IconSize.Width + IconMargin.Left + IconMargin.Right;
                    tempHeight += IconSize.Height + IconMargin.Top + IconMargin.Bottom;
                    break;
                case ToolStripItemDisplayStyle.Text:
                    tempWidth += (int)_textSize.Width;
                    tempHeight += (int)_textSize.Height;
                    break;
            }
            //附加Padding
            tempWidth += Padding.Left + Padding.Right;
            tempHeight += Padding.Top + Padding.Bottom;
            return new Size(tempWidth, tempHeight);
        }
        /// <summary>
        /// 根据配置绘制文字, to do pzy
        /// </summary>
        /// <param name="g"></param>
        private void DrawText(Graphics g)
        {
            int tempX = ClientRectangle.X,
                tempY = ClientRectangle.Y,
                tempWidth = ClientRectangle.Width,
                tempHeight = ClientRectangle.Height;
            switch (DisplayStyle)
            {
                default:
                case ToolStripItemDisplayStyle.None:
                case ToolStripItemDisplayStyle.Image:
                    //无需绘制文本，直接退出
                    return;
                case ToolStripItemDisplayStyle.Text:
                case ToolStripItemDisplayStyle.ImageAndText:
                    if (string.IsNullOrEmpty(Text))
                        return;
                    switch (IconAlign)
                    {
                        default:
                        case ContentAlignment.MiddleCenter:
                        case ContentAlignment.TopLeft:
                        case ContentAlignment.TopRight:
                        case ContentAlignment.BottomRight:
                        case ContentAlignment.BottomLeft:
                            break;
                        case ContentAlignment.TopCenter:
                            tempY = IconSize.Height + IconMargin.Top + IconMargin.Bottom;
                            tempHeight -= tempY;
                            break;
                        case ContentAlignment.BottomCenter:
                            tempHeight -= (IconSize.Height + IconMargin.Top + IconMargin.Bottom);
                            break;
                        case ContentAlignment.MiddleRight:
                            tempWidth -= (IconSize.Width + IconMargin.Left + IconMargin.Right);
                            break;
                        case ContentAlignment.MiddleLeft:
                            tempX = (IconSize.Width + IconMargin.Left + IconMargin.Right);
                            tempWidth -= tempX;
                            break;
                    }
                    break;
            }
            g.DrawString(
                Text.ToUpper(),
                SkinManager.ROBOTO_MEDIUM_10,
                Enabled ? (false ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(), new Rectangle(tempX, tempY, tempWidth, tempHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
        }
    }
}
