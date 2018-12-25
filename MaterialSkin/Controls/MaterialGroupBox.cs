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
            IconAlign = ContentAlignment.MiddleLeft;
            IconSize = new Size(24, 24);
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            IconMargin = new Padding(3);
            //分割线
            this.SplitLineWeight = 2;
        }

        #region Properties
        public int SplitLineWeight { get; set; }
        public override string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                var textSize = this.GetTextSize(CreateGraphics());
                m_TextRectangle.Width = textSize.Width;
                m_TextRectangle.Height = textSize.Height > m_TextRectangle.Height ? textSize.Height : m_TextRectangle.Height;
                Invalidate();
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            //绘制图标
            this.DrawIcon(e.Graphics, new Rectangle(0, 0, IconSize.Width, IconSize.Height));
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
        /// Panel的默认区域
        /// </summary>
        public override Rectangle DisplayRectangle
        {
            get
            {
                var headHeight = this.TextSize.Height + SplitLineWeight + 1;
                return new Rectangle(0, headHeight, this.Width, this.Height - headHeight);
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
                }
            }
        }
        [Browsable(false)]
        public ContentAlignment IconAlign { get; set; }
        private Size m_IconSize;

        public Size IconSize
        {
            get { return m_IconSize; }
            set
            {
                m_IconSize = value;
                m_TextRectangle.X = IconSize.Width;
                m_TextRectangle.Height = IconSize.Height > m_TextRectangle.Height ? IconSize.Height : m_TextRectangle.Height;
            }
        }

        [Browsable(false)]
        public ToolStripItemDisplayStyle DisplayStyle { get; set; }
        [Browsable(false)]
        public Padding IconMargin { get; set; }
        private Size m_TextSize;
        private Size TextSize
        {
            get
            {
                return new Size(TextRectangle.Width, TextRectangle.Height);
            }
        }
        private Rectangle m_TextRectangle = new Rectangle();
        [Browsable(false)]
        public Rectangle TextRectangle
        {
            get { return m_TextRectangle; }
            set { m_TextRectangle = value; }
        }

        /// <summary>
        /// 根据配置绘制分割线
        /// </summary>
        /// <param name="g"></param>
        private void DrawSplitLine(Graphics g)
        {
            Pen vPen = new Pen(ForeColor, SplitLineWeight);
            g.DrawLine(vPen, 0, TextSize.Height, g.VisibleClipBounds.Width, TextSize.Height);
        }
    }
}
