namespace EosFauxShell
{
    partial class FormEnterPassword
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
            buttonOK = new NomadButton();
            buttonCancel = new NomadButton();
            textBoxPassword = new TextBox();
            label1 = new NomadLabel();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.BackColor = Color.FromArgb(15, 25, 35);
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOK.ForeColor = Color.FromArgb(255, 255, 255);
            buttonOK.Location = new Point(51, 80);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(103, 38);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(15, 25, 35);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.FromArgb(255, 255, 255);
            buttonCancel.Location = new Point(171, 80);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(103, 38);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(93, 32);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(181, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(174, 174, 174);
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(57, 13);
            label1.TabIndex = 3;
            label1.Text = "Password:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // FormEnterPassword
            // 
            AcceptButton = buttonOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(317, 150);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEnterPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enter Admin Password";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NomadButton buttonOK;
        private NomadButton buttonCancel;
        private TextBox textBoxPassword;
        private NomadLabel label1;
    }
}