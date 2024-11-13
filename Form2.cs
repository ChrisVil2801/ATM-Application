using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM_Application
{
    public partial class Form2 : Form
    {

        private Form1 _form1;

        int pinTries = 4;

        bool cardBlocked = false;

        public Form2(Form1 form1)
        {
            InitializeComponent();

            _form1 = form1;

            HideForm();

            LabelEnterPINError.Visible = false;
        }

        private async void HideForm()
        {
            await Task.Delay(1);

            _form1.Hide();
        }

        private void TextBoxEnterPIN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void TextBoxEnterPIN_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxEnterPIN.Text.Length == TextBoxEnterPIN.MaxLength && cardBlocked == false)
            {

                pinTries = pinTries - 1;

                string enteredPIN = TextBoxEnterPIN.Text;

                using (var connection = new SqliteConnection($"Data Source=cardDatabase.db"))
                {

                    connection.Open();

                    string sql = "SELECT 1 FROM cardDetails WHERE cardNumber = @cardNum AND cardPIN = @cardPIN LIMIT 1";

                    using (var command = new SqliteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                        command.Parameters.AddWithValue("@cardPIN", enteredPIN);

                        var result = command.ExecuteScalar();

                        if (result != null)
                        {

                            Form4 form4 = new Form4(this);

                            form4.ShowDialog();

                            this.Close();

                        }

                        else
                        {

                            if (pinTries > 0)
                            {

                                LabelEnterPINError.Text = "Incorrect PIN. " + pinTries + " Tries Remaining.";

                                LabelEnterPINError.Visible = true;

                            }
                            else
                            {

                                LabelEnterPINError.Text = "Incorrect PIN Entered Too Many Times.\nCard Use Now Unavailable.";

                                LabelEnterPINError.Left = (this.ClientSize.Width - LabelEnterPINError.Width) / 2;

                                LabelCreatePIN.Enabled = false;

                                cardBlocked = true;

                            }

                        }

                    }

                }

            }
        }

        private void LabelCreatePIN_Click(object sender, EventArgs e)
        {

            using (var connection = new SqliteConnection($"Data Source=cardDatabase.db;"))
            {

                connection.Open();

                string sql = "SELECT cardPIN FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var cardPIN = command.ExecuteScalar();

                    if (cardPIN == DBNull.Value)
                    {

                        Form3 form3 = new Form3(this);

                        form3.ShowDialog();

                    }
                    else if (cardPIN != DBNull.Value)
                    {

                        LabelAlreadyExistingPIN.Visible = true;

                    }
                }
            }
        }
    }
}
