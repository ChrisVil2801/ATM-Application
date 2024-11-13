namespace ATM_Application
{
    partial class Form4
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
            ButtonWithdraw50 = new Button();
            ButtonWithdraw150 = new Button();
            ButtonChangePIN = new Button();
            ButtonWithdrawCustom = new Button();
            ButtonCheckBalance = new Button();
            ButtonPlayLOTTO = new Button();
            LabelSelectOption = new Label();
            LabelInsufficientBalance = new Label();
            SuspendLayout();
            // 
            // ButtonWithdraw50
            // 
            ButtonWithdraw50.BackColor = Color.Transparent;
            ButtonWithdraw50.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonWithdraw50.Location = new Point(169, 169);
            ButtonWithdraw50.Name = "ButtonWithdraw50";
            ButtonWithdraw50.Size = new Size(192, 74);
            ButtonWithdraw50.TabIndex = 3;
            ButtonWithdraw50.Text = "Withdraw R50";
            ButtonWithdraw50.UseVisualStyleBackColor = false;
            ButtonWithdraw50.Click += ButtonWithdraw50_Click;
            // 
            // ButtonWithdraw150
            // 
            ButtonWithdraw150.BackColor = Color.Transparent;
            ButtonWithdraw150.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonWithdraw150.Location = new Point(169, 264);
            ButtonWithdraw150.Name = "ButtonWithdraw150";
            ButtonWithdraw150.Size = new Size(192, 74);
            ButtonWithdraw150.TabIndex = 4;
            ButtonWithdraw150.Text = "Withdraw R150";
            ButtonWithdraw150.UseVisualStyleBackColor = false;
            ButtonWithdraw150.Click += ButtonWithdraw150_Click;
            // 
            // ButtonChangePIN
            // 
            ButtonChangePIN.BackColor = Color.Transparent;
            ButtonChangePIN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonChangePIN.Location = new Point(571, 169);
            ButtonChangePIN.Name = "ButtonChangePIN";
            ButtonChangePIN.Size = new Size(192, 74);
            ButtonChangePIN.TabIndex = 5;
            ButtonChangePIN.Text = "Change PIN";
            ButtonChangePIN.UseVisualStyleBackColor = false;
            ButtonChangePIN.Click += ButtonChangePIN_Click;
            // 
            // ButtonWithdrawCustom
            // 
            ButtonWithdrawCustom.BackColor = Color.Transparent;
            ButtonWithdrawCustom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonWithdrawCustom.Location = new Point(169, 360);
            ButtonWithdrawCustom.Name = "ButtonWithdrawCustom";
            ButtonWithdrawCustom.Size = new Size(192, 74);
            ButtonWithdrawCustom.TabIndex = 6;
            ButtonWithdrawCustom.Text = "Withdraw Custom Amount";
            ButtonWithdrawCustom.UseVisualStyleBackColor = false;
            ButtonWithdrawCustom.Click += ButtonWithdrawCustom_Click;
            // 
            // ButtonCheckBalance
            // 
            ButtonCheckBalance.BackColor = Color.Transparent;
            ButtonCheckBalance.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCheckBalance.Location = new Point(571, 264);
            ButtonCheckBalance.Name = "ButtonCheckBalance";
            ButtonCheckBalance.Size = new Size(192, 74);
            ButtonCheckBalance.TabIndex = 7;
            ButtonCheckBalance.Text = "Check Balance";
            ButtonCheckBalance.UseVisualStyleBackColor = false;
            ButtonCheckBalance.Click += ButtonCheckBalance_Click;
            // 
            // ButtonPlayLOTTO
            // 
            ButtonPlayLOTTO.BackColor = Color.Transparent;
            ButtonPlayLOTTO.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonPlayLOTTO.Location = new Point(571, 360);
            ButtonPlayLOTTO.Name = "ButtonPlayLOTTO";
            ButtonPlayLOTTO.Size = new Size(192, 74);
            ButtonPlayLOTTO.TabIndex = 8;
            ButtonPlayLOTTO.Text = "Play LOTTO";
            ButtonPlayLOTTO.UseVisualStyleBackColor = false;
            ButtonPlayLOTTO.Click += ButtonPlayLOTTO_Click;
            // 
            // LabelSelectOption
            // 
            LabelSelectOption.AutoSize = true;
            LabelSelectOption.BackColor = Color.Transparent;
            LabelSelectOption.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelSelectOption.ForeColor = Color.White;
            LabelSelectOption.Location = new Point(366, 72);
            LabelSelectOption.Name = "LabelSelectOption";
            LabelSelectOption.Size = new Size(206, 28);
            LabelSelectOption.TabIndex = 9;
            LabelSelectOption.Text = "Please Select Option";
            LabelSelectOption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelInsufficientBalance
            // 
            LabelInsufficientBalance.AutoSize = true;
            LabelInsufficientBalance.BackColor = Color.Transparent;
            LabelInsufficientBalance.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelInsufficientBalance.ForeColor = Color.Tomato;
            LabelInsufficientBalance.Location = new Point(311, 123);
            LabelInsufficientBalance.Name = "LabelInsufficientBalance";
            LabelInsufficientBalance.Size = new Size(324, 17);
            LabelInsufficientBalance.TabIndex = 10;
            LabelInsufficientBalance.Text = "Insufficient Balance. Please Select Another Option\r\n";
            LabelInsufficientBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ATM_Background_Image;
            ClientSize = new Size(919, 517);
            Controls.Add(LabelInsufficientBalance);
            Controls.Add(LabelSelectOption);
            Controls.Add(ButtonPlayLOTTO);
            Controls.Add(ButtonCheckBalance);
            Controls.Add(ButtonWithdrawCustom);
            Controls.Add(ButtonChangePIN);
            Controls.Add(ButtonWithdraw150);
            Controls.Add(ButtonWithdraw50);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonWithdraw50;
        private Button ButtonWithdraw150;
        private Button ButtonChangePIN;
        private Button ButtonWithdrawCustom;
        private Button ButtonCheckBalance;
        private Button ButtonPlayLOTTO;
        private Label LabelSelectOption;
        private Label LabelInsufficientBalance;
    }
}