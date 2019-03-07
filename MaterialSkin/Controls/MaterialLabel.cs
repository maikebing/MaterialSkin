namespace MaterialSkin.Controls
{
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="MaterialLabel" />
    /// </summary>
    public class MaterialLabel : Label, IMaterialControl
    {
        /// <summary>
        /// Gets or sets the Depth
        /// </summary>
        [Browsable(false)]
        public int Depth { get; set; }

        /// <summary>
        /// Gets the SkinManager
        /// </summary>
        [Browsable(false)]
        public MaterialSkinManager SkinManager => MaterialSkinManager.Instance;

        /// <summary>
        /// Gets or sets the MouseState
        /// </summary>
        [Browsable(false)]
        public MouseState MouseState { get; set; }
        private bool m_Primary = true;

        public bool Primary
        {
            get { return m_Primary; }
            set
            {
                m_Primary = value;
                Invalidate();
            }
        }

        /// <summary>
        /// The OnCreateControl
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (Primary)
            {
                ForeColor = SkinManager.GetPrimaryTextColor();
                Font = SkinManager.ROBOTO_REGULAR_11;
                BackColorChanged += (sender, args) => ForeColor = SkinManager.GetPrimaryTextColor();
            }
        }
    }
}
