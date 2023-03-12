using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace EosFauxShell
{
    public partial class Form1 : NomadForm
    {
        private readonly FormState _formState;
        private bool _altF4Pressed;

        private const int minimumWindowsWidth = 1024;
        private const int buttonColumnWidth = 120;
        private const int buttonRowHeight = 55;
        private const int addOnButtonsTop = 336;
        private const int nomadButtonsLeftFromRightEdge = 542;
        private int _addOnButtonsLeft = 0;

        private int _windowWidth;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private NomadButton btnRestore;
        private NomadButton btnMaximize;
        private NomadButton btnExit;
        private ApplicationControl _applicationControl;

        public Form1()
        {
            var screenWidth = Screen.FromControl(this).Bounds.Width;

            if (screenWidth < minimumWindowsWidth)
                _windowWidth = minimumWindowsWidth;

            _windowWidth = screenWidth - 100;
            _addOnButtonsLeft = _windowWidth - nomadButtonsLeftFromRightEdge;

            InitializeComponent();
            _formState = new FormState();
            _altF4Pressed = false;

            // wire up events
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;



            CheckExistingPassword();

        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _applicationControl = new ApplicationControl();
            btnRestore = new NomadButton();
            btnMaximize = new NomadButton();
            btnExit = new NomadButton();
            SuspendLayout();
            // 
            // _applicationControl
            // 
            _applicationControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _applicationControl.ExeName = "C:\\Program Files\\ETC\\EosFamily\\v3\\ETC_Launch\\ETC_LaunchOffline.exe";
            _applicationControl.Location = new Point(29, 30);
            _applicationControl.Name = "_applicationControl";
            _applicationControl.Size = new Size(_windowWidth, 450);
            _applicationControl.TabIndex = 0;

            // right column is 120px to the right of the left column
            // bottom row is 55px to the bottom of the current column

            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(_addOnButtonsLeft, addOnButtonsTop);
            btnRestore.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(103, 38);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "Restore";
            btnRestore.Click += btnRestore_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Location = new Point(_addOnButtonsLeft + buttonColumnWidth, addOnButtonsTop);
            btnMaximize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(103, 38);
            btnMaximize.TabIndex = 2;
            btnMaximize.Text = "Maximize";
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(_addOnButtonsLeft, addOnButtonsTop + buttonRowHeight);
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 38);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(_windowWidth, 525);
            KeyPreview = true;
            Controls.Add(btnExit);
            Controls.Add(btnMaximize);
            Controls.Add(btnRestore);
            Controls.Add(_applicationControl);
            Name = "Form1";
            Text = "ETCnomad Faux Shell";
            ResumeLayout(false);
        }




        void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                _altF4Pressed = true;
        }

        void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (_altF4Pressed)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = true;
                _altF4Pressed = false;
            }


        }

 
        private void btnRestore_Click(object? sender, EventArgs e)
        {
            _formState.Restore(this);
        }

        private void btnMaximize_Click(object? sender, EventArgs e)
        {
            _formState.Maximize(this);
        }

        private void btnExit_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Checks if there is an existing password set.  If not, it launches the SetInitialPassword method
        /// </summary>
        private void CheckExistingPassword()
        {
            var storedPassword = RegistryHelper.RetrievePassword();

            if (storedPassword == null) SetInitialPassword();
        }

        /// <summary>
        /// Prompts user to set the initial password
        /// </summary>
        private void SetInitialPassword()
        {
            var f = new FormSetPassword();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.HideCancel(true);
            f.ShowDialog();

        }
    }
}