using MaterialSkin.Animations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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
                var sizef = CreateGraphics().MeasureString(value.ToUpper(), SkinManager.ROBOTO_MEDIUM_10);
                _textSize = new SizeF(sizef.Width + 16, sizef.Height);
                Size = GetPreferredSize();
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            //在此处处理动画效果 to do pzy
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            //g.Clear(Parent.BackColor);
            //Hover
            Color c = BackColor;
            using (Brush b = new SolidBrush(Color.FromArgb((int)(_hoverAnimationManager.GetProgress() * c.A), c.RemoveAlpha())))
                g.FillRectangle(b, ClientRectangle);

            //Ripple
            if (_animationManager.IsAnimating())
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                for (var i = 0; i < _animationManager.GetAnimationCount(); i++)
                {
                    var animationValue = _animationManager.GetProgress(i);
                    var animationSource = _animationManager.GetSource(i);

                    using (Brush rippleBrush = new SolidBrush(Color.FromArgb((int)(101 - (animationValue * 100)), BackColor)))
                    {
                        var rippleSize = (int)(animationValue * Width * 2);
                        g.FillEllipse(rippleBrush, new Rectangle(animationSource.X - rippleSize / 2, animationSource.Y - rippleSize / 2, rippleSize, rippleSize));
                    }
                }
                g.SmoothingMode = SmoothingMode.None;
            }
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
            var iconUsedSize = this.GetUsedSize();
            switch (DisplayStyle)
            {
                case ToolStripItemDisplayStyle.ImageAndText:
                    if (Icon != null && !string.IsNullOrEmpty(Text))
                    {
                        switch (IconAlign)
                        {
                            case ContentAlignment.TopCenter:
                            case ContentAlignment.BottomCenter:
                                tempWidth += Math.Max((iconUsedSize.Width), (int)_textSize.Width);
                                tempHeight += iconUsedSize.Height + (int)_textSize.Height;
                                break;
                            case ContentAlignment.TopLeft:
                            case ContentAlignment.TopRight:
                            case ContentAlignment.BottomRight:
                            case ContentAlignment.BottomLeft:
                                tempWidth += ((iconUsedSize.Width) + (int)_textSize.Width);
                                tempHeight += iconUsedSize.Height + (int)_textSize.Height;
                                break;
                            case ContentAlignment.MiddleCenter:
                                tempWidth += Math.Max((iconUsedSize.Width), (int)_textSize.Width);
                                tempHeight += Math.Max(iconUsedSize.Height, (int)_textSize.Height);
                                break;
                            default:
                            case ContentAlignment.MiddleRight:
                            case ContentAlignment.MiddleLeft:
                                tempWidth += ((iconUsedSize.Width) + (int)_textSize.Width);
                                tempHeight += Math.Max(iconUsedSize.Height, (int)_textSize.Height);
                                break;
                        }
                    }
                    break;
                default:
                case ToolStripItemDisplayStyle.None:
                    break;
                case ToolStripItemDisplayStyle.Image:
                    tempWidth += iconUsedSize.Width;
                    tempHeight += iconUsedSize.Height;
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
        /// 根据配置绘制文字
        /// </summary>
        /// <param name="g"></param>
        private void DrawText(Graphics g)
        {
            if (string.IsNullOrEmpty(Text) || DisplayStyle == ToolStripItemDisplayStyle.None || DisplayStyle == ToolStripItemDisplayStyle.Image)
                return;
            //获取文本绘制的区域
            Rectangle textRectangle = this.GetRestRectangle(g);
            if (Primary)
            {
                g.DrawString(
                Text.ToUpper(),
                SkinManager.ROBOTO_MEDIUM_10,
                Enabled ? (false ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(), textRectangle,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
            }
            else
            {
                g.DrawString(
                Text.ToUpper(),
                Font,
               new SolidBrush(ForeColor), textRectangle,
                new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
                );
            }
        }
    }
}
