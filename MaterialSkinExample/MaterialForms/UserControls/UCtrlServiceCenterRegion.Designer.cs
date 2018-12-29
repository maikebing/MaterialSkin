namespace MaterialSkinExample.MaterialForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.m_btnCancel = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnSelectService = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnLinkTest = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnAdd = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnRemove = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnSave = new MaterialSkin.Controls.MaterialIconButton();
            this.m_grid = new MetroFramework.Controls.MetroGrid();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.m_btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.m_btnRemove);
            this.flowLayoutPanel1.Controls.Add(this.m_btnSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(503, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.m_btnCancel);
            this.flowLayoutPanel2.Controls.Add(this.m_btnSelectService);
            this.flowLayoutPanel2.Controls.Add(this.m_btnLinkTest);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 424);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(503, 30);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.AutoSize = true;
            this.m_btnCancel.Depth = 0;
            this.m_btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnCancel.Icon = global::MaterialSkinExample.Properties.Resources.tuichu_32x32__4FC3F7;
            this.m_btnCancel.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnCancel.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnCancel.IconSize = new System.Drawing.Size(20, 20);
            this.m_btnCancel.Location = new System.Drawing.Point(413, 3);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.m_btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Primary = true;
            this.m_btnCancel.Size = new System.Drawing.Size(79, 22);
            this.m_btnCancel.TabIndex = 2;
            this.m_btnCancel.Text = "取消";
            // 
            // m_btnSelectService
            // 
            this.m_btnSelectService.AutoSize = true;
            this.m_btnSelectService.Depth = 0;
            this.m_btnSelectService.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnSelectService.Icon = global::MaterialSkinExample.Properties.Resources.xuanze_32x32__4FC3F7;
            this.m_btnSelectService.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnSelectService.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnSelectService.IconSize = new System.Drawing.Size(24, 24);
            this.m_btnSelectService.Location = new System.Drawing.Point(330, 3);
            this.m_btnSelectService.Margin = new System.Windows.Forms.Padding(0);
            this.m_btnSelectService.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnSelectService.Name = "m_btnSelectService";
            this.m_btnSelectService.Primary = true;
            this.m_btnSelectService.Size = new System.Drawing.Size(83, 24);
            this.m_btnSelectService.TabIndex = 3;
            this.m_btnSelectService.Text = "选择";
            // 
            // m_btnLinkTest
            // 
            this.m_btnLinkTest.AutoSize = true;
            this.m_btnLinkTest.Depth = 0;
            this.m_btnLinkTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnLinkTest.Icon = global::MaterialSkinExample.Properties.Resources.link_32x32__4FC3F7;
            this.m_btnLinkTest.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnLinkTest.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnLinkTest.IconSize = new System.Drawing.Size(24, 24);
            this.m_btnLinkTest.Location = new System.Drawing.Point(209, 3);
            this.m_btnLinkTest.Margin = new System.Windows.Forms.Padding(0);
            this.m_btnLinkTest.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnLinkTest.Name = "m_btnLinkTest";
            this.m_btnLinkTest.Primary = true;
            this.m_btnLinkTest.Size = new System.Drawing.Size(121, 24);
            this.m_btnLinkTest.TabIndex = 4;
            this.m_btnLinkTest.Text = "测试连接";
            // 
            // m_btnAdd
            // 
            this.m_btnAdd.AutoSize = true;
            this.m_btnAdd.Depth = 0;
            this.m_btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnAdd.Icon = global::MaterialSkinExample.Properties.Resources.add_32x32__4FC3F7;
            this.m_btnAdd.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnAdd.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnAdd.IconSize = new System.Drawing.Size(24, 24);
            this.m_btnAdd.Location = new System.Drawing.Point(8, 3);
            this.m_btnAdd.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.m_btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnAdd.Name = "m_btnAdd";
            this.m_btnAdd.Primary = true;
            this.m_btnAdd.Size = new System.Drawing.Size(83, 24);
            this.m_btnAdd.TabIndex = 2;
            this.m_btnAdd.Text = "添加";
            // 
            // m_btnRemove
            // 
            this.m_btnRemove.AutoSize = true;
            this.m_btnRemove.Depth = 0;
            this.m_btnRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnRemove.Icon = global::MaterialSkinExample.Properties.Resources.remove_32x32__4FC3F7;
            this.m_btnRemove.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnRemove.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnRemove.IconSize = new System.Drawing.Size(24, 24);
            this.m_btnRemove.Location = new System.Drawing.Point(91, 3);
            this.m_btnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.m_btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnRemove.Name = "m_btnRemove";
            this.m_btnRemove.Primary = true;
            this.m_btnRemove.Size = new System.Drawing.Size(83, 24);
            this.m_btnRemove.TabIndex = 3;
            this.m_btnRemove.Text = "删除";
            // 
            // m_btnSave
            // 
            this.m_btnSave.AutoSize = true;
            this.m_btnSave.Depth = 0;
            this.m_btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnSave.Icon = global::MaterialSkinExample.Properties.Resources.save_32x32__4FC3F7;
            this.m_btnSave.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnSave.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnSave.IconSize = new System.Drawing.Size(24, 24);
            this.m_btnSave.Location = new System.Drawing.Point(174, 3);
            this.m_btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.m_btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnSave.Name = "m_btnSave";
            this.m_btnSave.Primary = true;
            this.m_btnSave.Size = new System.Drawing.Size(83, 24);
            this.m_btnSave.TabIndex = 4;
            this.m_btnSave.Text = "保存";
            // 
            // m_grid
            // 
            this.m_grid.AllowUserToResizeRows = false;
            this.m_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.m_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.m_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.m_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.m_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grid.EnableHeadersVisualStyles = false;
            this.m_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.m_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.m_grid.Location = new System.Drawing.Point(0, 30);
            this.m_grid.Name = "m_grid";
            this.m_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.m_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.m_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.m_grid.RowTemplate.Height = 27;
            this.m_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_grid.Size = new System.Drawing.Size(503, 394);
            this.m_grid.TabIndex = 4;
            // 
            // UCtrlServiceCenterRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_grid);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCtrlServiceCenterRegion";
            this.Size = new System.Drawing.Size(503, 454);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialIconButton m_btnAdd;
        private MaterialSkin.Controls.MaterialIconButton m_btnRemove;
        private MaterialSkin.Controls.MaterialIconButton m_btnSave;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialIconButton m_btnCancel;
        private MaterialSkin.Controls.MaterialIconButton m_btnSelectService;
        private MaterialSkin.Controls.MaterialIconButton m_btnLinkTest;
        private MetroFramework.Controls.MetroGrid m_grid;
    }
}
