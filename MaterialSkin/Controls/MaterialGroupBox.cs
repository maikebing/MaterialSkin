using MaterialSkin.Designer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    [Designer(typeof(GroupBoxDesigner), typeof(IDesigner))]
    [DesignTimeVisible(true)]
    public class MaterialGroupBox : GroupBox, IMaterialControl, IIconControl, ITextControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public MaterialGroupBox()
        {
            //获取全局字体样式
            this.Font = SkinManager.ROBOTO_MEDIUM_10;
            //获取颜色样式
            this.ForeColor = Enabled ? (SkinManager.GetPrimaryTextColor()) : SkinManager.GetDisabledOrHintColor();
            //获取Icon配置
            IconSize = new Size(16, 16);
            Icon = global::MaterialSkin.Properties.Resources.Icon1;
            IconAlign = ContentAlignment.MiddleLeft;
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            HeadStyle = DockStyle.Top;
            //分割线
            this.SplitLineWeight = 2;
            this.SuspendLayout();
            //设置RightPanel
            TitlePanel = new FlowLayoutPanel
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                FlowDirection = FlowDirection.RightToLeft,
            };
            TitlePanel.SizeChanged += (sender, e) =>
               {
                   RefreshLayout();
               };
            this.Controls.Add(TitlePanel);
            RefreshLayout();
            this.ResumeLayout(false);
            //
            this.SizeChanged += (sender, e) =>
              {
                  RefreshLayout();
              };
        }

        #region Properties;
        #region 布局属性
        private DockStyle m_HeadStyle;

        public DockStyle HeadStyle
        {
            get { return m_HeadStyle; }
            set
            {
                m_HeadStyle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// 标题栏默认区域
        /// </summary>
        private Rectangle m_HeadRectangle = new Rectangle();
        protected virtual Rectangle HeadRectangle
        {
            get { return m_HeadRectangle; }
            set { m_HeadRectangle = value; }
        }
        [Browsable(false)]
        public ContentAlignment IconAlign { get; set; }
        [Browsable(false)]
        public ToolStripItemDisplayStyle DisplayStyle { get; set; }
        [Browsable(false)]
        public Padding IconMargin { get; set; }
        private Rectangle m_IconRectangle = new Rectangle();
        protected virtual Rectangle IconRectangle
        {
            get { return m_IconRectangle; }
            set { m_IconRectangle = value; }
        }
        private Rectangle m_TextRectangle = new Rectangle();
        [Browsable(false)]
        public Rectangle TextRectangle
        {
            get { return m_TextRectangle; }
            set { m_TextRectangle = value; }
        }
        private Size TextSize
        {
            get
            {
                return new Size(TextRectangle.Width, TextRectangle.Height);
            }
        }
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public FlowLayoutPanel TitlePanel = new FlowLayoutPanel();
        public int SplitLineWeight { get; set; }
        /// <summary>
        /// Panel的默认区域
        /// </summary>
        private Rectangle m_DisplayRectangle = new Rectangle();
        public override Rectangle DisplayRectangle
        {
            get
            {
                return m_DisplayRectangle;

            }
        }
        #endregion
        #region 内容属性

        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                Invalidate();
            }
        }
        private Image m_Icon;

        public Image Icon
        {
            get { return m_Icon; }
            set
            {
                if (m_Icon != value)
                {
                    m_Icon = value;
                    Invalidate();
                }
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

        #endregion

        #endregion
        protected override void OnPaint(PaintEventArgs e)
        {
            RefreshLayout();
            //绘制图标
            this.DrawIcon(e.Graphics, m_IconRectangle);
            //绘制文本
            this.DrawText(e.Graphics);
            //绘制分割线（根据theme）
            DrawSplitLine(e.Graphics);
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }

        /// <summary>
        /// 根据配置绘制分割线
        /// </summary>
        /// <param name="g"></param>
        private void DrawSplitLine(Graphics g)
        {
            if (SplitLineWeight <= 0)
                return;
            Pen vPen = new Pen(ForeColor, SplitLineWeight);
            PointF start = new PointF(0, HeadRectangle.Height);
            PointF end = new PointF(HeadRectangle.Width, HeadRectangle.Height);
            switch (HeadStyle)
            {
                default:
                case DockStyle.Top:
                    break;
                case DockStyle.Bottom:
                    end.Y = start.Y = g.VisibleClipBounds.Height - HeadRectangle.Height;
                    break;
                case DockStyle.Left:
                    start.X = end.X = HeadRectangle.Width;
                    start.Y = 0;
                    end.Y = HeadRectangle.Height;
                    break;
                case DockStyle.Right:
                    start.X = end.X = g.VisibleClipBounds.Width - HeadRectangle.Width;
                    start.Y = 0;
                    end.Y = HeadRectangle.Height;
                    break;
                case DockStyle.Fill:
                case DockStyle.None:
                    return;
            }
            g.DrawLine(vPen, start, end);
        }
        private void RefreshLayout()
        {
            switch (HeadStyle)
            {
                default:
                case DockStyle.Top:
                    RefreshLayoutWhenTop();
                    break;
                case DockStyle.Bottom:
                    RefreshLayoutWhenBottom();
                    break;
                case DockStyle.Left:
                    RefreshLayoutWhenLeft();
                    break;
                case DockStyle.Right:
                    RefreshLayoutWhenRight();
                    break;
                case DockStyle.None:
                case DockStyle.Fill:
                    throw new NotImplementedException();
                    break;
            }

        }
        private void RefreshLayoutWhenTop()
        {
            //Text
            var textSize = this.GetTextSize(CreateGraphics());
            m_TextRectangle.Width = textSize.Width;
            m_TextRectangle.Height = Math.Max(textSize.Height, IconSize.Height);
            m_TextRectangle.X = IconSize.Width;
            m_TextRectangle.Y = 0;
            //Icon
            var IconRemove = (int)(m_TextRectangle.Height - IconSize.Height) / 2;
            IconMargin = new Padding(2, IconRemove, 2, IconRemove);
            m_IconRectangle.Width = IconSize.Width;
            m_IconRectangle.Height = IconSize.Height;
            m_IconRectangle.X = m_IconRectangle.Y = 0;
            //HeadRectangle
            m_HeadRectangle.Width = this.Width;
            m_HeadRectangle.Height = m_TextRectangle.Height;
            m_HeadRectangle.X = m_HeadRectangle.Y = 0;
            //刷新标题栏布局
            TitlePanel.SuspendLayout();
            TitlePanel.Location = new Point(TextSize.Width + IconSize.Width, 0);
            //RightPanel.Height = TextSize.Height - 1;
            //RightPanel.Width = this.Width - TextSize.Width - IconSize.Width;
            TitlePanel.Height = 0;
            TitlePanel.Width = 0;
            TitlePanel.ResumeLayout(false);
            //Panel
            var headHeight = this.TextSize.Height + SplitLineWeight + 1;
            m_DisplayRectangle.Width = this.Width;
            m_DisplayRectangle.Height = this.Height - headHeight;
            m_DisplayRectangle.Y = this.Height - m_DisplayRectangle.Height;
            m_DisplayRectangle.X = 0;
        }
        private void RefreshLayoutWhenBottom()
        {
            //Text
            var textSize = this.GetTextSize(CreateGraphics());
            m_TextRectangle.Width = textSize.Width;
            m_TextRectangle.Height = Math.Max(textSize.Height, IconSize.Height);
            m_TextRectangle.X = IconSize.Width;
            m_TextRectangle.Y = this.Height - m_TextRectangle.Height;
            //Icon
            var IconRemove = (int)(m_TextRectangle.Height - IconSize.Height) / 2;
            IconMargin = new Padding(2, IconRemove, 2, IconRemove);
            m_IconRectangle.Width = IconSize.Width;
            m_IconRectangle.Height = IconSize.Height;
            m_IconRectangle.Y = this.Height - m_TextRectangle.Height;
            m_IconRectangle.X = 0;
            //HeadRectangle
            m_HeadRectangle.Width = this.Width;
            m_HeadRectangle.Height = m_TextRectangle.Height;
            m_HeadRectangle.Y = this.Height - m_HeadRectangle.Height;
            m_HeadRectangle.X = 0;
            //刷新标题栏布局
            TitlePanel.SuspendLayout();
            TitlePanel.Location = new Point(TextSize.Width + IconSize.Width, 0);
            //RightPanel.Height = TextSize.Height - 1;
            //RightPanel.Width = this.Width - TextSize.Width - IconSize.Width;
            TitlePanel.Height = 0;
            TitlePanel.Width = 0;
            TitlePanel.ResumeLayout(false);
            //Panel
            var headHeight = this.TextSize.Height + SplitLineWeight + 1;
            m_DisplayRectangle.Width = this.Width;
            m_DisplayRectangle.Height = this.Height - headHeight;
            m_DisplayRectangle.X = m_DisplayRectangle.Y = 0;
        }
        private void RefreshLayoutWhenLeft()
        {
            //Text
            var textSize = this.GetTextSize(CreateGraphics());
            m_TextRectangle.Height = textSize.Height;
            m_TextRectangle.Width = Math.Max(textSize.Width, IconSize.Width);
            m_TextRectangle.Y = IconSize.Height;
            m_TextRectangle.X = 0;
            //Icon
            var IconRemove = (int)(TextSize.Height - IconSize.Height) / 2;
            IconMargin = new Padding(2, IconRemove, 2, IconRemove);
            m_IconRectangle.Width = IconSize.Width;
            m_IconRectangle.Height = IconSize.Height;
            m_IconRectangle.X = m_IconRectangle.Y = 0;
            //HeadRectangle
            m_HeadRectangle.Height = this.Height;
            m_HeadRectangle.Width = TextSize.Width;
            m_HeadRectangle.X = m_HeadRectangle.Y = 0;
            //刷新标题栏布局
            TitlePanel.SuspendLayout();
            TitlePanel.Location = new Point(TextSize.Width + IconSize.Width, 0);
            //RightPanel.Height = TextSize.Height - 1;
            //RightPanel.Width = this.Width - TextSize.Width - IconSize.Width;
            TitlePanel.Height = 0;
            TitlePanel.Width = 0;
            TitlePanel.ResumeLayout(false);
            //Panel
            var UsedWidth = this.TextSize.Width + SplitLineWeight + 40 + +1;
            m_DisplayRectangle.Height = this.Height;
            m_DisplayRectangle.Width = this.Width - UsedWidth;
            m_DisplayRectangle.X = this.Width - m_DisplayRectangle.Width;
            m_DisplayRectangle.Y = 0;
        }
        private void RefreshLayoutWhenRight()
        {
            //Text
            var textSize = this.GetTextSize(CreateGraphics());
            m_TextRectangle.Height = textSize.Height;
            m_TextRectangle.Width = Math.Max(textSize.Width, IconSize.Width);
            m_TextRectangle.Y = IconSize.Height;
            m_TextRectangle.X = this.Width - m_TextRectangle.Width;
            //Icon
            var IconRemove = (int)(TextSize.Height - IconSize.Height) / 2;
            IconMargin = new Padding(2, IconRemove, 2, IconRemove);
            m_IconRectangle.Width = IconSize.Width;
            m_IconRectangle.Height = IconSize.Height;
            m_IconRectangle.X = this.Width - TextSize.Width;
            m_IconRectangle.Y = 0;
            //HeadRectangle
            m_HeadRectangle.Height = this.Height;
            m_HeadRectangle.Width = TextSize.Width;
            m_HeadRectangle.X = this.Width - TextSize.Width;
            m_HeadRectangle.Y = 0;
            //刷新标题栏布局
            TitlePanel.SuspendLayout();
            TitlePanel.Location = new Point(TextSize.Width + IconSize.Width, 0);
            //RightPanel.Height = TextSize.Height - 1;
            //RightPanel.Width = this.Width - TextSize.Width - IconSize.Width;
            TitlePanel.Height = 0;
            TitlePanel.Width = 0;
            TitlePanel.ResumeLayout(false);
            //Panel
            var UsedWidth = this.TextSize.Width + SplitLineWeight + 1;
            m_DisplayRectangle.Height = this.Height;
            m_DisplayRectangle.Width = this.Width - UsedWidth;
            m_DisplayRectangle.X = m_DisplayRectangle.Y = 0;
        }
    }
}
