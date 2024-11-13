using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Application
{
    public partial class Form3 : Form
    {

        private Form _form;

        public Form3(Form form)
        {
            InitializeComponent();

            _form = form;

            HideForm();

            LabelCreatePINError.Visible = false;

            LabelConfirmPINError.Visible = false;

            LabelPINCreated.Visible = false;

            if (_form is Form4)
            {

                ButtonCreatePIN.Text = "Change PIN";

                LabelPINCreated.Text = "PIN Succesfully Changed";

            }
        }

        private async void HideForm()
        {

            await Task.Delay(1);

            _form.Hide();

        }

        private void TextBoxCreatePIN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void TextBoxConfirmPIN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private async void ButtonCreatePIN_Click(object sender, EventArgs e)
        {

            if (TextBoxCreatePIN.Text.Length != TextBoxCreatePIN.MaxLength)
            {

                LabelCreatePINError.Visible = true;

            }
            else if (TextBoxConfirmPIN.Text != TextBoxCreatePIN.Text)
            {

                LabelCreatePINError.Visible = false;

                LabelConfirmPINError.Visible = true;

            }
            else
            {

                ButtonCreatePIN.Enabled = false;

                string enteredPIN = TextBoxCreatePIN.Text;

                using (var connection = new SqliteConnection($"Data Source=cardDatabase.db"))
                {

                    connection.Open();

                    string sql = "UPDATE cardDetails SET cardPIN = @cardPIN WHERE cardNumber = @cardNum";

                    using (var command = new SqliteCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                        command.Parameters.AddWithValue("@cardPIN", enteredPIN);

                        command.ExecuteNonQuery();

                    }

                }

                LabelPINCreated.Visible = true;

                await Task.Delay(1000);

                _form.Show();

                this.Close();

            }
        }
    }
}
