using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Designer;

namespace MaterialSkin.Controls
{
    public class MaterialHeadGroup : Control, IMaterialControl
    {
        public MaterialHeadGroup()
        {
            this.Size = DefaultSize;
            this.SizeChanged += (sender, e) =>
            {
                if (RightLabel != null)
                    RightLabel.Location = new Point(this.Width - RightLabel.Width - RightLabel.Margin.Left - RightLabel.Margin.Right, 0);
            };
        }
        #region 属性
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        [Browsable(false)]
        public string LeftText
        {
            get { return Text; }
            set
            {
                Text = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public object LeftTag
        {
            get { return Tag; }
            set { Tag = value; }
        }
        private string m_RightText;
        public string RightText
        {
            get { return m_RightText; }
            set
            {
                m_RightText = value;
                Invalidate();
            }
        }
        [Browsable(false)]
        public MaterialLinkLabel LeftLabel = null;
        private object m_RightTag;
        [Browsable(false)]
        public object RightTag
        {
            get { return m_RightTag; }
            set { m_RightTag = value; }
        }
        [Browsable(false)]
        public MaterialLinkLabel RightLabel = null;
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent != null)
            {
                this.Width = Parent.Width;
            }
            base.OnPaint(e);
        }
        protected override void OnCreateControl()
        {
            //添加左侧LinkLabel
            LeftLabel = new MaterialLinkLabel
            {
                Text = LeftText,
                Tag = LeftTag,
                AutoSize = true,
                Font = SkinManager.ROBOTO_MEDIUM_10,
            };
            this.Controls.Add(LeftLabel);
            //添加右侧LinkLabel
            RightLabel = new MaterialLinkLabel
            {
                Text = RightText,
                Tag = RightTag,
                AutoSize = true,
                Font = SkinManager.ROBOTO_MEDIUM_10,
            };
            RightLabel.Location = new Point(this.Width - RightLabel.Width - RightLabel.Margin.Left - RightLabel.Margin.Right, 0);
            if (Parent != null)
                this.Width = Parent.Width;
            this.Height = Math.Max(LeftLabel.Height, RightLabel.Height);
            this.Controls.Add(RightLabel);
        }
        #endregion

    }
}
