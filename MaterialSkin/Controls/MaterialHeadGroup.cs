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
    public class MaterialHeadGroup : SplitContainer
    {
        private new int SplitterWidth = 1;

        public int SplitterWidth1
        {
            get => SplitterWidth;
            set { SplitterWidth = value; Invalidate(); }
        }
        protected override void OnPaint(PaintEventArgs e)
        {

        }
    }
}
