namespace EosFauxShell
{
    partial class FormConfirmShutdown
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
            label1 = new NomadLabel();
            buttonConfirm = new NomadButton();
            buttonCancel = new NomadButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(174, 174, 174);
            label1.Location = new Point(24, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 13);
            label1.TabIndex = 0;
            label1.Text = "Are you sure you want to shutdown the system?";
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.FromArgb(15, 25, 35);
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonConfirm.ForeColor = Color.FromArgb(255, 255, 255);
            buttonConfirm.Location = new Point(37, 56);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(103, 38);
            buttonConfirm.TabIndex = 1;
            buttonConfirm.Text = "Shutdown";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(15, 25, 35);
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Tahoma", 8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.FromArgb(255, 255, 255);
            buttonCancel.Location = new Point(162, 56);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(103, 38);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormConfirmShutdown
            // 
            AcceptButton = buttonConfirm;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonCancel;
            ClientSize = new Size(294, 115);
            ControlBox = false;
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfirmShutdown";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm Shutdown";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NomadLabel label1;
        private NomadButton buttonConfirm;
        private NomadButton buttonCancel;
    }
}