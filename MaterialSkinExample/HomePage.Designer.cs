namespace MaterialSkinExample
{
    partial class HomePage
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.m_panelForm = new System.Windows.Forms.Panel();
            this.m_panelContent = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.m_panelLeft = new System.Windows.Forms.Panel();
            this.m_flowPanelLeftMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.m_panelTop = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.m_flowPanelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.m_flowPanelTopMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.m_panelForm.SuspendLayout();
            this.m_panelContent.SuspendLayout();
            this.m_panelLeft.SuspendLayout();
            this.m_panelTop.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // m_panelForm
            // 
            this.m_panelForm.BackgroundImage = global::MaterialSkinExample.Properties.Resources.background;
            this.m_panelForm.Controls.Add(this.m_panelContent);
            this.m_panelForm.Controls.Add(this.m_panelLeft);
            this.m_panelForm.Controls.Add(this.m_panelTop);
            this.m_panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_panelForm.Location = new System.Drawing.Point(0, 0);
            this.m_panelForm.Name = "m_panelForm";
            this.m_panelForm.Size = new System.Drawing.Size(982, 551);
            this.m_panelForm.TabIndex = 0;
            // 
            // m_panelContent
            // 
            this.m_panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.m_panelContent.Controls.Add(this.materialLabel1);
            this.m_panelContent.Controls.Add(this.materialFlatButton1);
            this.m_panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_panelContent.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.m_panelContent.Location = new System.Drawing.Point(20, 66);
            this.m_panelContent.Name = "m_panelContent";
            this.m_panelContent.Size = new System.Drawing.Size(962, 485);
            this.m_panelContent.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(433, 167);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(136, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(384, 90);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(213, 36);
            this.materialFlatButton1.TabIndex = 0;
            this.materialFlatButton1.Text = "materialFlatButton1";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // m_panelLeft
            // 
            this.m_panelLeft.BackColor = System.Drawing.Color.Transparent;
            this.m_panelLeft.Controls.Add(this.m_flowPanelLeftMenu);
            this.m_panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_panelLeft.Location = new System.Drawing.Point(0, 66);
            this.m_panelLeft.Name = "m_panelLeft";
            this.m_panelLeft.Size = new System.Drawing.Size(20, 485);
            this.m_panelLeft.TabIndex = 1;
            // 
            // m_flowPanelLeftMenu
            // 
            this.m_flowPanelLeftMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_flowPanelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.m_flowPanelLeftMenu.Name = "m_flowPanelLeftMenu";
            this.m_flowPanelLeftMenu.Size = new System.Drawing.Size(20, 485);
            this.m_flowPanelLeftMenu.TabIndex = 0;
            // 
            // m_panelTop
            // 
            this.m_panelTop.BackColor = System.Drawing.Color.Transparent;
            this.m_panelTop.Controls.Add(this.tableLayoutPanel1);
            this.m_panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_panelTop.Location = new System.Drawing.Point(0, 0);
            this.m_panelTop.Name = "m_panelTop";
            this.m_panelTop.Size = new System.Drawing.Size(982, 66);
            this.m_panelTop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.m_flowPanelTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.m_flowPanelTopMenu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 66);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // m_flowPanelTitle
            // 
            this.m_flowPanelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_flowPanelTitle.Location = new System.Drawing.Point(3, 3);
            this.m_flowPanelTitle.Name = "m_flowPanelTitle";
            this.m_flowPanelTitle.Size = new System.Drawing.Size(337, 60);
            this.m_flowPanelTitle.TabIndex = 1;
            // 
            // m_flowPanelTopMenu
            // 
            this.m_flowPanelTopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_flowPanelTopMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.m_flowPanelTopMenu.ForeColor = System.Drawing.Color.White;
            this.m_flowPanelTopMenu.Location = new System.Drawing.Point(346, 3);
            this.m_flowPanelTopMenu.Name = "m_flowPanelTopMenu";
            this.m_flowPanelTopMenu.Size = new System.Drawing.Size(633, 60);
            this.m_flowPanelTopMenu.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 551);
            this.Controls.Add(this.m_panelForm);
            this.HelpButton = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "窗口";
            this.m_panelForm.ResumeLayout(false);
            this.m_panelContent.ResumeLayout(false);
            this.m_panelContent.PerformLayout();
            this.m_panelLeft.ResumeLayout(false);
            this.m_panelTop.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_panelForm;
        private System.Windows.Forms.Panel m_panelLeft;
        private System.Windows.Forms.Panel m_panelTop;
        private System.Windows.Forms.Panel m_panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel m_flowPanelLeftMenu;
        private System.Windows.Forms.FlowLayoutPanel m_flowPanelTopMenu;
        private System.Windows.Forms.FlowLayoutPanel m_flowPanelTitle;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

