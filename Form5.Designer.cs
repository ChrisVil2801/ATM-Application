namespace ATM_Application
{
    partial class Form5
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
            LabelWithdrawAmount = new Label();
            TextBoxCustomAmount = new TextBox();
            ButtonReturn = new Button();
            ButtonWithdrawCustom = new Button();
            ButtonSubmitLOTTO = new Button();
            NumberBox1 = new NumericUpDown();
            NumberBox2 = new NumericUpDown();
            NumberBox3 = new NumericUpDown();
            NumberBox4 = new NumericUpDown();
            NumberBox5 = new NumericUpDown();
            NumberBox6 = new NumericUpDown();
            LabelWrongLOTTO = new Label();
            PictureArrow = new PictureBox();
            LabelMaxWithdraw = new Label();
            LabelWinningsLOTTO = new Label();
            ((System.ComponentModel.ISupportInitialize)NumberBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureArrow).BeginInit();
            SuspendLayout();
            // 
            // LabelWithdrawAmount
            // 
            LabelWithdrawAmount.AutoSize = true;
            LabelWithdrawAmount.BackColor = Color.Transparent;
            LabelWithdrawAmount.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWithdrawAmount.ForeColor = Color.White;
            LabelWithdrawAmount.Location = new Point(212, 143);
            LabelWithdrawAmount.Name = "LabelWithdrawAmount";
            LabelWithdrawAmount.Size = new Size(480, 56);
            LabelWithdrawAmount.TabIndex = 10;
            LabelWithdrawAmount.Text = "Withdrawing Amount. Please Take Cash And Card\r\nHave A Nice Day!";
            LabelWithdrawAmount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBoxCustomAmount
            // 
            TextBoxCustomAmount.Location = new Point(402, 211);
            TextBoxCustomAmount.MaxLength = 4;
            TextBoxCustomAmount.Name = "TextBoxCustomAmount";
            TextBoxCustomAmount.Size = new Size(100, 23);
            TextBoxCustomAmount.TabIndex = 11;
            TextBoxCustomAmount.TextAlign = HorizontalAlignment.Center;
            TextBoxCustomAmount.Visible = false;
            TextBoxCustomAmount.KeyPress += TextBoxCustomAmount_KeyPress;
            // 
            // ButtonReturn
            // 
            ButtonReturn.BackColor = Color.Transparent;
            ButtonReturn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonReturn.Location = new Point(392, 427);
            ButtonReturn.Name = "ButtonReturn";
            ButtonReturn.Size = new Size(121, 43);
            ButtonReturn.TabIndex = 12;
            ButtonReturn.Text = "Return";
            ButtonReturn.UseVisualStyleBackColor = false;
            ButtonReturn.Visible = false;
            ButtonReturn.Click += ButtonReturn_Click;
            // 
            // ButtonWithdrawCustom
            // 
            ButtonWithdrawCustom.BackColor = Color.Transparent;
            ButtonWithdrawCustom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonWithdrawCustom.Location = new Point(357, 329);
            ButtonWithdrawCustom.Name = "ButtonWithdrawCustom";
            ButtonWithdrawCustom.Size = new Size(192, 43);
            ButtonWithdrawCustom.TabIndex = 13;
            ButtonWithdrawCustom.Text = "Withdraw Custom Amount";
            ButtonWithdrawCustom.UseVisualStyleBackColor = false;
            ButtonWithdrawCustom.Visible = false;
            ButtonWithdrawCustom.Click += ButtonWithdrawCustom_Click;
            // 
            // ButtonSubmitLOTTO
            // 
            ButtonSubmitLOTTO.BackColor = Color.Transparent;
            ButtonSubmitLOTTO.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSubmitLOTTO.Location = new Point(357, 378);
            ButtonSubmitLOTTO.Name = "ButtonSubmitLOTTO";
            ButtonSubmitLOTTO.Size = new Size(190, 43);
            ButtonSubmitLOTTO.TabIndex = 14;
            ButtonSubmitLOTTO.Text = "Submit LOTTO Numbers";
            ButtonSubmitLOTTO.UseVisualStyleBackColor = false;
            ButtonSubmitLOTTO.Visible = false;
            ButtonSubmitLOTTO.Click += ButtonSubmitLOTTO_Click;
            // 
            // NumberBox1
            // 
            NumberBox1.Location = new Point(253, 270);
            NumberBox1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberBox1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox1.Name = "NumberBox1";
            NumberBox1.Size = new Size(38, 23);
            NumberBox1.TabIndex = 15;
            NumberBox1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox1.Visible = false;
            // 
            // NumberBox2
            // 
            NumberBox2.Location = new Point(324, 270);
            NumberBox2.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberBox2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox2.Name = "NumberBox2";
            NumberBox2.Size = new Size(38, 23);
            NumberBox2.TabIndex = 16;
            NumberBox2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox2.Visible = false;
            // 
            // NumberBox3
            // 
            NumberBox3.Location = new Point(392, 270);
            NumberBox3.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberBox3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox3.Name = "NumberBox3";
            NumberBox3.Size = new Size(38, 23);
            NumberBox3.TabIndex = 17;
            NumberBox3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox3.Visible = false;
            // 
            // NumberBox4
            // 
            NumberBox4.Location = new Point(475, 270);
            NumberBox4.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberBox4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox4.Name = "NumberBox4";
            NumberBox4.Size = new Size(38, 23);
            NumberBox4.TabIndex = 18;
            NumberBox4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox4.Visible = false;
            // 
            // NumberBox5
            // 
            NumberBox5.Location = new Point(544, 270);
            NumberBox5.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberBox5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox5.Name = "NumberBox5";
            NumberBox5.Size = new Size(38, 23);
            NumberBox5.TabIndex = 19;
            NumberBox5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox5.Visible = false;
            // 
            // NumberBox6
            // 
            NumberBox6.Location = new Point(610, 270);
            NumberBox6.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            NumberBox6.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox6.Name = "NumberBox6";
            NumberBox6.Size = new Size(38, 23);
            NumberBox6.TabIndex = 20;
            NumberBox6.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumberBox6.Visible = false;
            // 
            // LabelWrongLOTTO
            // 
            LabelWrongLOTTO.AutoSize = true;
            LabelWrongLOTTO.BackColor = Color.Transparent;
            LabelWrongLOTTO.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWrongLOTTO.ForeColor = Color.Tomato;
            LabelWrongLOTTO.Location = new Point(282, 309);
            LabelWrongLOTTO.Name = "LabelWrongLOTTO";
            LabelWrongLOTTO.Size = new Size(366, 17);
            LabelWrongLOTTO.TabIndex = 21;
            LabelWrongLOTTO.Text = "All LOTTO Numbers Must Be Unique And Be From 1 - 50";
            LabelWrongLOTTO.TextAlign = ContentAlignment.MiddleCenter;
            LabelWrongLOTTO.Visible = false;
            // 
            // PictureArrow
            // 
            PictureArrow.BackColor = Color.Transparent;
            PictureArrow.Image = Properties.Resources.White_Down_Arrow;
            PictureArrow.Location = new Point(430, 476);
            PictureArrow.Name = "PictureArrow";
            PictureArrow.Size = new Size(42, 39);
            PictureArrow.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureArrow.TabIndex = 22;
            PictureArrow.TabStop = false;
            // 
            // LabelMaxWithdraw
            // 
            LabelMaxWithdraw.AutoSize = true;
            LabelMaxWithdraw.BackColor = Color.Transparent;
            LabelMaxWithdraw.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelMaxWithdraw.ForeColor = Color.Tomato;
            LabelMaxWithdraw.Location = new Point(348, 250);
            LabelMaxWithdraw.Name = "LabelMaxWithdraw";
            LabelMaxWithdraw.Size = new Size(210, 17);
            LabelMaxWithdraw.TabIndex = 23;
            LabelMaxWithdraw.Text = "Max Withdrawal Limit Is R5000";
            LabelMaxWithdraw.TextAlign = ContentAlignment.MiddleCenter;
            LabelMaxWithdraw.Visible = false;
            // 
            // LabelWinningsLOTTO
            // 
            LabelWinningsLOTTO.AutoSize = true;
            LabelWinningsLOTTO.BackColor = Color.Transparent;
            LabelWinningsLOTTO.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelWinningsLOTTO.ForeColor = Color.White;
            LabelWinningsLOTTO.Location = new Point(357, 18);
            LabelWinningsLOTTO.Name = "LabelWinningsLOTTO";
            LabelWinningsLOTTO.Size = new Size(207, 84);
            LabelWinningsLOTTO.TabIndex = 24;
            LabelWinningsLOTTO.Text = "LOTTO Numbers:\r\nSubmitted Numbers:\r\nWinnings: R";
            LabelWinningsLOTTO.TextAlign = ContentAlignment.MiddleCenter;
            LabelWinningsLOTTO.Visible = false;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ATM_Background_Image;
            ClientSize = new Size(919, 517);
            Controls.Add(LabelWinningsLOTTO);
            Controls.Add(LabelMaxWithdraw);
            Controls.Add(PictureArrow);
            Controls.Add(LabelWrongLOTTO);
            Controls.Add(NumberBox6);
            Controls.Add(NumberBox5);
            Controls.Add(NumberBox4);
            Controls.Add(NumberBox3);
            Controls.Add(NumberBox2);
            Controls.Add(NumberBox1);
            Controls.Add(ButtonSubmitLOTTO);
            Controls.Add(ButtonWithdrawCustom);
            Controls.Add(ButtonReturn);
            Controls.Add(TextBoxCustomAmount);
            Controls.Add(LabelWithdrawAmount);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)NumberBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureArrow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelWithdrawAmount;
        private TextBox TextBoxCustomAmount;
        private Button ButtonReturn;
        private Button ButtonWithdrawCustom;
        private Button ButtonSubmitLOTTO;
        private NumericUpDown NumberBox1;
        private NumericUpDown NumberBox2;
        private NumericUpDown NumberBox3;
        private NumericUpDown NumberBox4;
        private NumericUpDown NumberBox5;
        private NumericUpDown NumberBox6;
        private Label LabelWrongLOTTO;
        private PictureBox PictureArrow;
        private Label LabelMaxWithdraw;
        private Label LabelWinningsLOTTO;
    }
}