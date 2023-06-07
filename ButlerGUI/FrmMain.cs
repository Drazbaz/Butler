namespace ButlerGUI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            HideSidebarPanels();

            SizeChanged += FrmMain_SizeChanged!;
        }

        private void HideSidebarPanels()
        {
            PnlPlaylists.Visible = false;
        }

        private void FrmMain_SizeChanged(object sender, EventArgs e)
        {
            LblGreetingMessage.MinimumSize = PnlChildForm.Size;
        }

        

        private static void ToggleSidebarPanel(Panel panel)
        {
            if (panel.Visible is false)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void BtnPlaylist_Click(object sender, EventArgs e)
        {
            ToggleSidebarPanel(PnlPlaylists);
        }

        private void BtnCreatePlaylist_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FrmCreatePlaylist());
        }

        private void BtnComparePlaylists_Click(object sender, EventArgs e)
        {
            ShowChildForm(new FrmComparePlaylists());
        }

        private Form? _activeChildForm = null;
        private void ShowChildForm(Form childForm)
        {
            if (_activeChildForm is null)
            {
                ConfigureNewChildForm(childForm);
            }
            else if (_activeChildForm?.Name != childForm.Name)
            {
                _activeChildForm?.Close();
                ConfigureNewChildForm(childForm);
            }
        }

        private void ConfigureNewChildForm(Form childForm)
        {
            _activeChildForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = PnlChildForm.Size;

            PnlChildForm.Controls.Add(childForm);
            PnlChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
