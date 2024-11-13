namespace ATM_Application
{
    partial class Form2
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
            LabelEnterPIN = new Label();
            TextBoxEnterPIN = new TextBox();
            LabelCreatePIN = new Label();
            LabelEnterPINError = new Label();
            LabelAlreadyExistingPIN = new Label();
            SuspendLayout();
            // 
            // LabelEnterPIN
            // 
            LabelEnterPIN.AutoSize = true;
            LabelEnterPIN.BackColor = Color.Transparent;
            LabelEnterPIN.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEnterPIN.ForeColor = Color.White;
            LabelEnterPIN.Location = new Point(409, 151);
            LabelEnterPIN.Name = "LabelEnterPIN";
            LabelEnterPIN.Size = new Size(102, 28);
            LabelEnterPIN.TabIndex = 2;
            LabelEnterPIN.Text = "Enter PIN";
            LabelEnterPIN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxEnterPIN
            // 
            TextBoxEnterPIN.Location = new Point(409, 222);
            TextBoxEnterPIN.MaxLength = 4;
            TextBoxEnterPIN.Name = "TextBoxEnterPIN";
            TextBoxEnterPIN.PasswordChar = '*';
            TextBoxEnterPIN.Size = new Size(100, 23);
            TextBoxEnterPIN.TabIndex = 3;
            TextBoxEnterPIN.TextAlign = HorizontalAlignment.Center;
            TextBoxEnterPIN.TextChanged += TextBoxEnterPIN_TextChanged;
            TextBoxEnterPIN.KeyPress += TextBoxEnterPIN_KeyPress;
            // 
            // LabelCreatePIN
            // 
            LabelCreatePIN.AutoSize = true;
            LabelCreatePIN.BackColor = Color.Transparent;
            LabelCreatePIN.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            LabelCreatePIN.ForeColor = Color.White;
            LabelCreatePIN.Location = new Point(365, 374);
            LabelCreatePIN.Name = "LabelCreatePIN";
            LabelCreatePIN.Size = new Size(200, 20);
            LabelCreatePIN.TabIndex = 4;
            LabelCreatePIN.Text = "New Card? Create PIN Here";
            LabelCreatePIN.TextAlign = ContentAlignment.MiddleCenter;
            LabelCreatePIN.Click += LabelCreatePIN_Click;
            // 
            // LabelEnterPINError
            // 
            LabelEnterPINError.Anchor = AnchorStyles.None;
            LabelEnterPINError.AutoSize = true;
            LabelEnterPINError.BackColor = Color.Transparent;
            LabelEnterPINError.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEnterPINError.ForeColor = Color.Tomato;
            LabelEnterPINError.Location = new Point(360, 271);
            LabelEnterPINError.Name = "LabelEnterPINError";
            LabelEnterPINError.Size = new Size(217, 17);
            LabelEnterPINError.TabIndex = 10;
            LabelEnterPINError.Text = "Incorrect PIN. X Tries Remaining";
            LabelEnterPINError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelAlreadyExistingPIN
            // 
            LabelAlreadyExistingPIN.Anchor = AnchorStyles.None;
            LabelAlreadyExistingPIN.AutoSize = true;
            LabelAlreadyExistingPIN.BackColor = Color.Transparent;
            LabelAlreadyExistingPIN.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelAlreadyExistingPIN.ForeColor = Color.Tomato;
            LabelAlreadyExistingPIN.Location = new Point(283, 410);
            LabelAlreadyExistingPIN.Name = "LabelAlreadyExistingPIN";
            LabelAlreadyExistingPIN.Size = new Size(368, 17);
            LabelAlreadyExistingPIN.TabIndex = 11;
            LabelAlreadyExistingPIN.Text = "Card PIN Already Exists. Please Use Already Created PIN";
            LabelAlreadyExistingPIN.TextAlign = ContentAlignment.MiddleCenter;
            LabelAlreadyExistingPIN.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ATM_Background_Image;
            ClientSize = new Size(919, 518);
            Controls.Add(LabelAlreadyExistingPIN);
            Controls.Add(LabelEnterPINError);
            Controls.Add(LabelCreatePIN);
            Controls.Add(TextBoxEnterPIN);
            Controls.Add(LabelEnterPIN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelEnterPIN;
        private TextBox TextBoxEnterPIN;
        private Label LabelCreatePIN;
        private Label LabelEnterPINError;
        private Label LabelAlreadyExistingPIN;
    }
}