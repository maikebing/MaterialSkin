using MaterialSkin.Designer;
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
    [Designer(typeof(GroupBoxDesigner))]
    [DesignTimeVisible(true)]
    public class MaterialGroupBox : ContainerControl, IMaterialControl
    {
        public MaterialGroupBox()
        {
            TitlePanel1 = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                Location = new Point(0, 0),
                Width = 100,
                Height = 30,
            };
            TitlePanel1.SizeChanged += (sender, e) =>
            {
                this.TitleHeight = TitlePanel1.Height;
                this.TitleWidth = TitlePanel1.Width;
            };
            TitlePanel2 = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.RightToLeft,
            };
            TitlePanel2.SizeChanged += (sender, e) =>
            {
                TitlePanel2.Width = this.Width - TitleWidth;
                TitlePanel2.Height = TitleHeight;
            };
            ContentPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
            };
            ContentPanel.SizeChanged += (sender, e) =>
            {
                ContentPanel.Width = this.Width;
                ContentPanel.Height = this.Height - this.TitleHeight - SplitLineWeight;
            };
            splitterRect = new Rectangle();
            SplitLineWeight = 2;
            //default size
            this.Size = new Size(200, 200);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.Controls.Add(TitlePanel1);
            this.Controls.Add(TitlePanel2);
            this.Controls.Add(ContentPanel);
            UpdateLayout();
        }
        public FlowLayoutPanel TitlePanel1 { get; } = null;
        public FlowLayoutPanel TitlePanel2 { get; } = null;
        public int TitleWidth
        {
            get { return TitlePanel1.Width; }
            set
            {
                TitlePanel1.Width = value;
                Invalidate();
            }
        }

        public int TitleHeight
        {
            get { return TitlePanel1.Height; }
            set
            {
                TitlePanel1.Height = value;
                Invalidate();
            }
        }

        #region SplitRectangle 
        private Rectangle splitterRect;
        public int SplitLineWeight { get; set; }
        public Color SplitLineColor { get; set; }
        /// <summary>
        /// 初始化分割条
        /// </summary>
        void InitSplitLine()
        {
            SplitLineWeight = 4;

        }
        #endregion
        #region Content
        public FlowLayoutPanel ContentPanel { get; set; }
        #endregion
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //更新布局
            UpdateLayout();
            //绘制文本
            //DrawText(e.Graphics);
            //绘制分割线（根据theme）
            DrawSplitLine(e.Graphics);
        }
        /// <summary>
        /// TODO:根据控件的内容计算控件的Size
        /// </summary>
        /// <param name="e"></param>
        protected override void OnAutoSizeChanged(EventArgs e)
        {
            base.OnAutoSizeChanged(e);
        }

        /// <summary>
        /// TODO:重新计算控件的Size
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClientSizeChanged(EventArgs e)
        {
            base.OnClientSizeChanged(e);
        }
        /// <summary>
        /// TODO:
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
        /// <summary>
        /// 根据配置绘制文字
        /// </summary>
        /// <param name="g"></param>
        private void DrawText(Graphics g)
        {
            //获取文本绘制的区域
            var vSize = g.MeasureString(this.Text, this.Font);
            Rectangle textRectangle = new Rectangle(0, 8, (int)vSize.Width + 32, (int)vSize.Height);
            g.DrawString(
            Text.ToUpper(),
            SkinManager.ROBOTO_MEDIUM_10,
            Enabled ? (false ? SkinManager.ColorScheme.PrimaryBrush : SkinManager.GetPrimaryTextBrush()) : SkinManager.GetFlatButtonDisabledTextBrush(), textRectangle,
            new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center }
            );
        }
        /// <summary>
        /// 绘制分割线
        /// </summary>
        /// <param name="g"></param>
        private void DrawSplitLine(Graphics g)
        {
            //获取文本绘制的区域
            splitterRect = new Rectangle(0, TitleHeight, this.Width, SplitLineWeight);
            Pen vPen = new Pen(SplitLineColor, SplitLineWeight);
            g.DrawRectangle(vPen, splitterRect);
        }
        private bool initializing = false;
        public void BeginInit()
        {
            initializing = true;
        }

        public void EndInit()
        {
            initializing = false;
            //TODO:

            //do something 
        }
        /// <summary>
        /// TODO:更新布局
        /// </summary>
        void UpdateLayout()
        {
            if (this.Width >= TitleWidth + TitlePanel2.Width)
            {
                TitlePanel2.Width = this.Width - TitleWidth;
            }
            else
            {
                this.Width = TitleWidth + TitlePanel2.Width;
            }
            if (this.Height >= TitleHeight + this.ContentPanel.Height + SplitLineWeight)
            {
                this.ContentPanel.Height = this.Height - TitleHeight - SplitLineWeight;
            }
            else
            {
                this.Height = TitleHeight + this.ContentPanel.Height + SplitLineWeight;
            }
            //更新标题栏的布局
            this.TitlePanel2.Location = new Point(this.TitleWidth, 0);
            //更新内容布局
            this.ContentPanel.Location = new Point(0, this.TitleHeight);
        }
    }
}
