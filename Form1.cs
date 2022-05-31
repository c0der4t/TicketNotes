using System;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MaterialSkin_TestApp
{
    public partial class frmMain : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        frmMain _MainFormLink;

        System.Drawing.Size CurrWindowSize;
        System.Drawing.Point CurrWindowLocation;
        
        public frmMain()
        {
            InitializeComponent();

            
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            _MainFormLink = this;
            CurrWindowSize = this.Size;
            CurrWindowLocation = this.Location;
        }


        private bool MouseInForm(frmMain TargetForm) =>
        TargetForm.ClientRectangle.Contains(TargetForm.PointToClient(Cursor.Position));

        private void frmMain_MouseEnter(object sender, System.EventArgs e)
        {
            this.Size = CurrWindowSize;
        }

        private void switch_ThemeMode_CheckedChanged(object sender, EventArgs e)
        {

            if (switch_ThemeMode.Checked)
            {
                //Turn on dark mode
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                switch_ThemeMode.BackColor = System.Drawing.Color.Red;
                
            }
            else
            {
                //Turn off dark mode
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void tmr_HideForm_Tick(object sender, EventArgs e)
        {
            if (!MouseInForm(_MainFormLink))
            {
                this.Height = 63;
            }
        }

        private void frmMain_ResizeEnd(object sender, EventArgs e)
        {
            CurrWindowSize = this.Size;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void sliderAutoCloseInterval_onValueChanged(object sender, int newValue)
        {
            if (sliderAutoCloseInterval.Value > 0)
            {
                tmr_HideForm.Enabled = false;
                tmr_HideForm.Interval = sliderAutoCloseInterval.Value * 1000;
                tmr_HideForm.Enabled = true;
            }
            else
            {
                tmr_HideForm.Enabled = false;
            }
        }

        private void btnCopyNotes_Click(object sender, EventArgs e)
        {
            string Notes = edtNotes.Text;
            Clipboard.SetText(Notes);
        }

        private void edtNotes_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                edtNotes.AppendText(edtLinePrefix.Text.ToString());
            }
        }
    }
}
