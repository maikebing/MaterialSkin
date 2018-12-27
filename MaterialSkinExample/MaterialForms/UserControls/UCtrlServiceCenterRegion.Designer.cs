namespace MaterialSkinExample.MaterialForms.UserControls
{
    partial class UCtrlServiceCenterRegion
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialIconButton3 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialIconButton2 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialIconButton1 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialIconButton4 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialIconButton5 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialIconButton6 = new MaterialSkin.Controls.MaterialIconButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.materialIconButton3);
            this.flowLayoutPanel1.Controls.Add(this.materialIconButton2);
            this.flowLayoutPanel1.Controls.Add(this.materialIconButton1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 28);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // materialIconButton3
            // 
            this.materialIconButton3.AutoSize = true;
            this.materialIconButton3.Depth = 0;
            this.materialIconButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.materialIconButton3.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.materialIconButton3.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialIconButton3.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton3.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton3.Location = new System.Drawing.Point(3, 0);
            this.materialIconButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton3.Name = "materialIconButton3";
            this.materialIconButton3.Primary = true;
            this.materialIconButton3.Size = new System.Drawing.Size(79, 22);
            this.materialIconButton3.TabIndex = 2;
            this.materialIconButton3.Text = "添加";
            // 
            // materialIconButton2
            // 
            this.materialIconButton2.AutoSize = true;
            this.materialIconButton2.Depth = 0;
            this.materialIconButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.materialIconButton2.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.materialIconButton2.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialIconButton2.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton2.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton2.Location = new System.Drawing.Point(88, 0);
            this.materialIconButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton2.Name = "materialIconButton2";
            this.materialIconButton2.Primary = true;
            this.materialIconButton2.Size = new System.Drawing.Size(79, 22);
            this.materialIconButton2.TabIndex = 3;
            this.materialIconButton2.Text = "删除";
            // 
            // materialIconButton1
            // 
            this.materialIconButton1.AutoSize = true;
            this.materialIconButton1.Depth = 0;
            this.materialIconButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.materialIconButton1.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.materialIconButton1.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialIconButton1.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton1.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton1.Location = new System.Drawing.Point(173, 0);
            this.materialIconButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton1.Name = "materialIconButton1";
            this.materialIconButton1.Primary = true;
            this.materialIconButton1.Size = new System.Drawing.Size(79, 22);
            this.materialIconButton1.TabIndex = 4;
            this.materialIconButton1.Text = "保存";
            // 
            // materialListView1
            // 
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.Location = new System.Drawing.Point(0, 28);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(503, 426);
            this.materialListView1.TabIndex = 2;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "服务地址";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "服务端口";
            this.columnHeader3.Width = 200;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.materialIconButton4);
            this.flowLayoutPanel2.Controls.Add(this.materialIconButton5);
            this.flowLayoutPanel2.Controls.Add(this.materialIconButton6);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Enabled = false;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 424);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(503, 30);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // materialIconButton4
            // 
            this.materialIconButton4.AutoSize = true;
            this.materialIconButton4.Depth = 0;
            this.materialIconButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.materialIconButton4.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.materialIconButton4.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialIconButton4.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton4.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton4.Location = new System.Drawing.Point(421, 0);
            this.materialIconButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton4.Name = "materialIconButton4";
            this.materialIconButton4.Primary = true;
            this.materialIconButton4.Size = new System.Drawing.Size(79, 22);
            this.materialIconButton4.TabIndex = 2;
            this.materialIconButton4.Text = "取消";
            // 
            // materialIconButton5
            // 
            this.materialIconButton5.AutoSize = true;
            this.materialIconButton5.Depth = 0;
            this.materialIconButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.materialIconButton5.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.materialIconButton5.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialIconButton5.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton5.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton5.Location = new System.Drawing.Point(336, 0);
            this.materialIconButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton5.Name = "materialIconButton5";
            this.materialIconButton5.Primary = true;
            this.materialIconButton5.Size = new System.Drawing.Size(79, 22);
            this.materialIconButton5.TabIndex = 3;
            this.materialIconButton5.Text = "选择";
            // 
            // materialIconButton6
            // 
            this.materialIconButton6.AutoSize = true;
            this.materialIconButton6.Depth = 0;
            this.materialIconButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.materialIconButton6.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.materialIconButton6.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialIconButton6.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton6.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton6.Location = new System.Drawing.Point(213, 0);
            this.materialIconButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton6.Name = "materialIconButton6";
            this.materialIconButton6.Primary = true;
            this.materialIconButton6.Size = new System.Drawing.Size(117, 22);
            this.materialIconButton6.TabIndex = 4;
            this.materialIconButton6.Text = "测试连接";
            // 
            // UCtrlServiceCenterRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCtrlServiceCenterRegion";
            this.Size = new System.Drawing.Size(503, 454);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton3;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton2;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton4;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton5;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton6;
    }
}
