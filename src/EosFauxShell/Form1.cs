using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EosFauxShell
{
    public partial class Form1 : Form
    {
        private readonly FormState _formState;
        private bool _altF4Pressed;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        private ApplicationControl _applicationControl;

        public Form1()
        {
            InitializeComponent();
            _formState = new FormState();
            _altF4Pressed = false;

            // wire up events
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;

            // set back color
            this.BackColor = Color.FromArgb(5, 5, 5);





            //_launchProcess = Process.Start("C:\\Program Files\\ETC\\EosFamily\\v3\\ETC_Launch\\ETC_LaunchOffline.exe");
            //Thread.Sleep(2000); // Allow the process to open it's window
            //p.WaitForInputIdle();

            //var _launchWindow = _launchProcess.MainWindowHandle;
            //SetParent(_launchWindow, this.Handle);

            //// Remove border and whatnot
            //SetWindowLong(_launchWindow, GWL_STYLE, WS_VISIBLE);
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
            // testing embedding app
            this._applicationControl = new ApplicationControl();
            this.SuspendLayout();
            // 
            // applicationControl1
            // 
            this._applicationControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this._applicationControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._applicationControl.ExeName = "C:\\Program Files\\ETC\\EosFamily\\v3\\ETC_Launch\\ETC_LaunchOffline.exe";
            this._applicationControl.Location = new System.Drawing.Point(24, 24);
            this._applicationControl.Name = "applicationControl1";
            this._applicationControl.Size = new System.Drawing.Size(1550, 650);
            this._applicationControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1600, 700);
            this.Controls.Add(this._applicationControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _formState.Maximize(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _formState.Restore(this);
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

    }
}