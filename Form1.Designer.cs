namespace ATM_Application
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelATM = new Label();
            LabelInsertCard = new Label();
            ButtonInsertCard = new Button();
            LabelCardCheck = new Label();
            GifCardCheck = new PictureBox();
            dataGridView1 = new DataGridView();
            ComboBoxCards = new ComboBox();
            LabelChooseCard = new Label();
            ((System.ComponentModel.ISupportInitialize)GifCardCheck).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // LabelATM
            // 
            LabelATM.AutoSize = true;
            LabelATM.BackColor = Color.Transparent;
            LabelATM.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelATM.ForeColor = Color.White;
            LabelATM.Location = new Point(380, 42);
            LabelATM.Name = "LabelATM";
            LabelATM.Size = new Size(146, 37);
            LabelATM.TabIndex = 0;
            LabelATM.Text = "Bank ATM";
            LabelATM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelInsertCard
            // 
            LabelInsertCard.AutoSize = true;
            LabelInsertCard.BackColor = Color.Transparent;
            LabelInsertCard.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelInsertCard.ForeColor = Color.White;
            LabelInsertCard.Location = new Point(364, 126);
            LabelInsertCard.Name = "LabelInsertCard";
            LabelInsertCard.Size = new Size(182, 28);
            LabelInsertCard.TabIndex = 1;
            LabelInsertCard.Text = "Please Insert Card";
            LabelInsertCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ButtonInsertCard
            // 
            ButtonInsertCard.BackColor = Color.Transparent;
            ButtonInsertCard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonInsertCard.Location = new Point(390, 189);
            ButtonInsertCard.Name = "ButtonInsertCard";
            ButtonInsertCard.Size = new Size(121, 43);
            ButtonInsertCard.TabIndex = 2;
            ButtonInsertCard.Text = "Insert Card";
            ButtonInsertCard.UseVisualStyleBackColor = false;
            ButtonInsertCard.Click += ButtonInsertCard_Click;
            // 
            // LabelCardCheck
            // 
            LabelCardCheck.AutoSize = true;
            LabelCardCheck.BackColor = Color.Transparent;
            LabelCardCheck.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCardCheck.ForeColor = Color.White;
            LabelCardCheck.Location = new Point(380, 347);
            LabelCardCheck.Name = "LabelCardCheck";
            LabelCardCheck.Size = new Size(141, 25);
            LabelCardCheck.TabIndex = 3;
            LabelCardCheck.Text = "Checking Card";
            LabelCardCheck.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GifCardCheck
            // 
            GifCardCheck.BackColor = Color.Transparent;
            GifCardCheck.Image = Properties.Resources.LoadingGIF;
            GifCardCheck.Location = new Point(399, 402);
            GifCardCheck.Name = "GifCardCheck";
            GifCardCheck.Size = new Size(100, 50);
            GifCardCheck.SizeMode = PictureBoxSizeMode.StretchImage;
            GifCardCheck.TabIndex = 4;
            GifCardCheck.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(624, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 5;
            dataGridView1.Visible = false;
            // 
            // ComboBoxCards
            // 
            ComboBoxCards.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxCards.FormattingEnabled = true;
            ComboBoxCards.Location = new Point(336, 269);
            ComboBoxCards.Name = "ComboBoxCards";
            ComboBoxCards.Size = new Size(236, 23);
            ComboBoxCards.TabIndex = 6;
            // 
            // LabelChooseCard
            // 
            LabelChooseCard.AutoSize = true;
            LabelChooseCard.BackColor = Color.Transparent;
            LabelChooseCard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelChooseCard.ForeColor = Color.White;
            LabelChooseCard.Location = new Point(356, 305);
            LabelChooseCard.Name = "LabelChooseCard";
            LabelChooseCard.Size = new Size(190, 17);
            LabelChooseCard.TabIndex = 7;
            LabelChooseCard.Text = "Choose Card Already Inserted";
            LabelChooseCard.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.ATM_Background_Image;
            ClientSize = new Size(919, 517);
            Controls.Add(LabelChooseCard);
            Controls.Add(ComboBoxCards);
            Controls.Add(dataGridView1);
            Controls.Add(GifCardCheck);
            Controls.Add(LabelCardCheck);
            Controls.Add(ButtonInsertCard);
            Controls.Add(LabelInsertCard);
            Controls.Add(LabelATM);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GifCardCheck).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelATM;
        private Label LabelInsertCard;
        private Button ButtonInsertCard;
        private Label LabelCardCheck;
        private PictureBox GifCardCheck;
        private DataGridView dataGridView1;
        private ComboBox ComboBoxCards;
        private Label LabelChooseCard;
    }
}
