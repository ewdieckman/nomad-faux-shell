using System.Diagnostics;

namespace EosFauxShell
{
    public partial class FormAdmin : NomadForm
    {
        private Form _callingForm;

        public FormAdmin(Form callingForm)
        {
            InitializeComponent();
            _callingForm = callingForm;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe");
            _callingForm.Close();
            Close();
        }

        private void buttonBackToEos_Click(object sender, EventArgs e)
        {
            _callingForm.Enabled = true;
            Close();
        }

        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
            Hide();
            var f = new FormSetPassword();
            f.FormClosed += (s, arg) => Show();
            f.ShowDialog();
        }
    }
}
