namespace ATM_Application
{
    partial class Form3
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
            LabelCreatePIN = new Label();
            LabelConfirmPIN = new Label();
            TextBoxCreatePIN = new TextBox();
            TextBoxConfirmPIN = new TextBox();
            ButtonCreatePIN = new Button();
            LabelCreatePINError = new Label();
            LabelConfirmPINError = new Label();
            LabelPINCreated = new Label();
            SuspendLayout();
            // 
            // LabelCreatePIN
            // 
            LabelCreatePIN.AutoSize = true;
            LabelCreatePIN.BackColor = Color.Transparent;
            LabelCreatePIN.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCreatePIN.ForeColor = Color.White;
            LabelCreatePIN.Location = new Point(390, 78);
            LabelCreatePIN.Name = "LabelCreatePIN";
            LabelCreatePIN.Size = new Size(162, 28);
            LabelCreatePIN.TabIndex = 3;
            LabelCreatePIN.Text = "Create New PIN";
            LabelCreatePIN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelConfirmPIN
            // 
            LabelConfirmPIN.AutoSize = true;
            LabelConfirmPIN.BackColor = Color.Transparent;
            LabelConfirmPIN.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelConfirmPIN.ForeColor = Color.White;
            LabelConfirmPIN.Location = new Point(405, 222);
            LabelConfirmPIN.Name = "LabelConfirmPIN";
            LabelConfirmPIN.Size = new Size(128, 28);
            LabelConfirmPIN.TabIndex = 4;
            LabelConfirmPIN.Text = "Confirm PIN";
            LabelConfirmPIN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxCreatePIN
            // 
            TextBoxCreatePIN.Location = new Point(417, 137);
            TextBoxCreatePIN.MaxLength = 4;
            TextBoxCreatePIN.Name = "TextBoxCreatePIN";
            TextBoxCreatePIN.PasswordChar = '*';
            TextBoxCreatePIN.Size = new Size(100, 23);
            TextBoxCreatePIN.TabIndex = 5;
            TextBoxCreatePIN.TextAlign = HorizontalAlignment.Center;
            TextBoxCreatePIN.KeyPress += TextBoxCreatePIN_KeyPress;
            // 
            // TextBoxConfirmPIN
            // 
            TextBoxConfirmPIN.Location = new Point(417, 281);
            TextBoxConfirmPIN.MaxLength = 4;
            TextBoxConfirmPIN.Name = "TextBoxConfirmPIN";
            TextBoxConfirmPIN.PasswordChar = '*';
            TextBoxConfirmPIN.Size = new Size(100, 23);
            TextBoxConfirmPIN.TabIndex = 6;
            TextBoxConfirmPIN.TextAlign = HorizontalAlignment.Center;
            TextBoxConfirmPIN.KeyPress += TextBoxConfirmPIN_KeyPress;
            // 
            // ButtonCreatePIN
            // 
            ButtonCreatePIN.BackColor = Color.Transparent;
            ButtonCreatePIN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCreatePIN.Location = new Point(408, 368);
            ButtonCreatePIN.Name = "ButtonCreatePIN";
            ButtonCreatePIN.Size = new Size(121, 43);
            ButtonCreatePIN.TabIndex = 7;
            ButtonCreatePIN.Text = "Create PIN";
            ButtonCreatePIN.UseVisualStyleBackColor = false;
            ButtonCreatePIN.Click += ButtonCreatePIN_Click;
            // 
            // LabelCreatePINError
            // 
            LabelCreatePINError.AutoSize = true;
            LabelCreatePINError.BackColor = Color.Transparent;
            LabelCreatePINError.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCreatePINError.ForeColor = Color.Tomato;
            LabelCreatePINError.Location = new Point(400, 181);
            LabelCreatePINError.Name = "LabelCreatePINError";
            LabelCreatePINError.Size = new Size(142, 17);
            LabelCreatePINError.TabIndex = 8;
            LabelCreatePINError.Text = "PIN Must Be 4 Digits";
            LabelCreatePINError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelConfirmPINError
            // 
            LabelConfirmPINError.AutoSize = true;
            LabelConfirmPINError.BackColor = Color.Transparent;
            LabelConfirmPINError.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelConfirmPINError.ForeColor = Color.Tomato;
            LabelConfirmPINError.Location = new Point(367, 327);
            LabelConfirmPINError.Name = "LabelConfirmPINError";
            LabelConfirmPINError.Size = new Size(227, 17);
            LabelConfirmPINError.TabIndex = 9;
            LabelConfirmPINError.Text = "PIN Must Be Same As Created PIN";
            LabelConfirmPINError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelPINCreated
            // 
            LabelPINCreated.AutoSize = true;
            LabelPINCreated.BackColor = Color.Transparent;
            LabelPINCreated.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelPINCreated.ForeColor = Color.White;
            LabelPINCreated.Location = new Point(376, 431);
            LabelPINCreated.Name = "LabelPINCreated";
            LabelPINCreated.Size = new Size(198, 21);
            LabelPINCreated.TabIndex = 10;
            LabelPINCreated.Text = "PIN Successfully Created";
            LabelPINCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ATM_Background_Image;
            ClientSize = new Size(919, 517);
            Controls.Add(LabelPINCreated);
            Controls.Add(LabelConfirmPINError);
            Controls.Add(LabelCreatePINError);
            Controls.Add(ButtonCreatePIN);
            Controls.Add(TextBoxConfirmPIN);
            Controls.Add(TextBoxCreatePIN);
            Controls.Add(LabelConfirmPIN);
            Controls.Add(LabelCreatePIN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCreatePIN;
        private Label LabelConfirmPIN;
        private TextBox TextBoxCreatePIN;
        private TextBox TextBoxConfirmPIN;
        private Button ButtonCreatePIN;
        private Label LabelCreatePINError;
        private Label LabelConfirmPINError;
        private Label LabelPINCreated;
    }
}