namespace MaterialSkinExample.MaterialForms.UserControls
{
    partial class UCtrlTasksRegion
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
            this.materialGroupBox2 = new MaterialSkin.Controls.MaterialGroupBox();
            this.materialIconButton12 = new MaterialSkin.Controls.MaterialIconButton();
            this.materialGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialGroupBox2
            // 
            this.materialGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.materialGroupBox2.Controls.Add(this.materialIconButton12);
            this.materialGroupBox2.Depth = 0;
            this.materialGroupBox2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.materialGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(136)))), ((int)(((byte)(194)))));
            this.materialGroupBox2.Icon = global::MaterialSkinExample.Properties.Resources.woderenwu_14;
            this.materialGroupBox2.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialGroupBox2.IconMargin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialGroupBox2.IconSize = new System.Drawing.Size(20, 20);
            this.materialGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.materialGroupBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialGroupBox2.Name = "materialGroupBox2";
            this.materialGroupBox2.Size = new System.Drawing.Size(517, 462);
            this.materialGroupBox2.SplitLineWeight = 2;
            this.materialGroupBox2.TabIndex = 2;
            this.materialGroupBox2.TabStop = false;
            this.materialGroupBox2.Text = "我的任务";
            this.materialGroupBox2.TextRectangle = new System.Drawing.Rectangle(20, 0, 97, 20);
            // 
            // materialIconButton12
            // 
            this.materialIconButton12.AutoSize = true;
            this.materialIconButton12.Depth = 0;
            this.materialIconButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialIconButton12.Icon = global::MaterialSkinExample.Properties.Resources.icon_AR_jingtoushuaxin4;
            this.materialIconButton12.IconAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialIconButton12.IconMargin = new System.Windows.Forms.Padding(0);
            this.materialIconButton12.IconSize = new System.Drawing.Size(20, 20);
            this.materialIconButton12.Location = new System.Drawing.Point(492, -2);
            this.materialIconButton12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialIconButton12.Name = "materialIconButton12";
            this.materialIconButton12.Primary = true;
            this.materialIconButton12.Size = new System.Drawing.Size(20, 20);
            this.materialIconButton12.TabIndex = 2;
            this.materialIconButton12.Text = "materialIconButton12";
            // 
            // UCtrlTasksRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.materialGroupBox2);
            this.Name = "UCtrlTasksRegion";
            this.Size = new System.Drawing.Size(517, 462);
            this.materialGroupBox2.ResumeLayout(false);
            this.materialGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialGroupBox materialGroupBox2;
        private MaterialSkin.Controls.MaterialIconButton materialIconButton12;
    }
}
