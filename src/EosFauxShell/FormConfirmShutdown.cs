namespace EosFauxShell
{
    public partial class FormConfirmShutdown : NomadForm
    {
        private Form _callingForm;

        public FormConfirmShutdown(Form callingForm)
        {
            InitializeComponent();
            _callingForm = callingForm;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _callingForm.Enabled = true;
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            _callingForm.Close();
        }
    }
}
