namespace MaterialSkinExample.MaterialForms
{
    partial class ServiceCenterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uCtrlServiceCenterRegion1 = new MaterialSkinExample.MaterialForms.UCtrlServiceCenterRegion();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uCtrlServiceCenterRegion1
            // 
            this.uCtrlServiceCenterRegion1.BackColor = System.Drawing.Color.White;
            this.uCtrlServiceCenterRegion1.Depth = 0;
            this.uCtrlServiceCenterRegion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uCtrlServiceCenterRegion1.Location = new System.Drawing.Point(0, 10);
            this.uCtrlServiceCenterRegion1.MouseState = MaterialSkin.MouseState.HOVER;
            this.uCtrlServiceCenterRegion1.Name = "uCtrlServiceCenterRegion1";
            this.uCtrlServiceCenterRegion1.Size = new System.Drawing.Size(500, 348);
            this.uCtrlServiceCenterRegion1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.uCtrlServiceCenterRegion1);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel1.Size = new System.Drawing.Size(500, 368);
            this.panel1.TabIndex = 1;
            // 
            // ServiceCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.panel1);
            this.HamburgerBox = false;
            this.Name = "ServiceCenterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "数据中心配置";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialForms.UCtrlServiceCenterRegion uCtrlServiceCenterRegion1;
        private System.Windows.Forms.Panel panel1;
    }
}