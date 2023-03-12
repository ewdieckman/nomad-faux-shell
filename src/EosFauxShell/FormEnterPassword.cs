namespace EosFauxShell
{
    public partial class FormEnterPassword : NomadForm
    {
        private Form _callingForm;

        public FormEnterPassword(Form callingForm)
        {
            InitializeComponent();
            _callingForm = callingForm;
            _callingForm.Enabled = false;
            ActiveControl = textBoxPassword;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var existingPassword = RegistryHelper.RetrievePassword();

            if (existingPassword == null)
            {
                // wasn't set in the registry - just default to exiting, as there isn't we can do about it
                SuccessfulPassword();
                return;
            }

            var passwordHasher = new PasswordHasher();
            var passwordResult = passwordHasher.VerifyHashedPassword(existingPassword, textBoxPassword.Text);

            if (passwordResult == PasswordVerificationResult.Success)
            {
                SuccessfulPassword();
                return;
            }

            FailedPassword();

        }

        /// <summary>
        /// Method called when a success password is entered
        /// </summary>
        void SuccessfulPassword()
        {
            // show the Admin form
        }

        /// <summary>
        /// Method called when an incorrect password is entered
        /// </summary>
        void FailedPassword()
        {
            MessageBox.Show("Incorrect password entered.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxPassword.SelectionStart = 0;
            textBoxPassword.SelectionLength = textBoxPassword.Text.Length;
            textBoxPassword.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _callingForm.Enabled = true;
            Close();
        }
    }
}
