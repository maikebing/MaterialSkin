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
        private string m_LeftText;
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

        private object m_LeftTag;
        [Browsable(false)]
        public object LeftTag
        {
            get { return m_LeftTag; }
            set { m_LeftTag = value; }
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
        private MaterialLinkLabel LeftLabel = null;
        private object m_RightTag;
        [Browsable(false)]
        public object RightTag
        {
            get { return m_RightTag; }
            set { m_RightTag = value; }
        }
        private MaterialLinkLabel RightLabel = null;
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
            };
            this.Controls.Add(LeftLabel);
            //添加右侧LinkLabel
            RightLabel = new MaterialLinkLabel
            {
                Text = RightText,
                Tag = RightTag,
                AutoSize = true,
            };
            RightLabel.Location = new Point(this.Width - RightLabel.Width - RightLabel.Margin.Left - RightLabel.Margin.Right, 0);
            this.Controls.Add(RightLabel);
        }
        #endregion

    }
}
