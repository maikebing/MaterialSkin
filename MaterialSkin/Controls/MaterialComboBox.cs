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
    public class MaterialComboBox : ComboBox, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {

            base.OnPaint(e);
            //Rectangle rect = new Rectangle(ClientRectangle.Width - 20, 0, 20, 20);
            //ComboBoxRenderer.DrawDropDownButton(e.Graphics, rect, System.Windows.Forms.VisualStyles.ComboBoxState.Normal);
        }

    }

    public partial class ComboBoxControl : System.Windows.Forms.ComboBox, IMessageFilter//继承自ComboBox
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

        public ComboBoxControl()
        {
            DrawMode = DrawMode.OwnerDrawFixed;//设置绘画模式为手动
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
                g.DrawRectangle(p, 0, 0, Width, Height);
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

        #region IMessageFilter 成员
        /// <summary>
        /// 消息筛选器
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool PreFilterMessage(ref Message m)
        {
            //拦截0x020A鼠标滚轮消息
            if (m.Msg == 0x020A && _disableWheel)
                return true;
            return false;
        }
        #endregion

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
