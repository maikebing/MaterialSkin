namespace MaterialSkinExample
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialHeadGroup1 = new MaterialSkin.Controls.MaterialHeadGroup();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialHeadGroup1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(798, 448);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // materialHeadGroup1
            // 
            this.materialHeadGroup1.Depth = 0;
            this.materialHeadGroup1.LeftTag = null;
            this.materialHeadGroup1.LeftText = "这是一条测试消息!";
            this.materialHeadGroup1.Location = new System.Drawing.Point(3, 3);
            this.materialHeadGroup1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialHeadGroup1.Name = "materialHeadGroup1";
            this.materialHeadGroup1.RightTag = null;
            this.materialHeadGroup1.RightText = "详情";
            this.materialHeadGroup1.Size = new System.Drawing.Size(798, 23);
            this.materialHeadGroup1.TabIndex = 0;
            this.materialHeadGroup1.Text = "这是一条测试消息!";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.BdColor = System.Drawing.Color.Empty;
            this.materialComboBox1.BdSize = 1;
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DisableWheel = false;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.ImageList = null;
            this.materialComboBox1.Location = new System.Drawing.Point(145, 150);
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(121, 26);
            this.materialComboBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 661);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialHeadGroup materialHeadGroup1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
    }
}