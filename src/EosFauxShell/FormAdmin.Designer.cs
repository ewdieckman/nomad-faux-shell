namespace EosFauxShell
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBackToEos = new NomadButton();
            buttonSetPassword = new NomadButton();
            buttonExit = new NomadButton();
            SuspendLayout();
            // 
            // buttonBackToEos
            // 
            buttonBackToEos.BackColor = Color.FromArgb(15, 25, 35);
            buttonBackToEos.FlatStyle = FlatStyle.Flat;
            buttonBackToEos.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackToEos.ForeColor = Color.FromArgb(255, 255, 255);
            buttonBackToEos.Location = new Point(41, 35);
            buttonBackToEos.Name = "buttonBackToEos";
            buttonBackToEos.Size = new Size(103, 38);
            buttonBackToEos.TabIndex = 0;
            buttonBackToEos.Text = "Back to EOS";
            buttonBackToEos.UseVisualStyleBackColor = true;
            buttonBackToEos.Click += buttonBackToEos_Click;
            // 
            // buttonSetPassword
            // 
            buttonSetPassword.BackColor = Color.FromArgb(15, 25, 35);
            buttonSetPassword.FlatStyle = FlatStyle.Flat;
            buttonSetPassword.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSetPassword.ForeColor = Color.FromArgb(255, 255, 255);
            buttonSetPassword.Location = new Point(179, 35);
            buttonSetPassword.Name = "buttonSetPassword";
            buttonSetPassword.Size = new Size(103, 38);
            buttonSetPassword.TabIndex = 1;
            buttonSetPassword.Text = "SetPassword";
            buttonSetPassword.UseVisualStyleBackColor = true;
            buttonSetPassword.Click += buttonSetPassword_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(15, 25, 35);
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.FromArgb(255, 255, 255);
            buttonExit.Location = new Point(109, 102);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(103, 38);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Exit to Windows";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // FormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 167);
            ControlBox = false;
            Controls.Add(buttonExit);
            Controls.Add(buttonSetPassword);
            Controls.Add(buttonBackToEos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdmin";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Functions";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private NomadButton buttonBackToEos;
        private NomadButton buttonSetPassword;
        private NomadButton buttonExit;
    }
}