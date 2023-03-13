namespace EosFauxShell
{
    partial class FormSetPassword
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
            buttonSet = new NomadButton();
            buttonCancel = new NomadButton();
            textBoxPassword = new TextBox();
            labelInstructions = new NomadLabel();
            textBoxVerify = new TextBox();
            labelPassword = new NomadLabel();
            labelVerify = new NomadLabel();
            labelFeedback = new NomadLabel();
            SuspendLayout();
            // 
            // buttonSet
            // 
            buttonSet.BackColor = Color.FromArgb(15, 25, 35);
            buttonSet.FlatStyle = FlatStyle.Flat;
            buttonSet.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSet.ForeColor = Color.FromArgb(255, 255, 255);
            buttonSet.Location = new Point(52, 189);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(103, 38);
            buttonSet.TabIndex = 0;
            buttonSet.Text = "Set Password";
            buttonSet.UseVisualStyleBackColor = true;
            buttonSet.Click += buttonSet_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(15, 25, 35);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.FromArgb(255, 255, 255);
            buttonCancel.Location = new Point(172, 189);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(103, 38);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(98, 60);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(177, 23);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelInstructions
            // 
            labelInstructions.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelInstructions.ForeColor = Color.FromArgb(174, 174, 174);
            labelInstructions.Location = new Point(37, 14);
            labelInstructions.Name = "labelInstructions";
            labelInstructions.Size = new Size(262, 35);
            labelInstructions.TabIndex = 3;
            labelInstructions.Text = "Set a password to exit the ETCnomad Faux Shell and access the rest of Windows.\r\n";
            // 
            // textBoxVerify
            // 
            textBoxVerify.Location = new Point(98, 101);
            textBoxVerify.Name = "textBoxVerify";
            textBoxVerify.Size = new Size(177, 23);
            textBoxVerify.TabIndex = 4;
            textBoxVerify.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.FromArgb(174, 174, 174);
            labelPassword.Location = new Point(35, 64);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 13);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.TopRight;
            // 
            // labelVerify
            // 
            labelVerify.AutoSize = true;
            labelVerify.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelVerify.ForeColor = Color.FromArgb(174, 174, 174);
            labelVerify.Location = new Point(52, 105);
            labelVerify.Name = "labelVerify";
            labelVerify.Size = new Size(39, 13);
            labelVerify.TabIndex = 6;
            labelVerify.Text = "Verify:";
            labelVerify.TextAlign = ContentAlignment.TopRight;
            // 
            // labelFeedback
            // 
            labelFeedback.Font = new Font("Tahoma", 8F, FontStyle.Bold, GraphicsUnit.Point);
            labelFeedback.ForeColor = Color.Red;
            labelFeedback.Location = new Point(38, 141);
            labelFeedback.Name = "labelFeedback";
            labelFeedback.Size = new Size(276, 28);
            labelFeedback.TabIndex = 7;
            labelFeedback.Text = "Passwords entered do not match.";
            labelFeedback.Visible = false;
            // 
            // FormSetPassword
            // 
            AcceptButton = buttonSet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 250);
            ControlBox = false;
            Controls.Add(labelFeedback);
            Controls.Add(labelVerify);
            Controls.Add(labelPassword);
            Controls.Add(textBoxVerify);
            Controls.Add(labelInstructions);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSet);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormSetPassword";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Password";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NomadButton buttonSet;
        private NomadButton buttonCancel;
        private TextBox textBoxPassword;
        private NomadLabel labelInstructions;
        private TextBox textBoxVerify;
        private NomadLabel labelPassword;
        private NomadLabel labelVerify;
        private NomadLabel labelFeedback;
    }
}