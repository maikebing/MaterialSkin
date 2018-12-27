namespace MaterialSkinExample.MaterialForms.UserControls
{
    partial class UCtrlNoticeRegion
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
            this.materialGroupBox1 = new MaterialSkin.Controls.MaterialGroupBox();
            this.materialIconButton11 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.materialGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialGroupBox1
            // 
            this.materialGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(246)))));
            this.materialGroupBox1.Controls.Add(this.materialIconButton11);
            this.materialGroupBox1.Controls.Add(this.materialListView1);
            this.materialGroupBox1.Depth = 0;
            this.materialGroupBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(165)))), ((int)(((byte)(31)))));
            this.materialGroupBox1.Icon = global::MaterialSkinExample.Properties.Resources.zhongyaotixing6;
            this.materialGroupBox1.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialGroupBox1.IconMargin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialGroupBox1.IconSize = new System.Drawing.Size(20, 20);
            this.materialGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.materialGroupBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialGroupBox1.Name = "materialGroupBox1";
            this.materialGroupBox1.Size = new System.Drawing.Size(515, 345);
            this.materialGroupBox1.SplitLineWeight = 2;
            this.materialGroupBox1.TabIndex = 2;
            this.materialGroupBox1.TabStop = false;
            this.materialGroupBox1.Text = "重要提醒";
            this.materialGroupBox1.TextRectangle = new System.Drawing.Rectangle(20, 0, 97, 20);
            // 
            // materialIconButton11
            // 
            this.materialIconButton11.AutoSize = true;
            this.materialIconButton11.Depth = 0;
            this.materialIconButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialIconButton11.Icon = global::MaterialSkinExample.Properties.Resources.icon_AR_jingtoushuaxin6;
            this.materialIconButton11.IconAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialIconButton11.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton11.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton11.Location = new System.Drawing.Point(492, -2);
            this.materialIconButton11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton11.Name = "materialIconButton11";
            this.materialIconButton11.Primary = true;
            this.materialIconButton11.Size = new System.Drawing.Size(20, 20);
            this.materialIconButton11.TabIndex = 1;
            this.materialIconButton11.Text = "materialIconButton11";
            // 
            // materialListView1
            // 
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(246)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.materialListView1.Location = new System.Drawing.Point(0, 23);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(515, 322);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // UCtrlNoticeRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialGroupBox1);
            this.Name = "UCtrlNoticeRegion";
            this.Size = new System.Drawing.Size(515, 345);
            this.materialGroupBox1.ResumeLayout(false);
            this.materialGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialGroupBox materialGroupBox1;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton11;
        private MaterialSkin.Controls.MaterialListView materialListView1;
    }
}
