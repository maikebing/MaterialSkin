namespace MaterialSkinExample
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
            this.uCtrlServiceCenterRegion1 = new MaterialSkinExample.MaterialForms.UserControls.UCtrlServiceCenterRegion();
            this.SuspendLayout();
            // 
            // uCtrlServiceCenterRegion1
            // 
            this.uCtrlServiceCenterRegion1.BackColor = System.Drawing.Color.White;
            this.uCtrlServiceCenterRegion1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uCtrlServiceCenterRegion1.Location = new System.Drawing.Point(0, 62);
            this.uCtrlServiceCenterRegion1.Name = "uCtrlServiceCenterRegion1";
            this.uCtrlServiceCenterRegion1.Size = new System.Drawing.Size(512, 380);
            this.uCtrlServiceCenterRegion1.TabIndex = 0;
            // 
            // ServiceCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 442);
            this.Controls.Add(this.uCtrlServiceCenterRegion1);
            this.Name = "ServiceCenterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据中心配置";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialForms.UserControls.UCtrlServiceCenterRegion uCtrlServiceCenterRegion1;
    }
}