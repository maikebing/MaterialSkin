using MaterialSkin.Animations;
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
            Primary = true;
            _animationManager = new AnimationManager(false)
            {
                Increment = 0.03,
                AnimationType = AnimationType.EaseOut
            };
            _hoverAnimationManager = new AnimationManager
            {
                Increment = 0.07,
                AnimationType = AnimationType.Linear
            };

            _hoverAnimationManager.OnAnimationProgress += sender => Invalidate();
            _animationManager.OnAnimationProgress += sender => Invalidate();
        }
        private readonly AnimationManager _animationManager;
        private readonly AnimationManager _hoverAnimationManager;
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private ContentAlignment m_IconAlign;

        public ContentAlignment IconAlign
        {
            get { return m_IconAlign; }
            set
            {
                m_IconAlign = value;
                Invalidate();
            }
        }
        private Size m_IconSize;

        public Size IconSize
        {
            get { return m_IconSize; }
            set
            {
                m_IconSize = value;
                Invalidate();
            }
        }
        private ToolStripItemDisplayStyle m_DisplayStyle;

        public ToolStripItemDisplayStyle DisplayStyle
        {
            get { return m_DisplayStyle; }
            set
            {
                m_DisplayStyle = value;
                Invalidate();
            }
        }
        private Padding m_IconMargin;

        public Padding IconMargin
        {
            get { return m_IconMargin; }
            set
            {
                m_IconMargin = value;
                Invalidate();
            }
        }
        private bool m_Primary;

        public bool Primary
        {
            get { return m_Primary; }
            set
            {
                m_Primary = value;
                Invalidate();
            }
        }


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
            //在此处处理动画效果 to do pzy

            this.DrawIcon(e.Graphics);
            //绘制文本
            this.DrawText(e.Graphics);
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (DesignMode) return;
            MouseState = MouseState.OUT;
            MouseEnter += (sender, args) =>
            {
                MouseState = MouseState.HOVER;
                _hoverAnimationManager.StartNewAnimation(AnimationDirection.In);
                Invalidate();
            };
            MouseLeave += (sender, args) =>
            {
                MouseState = MouseState.OUT;
                _hoverAnimationManager.StartNewAnimation(AnimationDirection.Out);
                Invalidate();
            };
            MouseDown += (sender, args) =>
            {
                if (args.Button == MouseButtons.Left)
                {
                    MouseState = MouseState.DOWN;

                    _animationManager.StartNewAnimation(AnimationDirection.In, args.Location);
                    Invalidate();
                }
            };
            MouseUp += (sender, args) =>
            {
                MouseState = MouseState.HOVER;

                Invalidate();
            };
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
                                tempWidth += Math.Max((IconSize.Width + IconMargin.Left + IconMargin.Right), (int)_textSize.Width + 16);
                                tempHeight += IconSize.Height + IconMargin.Top + IconMargin.Bottom + (int)_textSize.Height;
                                break;
                            case ContentAlignment.TopLeft:
                            case ContentAlignment.TopRight:
                            case ContentAlignment.BottomRight:
                            case ContentAlignment.BottomLeft:
                                tempWidth += ((IconSize.Width + IconMargin.Left + IconMargin.Right) + (int)_textSize.Width + 16);
                                tempHeight += IconSize.Height + IconMargin.Top + IconMargin.Bottom + (int)_textSize.Height;
                                break;
                            case ContentAlignment.MiddleCenter:
                                tempWidth += Math.Max((IconSize.Width + IconMargin.Left + IconMargin.Right), (int)_textSize.Width + 16);
                                tempHeight += Math.Max(IconSize.Height + IconMargin.Top + IconMargin.Bottom, (int)_textSize.Height);
                                break;
                            default:
                            case ContentAlignment.MiddleRight:
                            case ContentAlignment.MiddleLeft:
                                tempWidth += ((IconSize.Width + IconMargin.Left + IconMargin.Right) + (int)_textSize.Width + 16);
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
            if (Primary)
            {
                g.DrawString(
                Text.ToUpper(),
                SkinManager.ROBOTO_MEDIUM_10,
                Enabled ? (false ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(), new Rectangle(tempX, tempY, tempWidth, tempHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
            }
            else
            {
                g.DrawString(
                Text.ToUpper(),
                Font,
               new SolidBrush(ForeColor), new Rectangle(tempX, tempY, tempWidth, tempHeight),
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
            }
        }
    }
}
