using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaterialSkin.Controls
{
    public class MaterialGroupBox : GroupBox, IMaterialControl
    {
        [Browsable(false)]
        public int Depth { get; set; }
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        public MaterialGroupBox()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //绘制文本

            //绘制分割线（根据theme）

            //
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e); 
        }
        protected override void OnControlRemoved(ControlEventArgs e)
        {
            base.OnControlRemoved(e);   
        }
    }
}
