using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
