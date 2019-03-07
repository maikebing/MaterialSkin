
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
    /// <summary>
    ///TODO: 封装MaterialComBoBox控件。
    /// </summary>
    public class MaterialComboBox : ComboBox, IMessageFilter, IMaterialControl
    {
       
      

        #region API函数
        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);//返回hWnd参数所指定的窗口的设备环境。   

        [System.Runtime.InteropServices.DllImport("user32.dll ")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC); //函数释放设备上下文环境（DC）   
        int WM_PAINT = 0xf; //要求一个窗口重画自己,即Paint事件时   
        int WM_CTLCOLOREDIT = 0x133;//当一个编辑型控件将要被绘制时发送此消息给它的父窗口；  
        #endregion

        #region 属性
        private ImageList _imageList;
        /// <summary>
        /// 需要显示在选择项前的图标
        /// </summary>
        [
        Category("自定义属性"),
        Description("需要显示在选择项前的图标集合")
        ]
        public ImageList ImageList
        {
            get { return _imageList; }
            set { _imageList = value; }
        }
        private Color _bdColor;
        /// <summary>
        /// 边框颜色
        /// </summary>
        [
        Category("自定义属性"),
        Description("设置边框颜色")
        ]
        public Color BdColor
        {
            get { return _bdColor; }
            set { _bdColor = value; }
        }
        private int _bdSize = 1;
        /// <summary>
        /// 边框粗细
        /// </summary>
        [
        Category("自定义属性"),
        Description("设置边框粗细")
        ]
        public int BdSize
        {
            get { return _bdSize; }
            set { _bdSize = value; }
        }
        private bool _disableWheel = false;
        /// <summary>
        /// 是否禁用鼠标滚轮
        /// </summary>
        [
        Category("自定义属性"),
        Description("是否禁用鼠标滚轮来更改当前选项")
        ]
        public bool DisableWheel
        {
            get { return _disableWheel; }
            set { _disableWheel = value; }
        }
        #endregion

        public bool PreFilterMessage(ref Message m)
        {
            //拦截0x020A鼠标滚轮消息
            if (m.Msg == 0x020A && _disableWheel)
                return true;
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT || m.Msg == WM_CTLCOLOREDIT)
            {
                IntPtr hDC = GetWindowDC(m.HWnd);
                if (hDC.ToInt32() == 0) //如果取设备上下文失败则返回   
                {
                    return;
                }
                //建立Graphics对像   
                Graphics g = Graphics.FromHdc(hDC);
                Pen p = new Pen(_bdColor, _bdSize);
                //画边框
                //g.DrawRectangle(p, 0, 0, Width, Height);
                ReleaseDC(m.HWnd, hDC);
            }
        }

        //重载OnDrawItem函数，来绘制组合框中每一列表项
        protected override void OnDrawItem(DrawItemEventArgs ea)
        {
            ea.DrawBackground();
            ea.DrawFocusRectangle();

            ImageComboBoxItem item;
            Size imageSize = new Size();
            if (ImageList != null)
            {
                imageSize = _imageList.ImageSize;
            }

            Rectangle bounds = ea.Bounds;

            try
            {
                item = (ImageComboBoxItem)Items[ea.Index];
                //如果当前项既有图像又有文本
                if (item.ImageIndex != -1)
                {
                    //画图像
                    _imageList.Draw(ea.Graphics, bounds.Left, bounds.Top, item.ImageIndex);
                    //绘制文本
                    ea.Graphics.DrawString(item.Text, ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left + imageSize.Width, bounds.Top);
                }
                else//只有文本，没有图像
                {
                    //写文本
                    ea.Graphics.DrawString(item.Text, ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                }
            }
            catch
            {
                if (ea.Index != -1)
                {
                    ea.Graphics.DrawString(Items[ea.Index].ToString(), ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                }
                else
                {
                    ea.Graphics.DrawString(Text, ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                }
            }
            base.OnDrawItem(ea);
        }

        //Properties for managing the material design properties
        /// <summary>
        /// Gets or sets the Depth
        /// </summary>
        [Browsable(false)]
        public int Depth { get; set; }

        /// <summary>
        /// Gets the SkinManager
        /// </summary>
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        /// <summary>
        /// Gets or sets the MouseState
        /// </summary>
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        /// <summary>
        /// Defines the BorderBrush
        /// </summary>
        private Brush BorderBrush = new SolidBrush(SystemColors.Window);

        /// <summary>
        /// Defines the ArrowBrush
        /// </summary>
        private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);

        /// <summary>
        /// Defines the DropButtonBrush
        /// </summary>
        private Brush DropButtonBrush = new SolidBrush(SystemColors.Control);

        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialComboBox"/> class.
        /// </summary>
        public MaterialComboBox()
        {

            base.OnCreateControl();
            ResetColors();
            DrawMode = DrawMode.OwnerDrawFixed;//设置绘画模式为手动
        }

        /// <summary>
        /// The ResetColors
        /// </summary>
        internal void ResetColors()
        {
            Brush br = new SolidBrush(SkinManager.GetControlBackgroundColor());
            Font = SkinManager.ROBOTO_REGULAR_11;
            BackColor = SkinManager.GetControlBackgroundColor();
            ForeColor = SkinManager.GetPrimaryTextColor();

            DropButtonBrush = br;
            ArrowBrush = SkinManager.GetPrimaryTextBrush();
            BorderBrush = br;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        /// <summary>
        /// The colorchange
        /// </summary>
        /// <param name="args">The args<see cref="EventArgs"/></param>
        protected void colorchange(EventArgs args)
        {
            ResetColors();
            DrawCombobox();
        }

        /// <summary>
        /// The OnBackColorChanged
        /// </summary>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            colorchange(e);
        }

        /// <summary>
        /// The OnForeColorChanged
        /// </summary>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            colorchange(e);
        }

        ///// <summary>
        ///// The WndProc
        ///// </summary>
        ///// <param name="m">The m<see cref="Message"/></param>
        //protected override void WndProc(ref Message m)
        //{

        //    base.WndProc(ref m);
        //    switch (m.Msg)
        //    {

        //        case 0xF:
        //            {
        //                DrawCombobox();
        //                break;
        //            }

        //        default:
        //            {
        //                break;
        //            }
        //    }
        //}

        // Override mouse and focus events to draw
        // proper borders. Basically, set the color and Invalidate(),
        // In general, Invalidate causes a control to redraw itself.
        /// <summary>
        /// The OnSelectedIndexChanged
        /// </summary>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            BorderBrush = SkinManager.GetDividersBrush();
            this.Invalidate();

        }

        /// <summary>
        /// The DrawCombobox
        /// </summary>
        protected void DrawCombobox()
        {
            SuspendLayout();
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(SkinManager.GetPrimaryTextColor(), 1);
            BorderBrush = new SolidBrush(SkinManager.GetApplicationBackgroundColor());
            g.Clear(SkinManager.GetApplicationBackgroundColor());
            g.FillRectangle(BorderBrush, this.ClientRectangle);
            g.DrawRectangle(new Pen(SkinManager.GetApplicationBackgroundColor(), 1), this.ClientRectangle.X, this.ClientRectangle.Y, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1);


            // Draw the background of the dropdown button
            Rectangle rect = new Rectangle(this.Width - 15, 3, 12, this.Height - 6);
            g.FillRectangle(DropButtonBrush, rect);

            // Create the path for the arrow
            System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
            PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
            PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);






            PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
            pth.AddLine(TopLeft, TopRight);
            pth.AddLine(TopRight, Bottom);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            // Determine the arrow's color.
            if (this.DroppedDown)
            {
                ArrowBrush = SkinManager.ColorScheme.AccentBrush;
            }
            else
            {
                ArrowBrush = SkinManager.GetPrimaryTextBrush();
            }

            // Draw the arrow
            g.FillPath(ArrowBrush, pth);

            if (DropDownStyle == ComboBoxStyle.DropDownList)
            {
                g.DrawString(this.Text, this.Font, SkinManager.GetPrimaryTextBrush(), ClientRectangle.X + 2, ClientRectangle.Y + 3);
            }

            ResumeLayout();
        }





        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            ;
            if (AutoSize == false) { return; }


            int width = this.DropDownWidth;
            Graphics g = this.CreateGraphics();
            Font font = this.Font;

            int vertScrollBarWidth = (this.Items.Count > this.MaxDropDownItems)
                    ? SystemInformation.VerticalScrollBarWidth : 0;

            var itemsList = this.Items.Cast<object>().Select(item => item.ToString());

            foreach (string s in itemsList)
            {
                int newWidth = (int)g.MeasureString(s, font).Width + vertScrollBarWidth;

                if (width < newWidth)
                {
                    width = newWidth;
                }
            }

            this.DropDownWidth = width;
            this.Width = width + 15;
        }
    }

    public class ImageComboBoxItem
    {
        private string _text;
        /// <summary>
        /// 文本属性
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private string _value;
        /// <summary>
        /// 选择项的值
        /// </summary>
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int _imageIndex;
        /// <summary>
        /// 定义图象索引属性
        /// </summary>
        public int ImageIndex
        {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }

        #region 构造函数
        public ImageComboBoxItem()
        {
            _text = "";
            _imageIndex = -1;
        }
        public ImageComboBoxItem(string text)
        {
            _text = text;
            _imageIndex = -1;
        }
        public ImageComboBoxItem(string text, int imageIndex)
        {
            _text = text;
            _imageIndex = imageIndex;
        }
        public ImageComboBoxItem(string text, int imageIndex, string value)
        {
            _text = text;
            _imageIndex = imageIndex;
            _value = value;
        }
        #endregion
        public override string ToString()
        {
            return _text;
        }

    }
}