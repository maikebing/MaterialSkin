namespace MaterialSkinExample.UserControls
{
    partial class UCtrlLoginRegion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.m_btnLogin = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnCancel = new MaterialSkin.Controls.MaterialIconButton();
            this.m_btnDataCenter = new MaterialSkin.Controls.MaterialIconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.materialSingleLineTextField2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.m_btnLogin, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.m_btnCancel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.m_btnDataCenter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.materialComboBox1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialSingleLineTextField1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 170);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialSingleLineTextField2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.materialSingleLineTextField2, 2);
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Hint = "";
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(128, 45);
            this.materialSingleLineTextField2.MaxLength = 32767;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.PasswordChar = '\0';
            this.materialSingleLineTextField2.SelectedText = "";
            this.materialSingleLineTextField2.SelectionLength = 0;
            this.materialSingleLineTextField2.SelectionStart = 0;
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(247, 28);
            this.materialSingleLineTextField2.TabIndex = 14;
            this.materialSingleLineTextField2.TabStop = false;
            this.materialSingleLineTextField2.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 5);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Primary = true;
            this.materialLabel1.Size = new System.Drawing.Size(106, 24);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "用  户  名：";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(5, 47);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Primary = true;
            this.materialLabel2.Size = new System.Drawing.Size(107, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "密        码：";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(5, 89);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(5);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Primary = true;
            this.materialLabel3.Size = new System.Drawing.Size(105, 24);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "业务年度：";
            // 
            // materialComboBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.materialComboBox1, 2);
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.Location = new System.Drawing.Point(128, 87);
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(247, 26);
            this.materialComboBox1.TabIndex = 12;
            // 
            // materialSingleLineTextField1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.materialSingleLineTextField1, 2);
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(128, 3);
            this.materialSingleLineTextField1.MaxLength = 32767;
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(247, 28);
            this.materialSingleLineTextField1.TabIndex = 13;
            this.materialSingleLineTextField1.TabStop = false;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // m_btnLogin
            // 
            this.m_btnLogin.AutoSize = true;
            this.m_btnLogin.Depth = 0;
            this.m_btnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnLogin.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.m_btnLogin.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnLogin.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnLogin.IconSize = new System.Drawing.Size(16, 16);
            this.m_btnLogin.Location = new System.Drawing.Point(135, 136);
            this.m_btnLogin.Margin = new System.Windows.Forms.Padding(10);
            this.m_btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnLogin.Name = "m_btnLogin";
            this.m_btnLogin.Primary = true;
            this.m_btnLogin.Size = new System.Drawing.Size(75, 22);
            this.m_btnLogin.TabIndex = 9;
            this.m_btnLogin.Text = "登录";
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.AutoSize = true;
            this.m_btnCancel.Depth = 0;
            this.m_btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnCancel.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.m_btnCancel.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnCancel.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnCancel.IconSize = new System.Drawing.Size(16, 16);
            this.m_btnCancel.Location = new System.Drawing.Point(261, 136);
            this.m_btnCancel.Margin = new System.Windows.Forms.Padding(10);
            this.m_btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Primary = true;
            this.m_btnCancel.Size = new System.Drawing.Size(75, 22);
            this.m_btnCancel.TabIndex = 10;
            this.m_btnCancel.Text = "取消";
            // 
            // m_btnDataCenter
            // 
            this.m_btnDataCenter.AutoSize = true;
            this.m_btnDataCenter.Depth = 0;
            this.m_btnDataCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.m_btnDataCenter.Icon = global::MaterialSkinExample.Properties.Resources.shigongdanweisel4;
            this.m_btnDataCenter.IconAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_btnDataCenter.IconMargin = new System.Windows.Forms.Padding(0);
            this.m_btnDataCenter.IconSize = new System.Drawing.Size(16, 16);
            this.m_btnDataCenter.Location = new System.Drawing.Point(10, 136);
            this.m_btnDataCenter.Margin = new System.Windows.Forms.Padding(10);
            this.m_btnDataCenter.MouseState = MaterialSkin.MouseState.HOVER;
            this.m_btnDataCenter.Name = "m_btnDataCenter";
            this.m_btnDataCenter.Primary = true;
            this.m_btnDataCenter.Size = new System.Drawing.Size(105, 22);
            this.m_btnDataCenter.TabIndex = 11;
            this.m_btnDataCenter.Text = "数据中心";
            // 
            // UCtrlLoginRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UCtrlLoginRegion";
            this.Size = new System.Drawing.Size(378, 170);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialIconButton m_btnLogin;
        private MaterialSkin.Controls.MaterialIconButton m_btnCancel;
        private MaterialSkin.Controls.MaterialIconButton m_btnDataCenter;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField2;
    }
}
