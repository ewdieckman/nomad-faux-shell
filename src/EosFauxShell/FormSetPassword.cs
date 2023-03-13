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
    public partial class FormSetPassword : NomadForm
    {
        public FormSetPassword()
        {
            InitializeComponent();

            ActiveControl = textBoxPassword;


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void HideCancel(bool hide)
        {
            buttonCancel.Visible = !hide;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            var result = CheckPassword();
            if (result)
            {
                RegistryHelper.SetPassword(textBoxPassword.Text.Trim());

                MessageBox.Show("Password set!", "Admin Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool CheckPassword()
        {
            labelFeedback.Visible = false;

            if (textBoxVerify.Text.Trim() == textBoxPassword.Text.Trim())
                return true;

            labelFeedback.Visible = true;
            return false;
        }
    }
}
