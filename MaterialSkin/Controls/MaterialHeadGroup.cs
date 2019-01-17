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
using System.IO;

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
        private Image m_LeftIcon;
        public Image LeftIcon
        {
            get { return m_LeftIcon; }
            set
            {
                m_LeftIcon = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        private MaterialLinkLabel LeftLabel = null;
        public event LinkLabelLinkClickedEventHandler LeftLinkClicked;
        private object m_RightTag;
        [Browsable(false)]
        public object RightTag
        {
            get { return m_RightTag; }
            set { m_RightTag = value; }
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
        private Image m_RightIcon;
        public Image RightIcon
        {
            get { return m_RightIcon; }
            set
            {
                m_RightIcon = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        private MaterialLinkLabel RightLabel = null;
        public event LinkLabelLinkClickedEventHandler RightLinkClicked;
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
                Image = LeftIcon,
            };
            LeftLabel.LinkClicked += (sender, e) =>
            {
                LeftLinkClicked?.Invoke(sender, e);
            };
            this.Controls.Add(LeftLabel);
            //添加右侧LinkLabel
            RightLabel = new MaterialLinkLabel
            {
                Text = RightText,
                Tag = RightTag,
                AutoSize = true,
                Font = SkinManager.ROBOTO_MEDIUM_10,
                Image = RightIcon,
            };
            RightLabel.LinkClicked += (sender, e) =>
              {
                  RightLinkClicked?.Invoke(sender, e);
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
