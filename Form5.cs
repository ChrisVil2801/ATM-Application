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
    public partial class Form5 : Form
    {

        private Form4 _form4;

        public Form5(Form4 form4)
        {
            InitializeComponent();

            _form4 = form4;

            HideForm();

            if (Form4.OptionSelector.option == "custom")
            {

                WithdrawCustom();

            }
            else if (Form4.OptionSelector.option == "balance")
            {

                CheckBalance();

            }
            else if (Form4.OptionSelector.option == "lotto")
            {

                PlayLOTTO();

            }

        }

        private async void HideForm()
        {

            await Task.Delay(1);

            _form4.Hide();

        }

        private void WithdrawCustom()
        {

            PictureArrow.Visible = false;

            TextBoxCustomAmount.Visible = true;

            ButtonWithdrawCustom.Visible = true;

            LabelWithdrawAmount.Text = "Please Enter Amount To Withdraw";

            LabelWithdrawAmount.Left = (this.ClientSize.Width - LabelWithdrawAmount.Width) / 2;

        }

        private void TextBoxCustomAmount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void CheckBalance()
        {

            PictureArrow.Visible = false;

            ButtonReturn.Visible = true;

            using (var connection = new SqliteConnection("Data Source = cardDatabase.db;"))
            {

                connection.Open();

                string getBal = "SELECT balance FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand(getBal, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var balance = command.ExecuteScalar();

                    LabelWithdrawAmount.Text = $"Current Balance: R {balance}";

                    LabelWithdrawAmount.Left = (this.ClientSize.Width - LabelWithdrawAmount.Width) / 2;

                }
            }
        }

        private void PlayLOTTO()
        {

            PictureArrow.Visible = false;

            NumberBox1.Visible = true;

            NumberBox2.Visible = true;

            NumberBox3.Visible = true;

            NumberBox4.Visible = true;

            NumberBox5.Visible = true;

            NumberBox6.Visible = true;

            ButtonSubmitLOTTO.Visible = true;

            ButtonReturn.Visible = true;

            LabelWithdrawAmount.Text = "Please Select 6 Unique Numbers From 1 - 50\nLOTTO Charge: R10 Entry";

            LabelWithdrawAmount.Left = (this.ClientSize.Width - LabelWithdrawAmount.Width) / 2;

            if (Form4.OptionSelector.submittedLottoNumbersLabel != null)
            {

                LabelWinningsLOTTO.Visible = true;

                LabelWinningsLOTTO.Text = $"LOTTO Numbers: {Form4.OptionSelector.winningLottoNumbersLabel}\nSubmitted Numbers: {Form4.OptionSelector.submittedLottoNumbersLabel}\nWinnings: R{Form4.OptionSelector.winningsLabel}";

                LabelWinningsLOTTO.Left = (this.ClientSize.Width - LabelWinningsLOTTO.Width) / 2;

            }

        }

        private void ButtonWithdrawCustom_Click(object sender, EventArgs e)
        {

            int withdrawAmount = Convert.ToInt32(TextBoxCustomAmount.Text);

            if (withdrawAmount > 5000)
            {

                LabelMaxWithdraw.Visible = true;

            }
            else
            {

                using (var connection = new SqliteConnection("Data Source = cardDatabase.db;"))
                {

                    connection.Open();

                    string getBal = "SELECT balance FROM cardDetails WHERE cardNumber = @cardNum";

                    using (var command = new SqliteCommand(getBal, connection))
                    {

                        command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                        var balance = command.ExecuteScalar();

                        if (Convert.ToInt32(balance) > withdrawAmount)
                        {

                            int newBalance = Convert.ToInt32(balance) - withdrawAmount;

                            //MessageBox.Show(newBalance.ToString());

                            string updateBal = "UPDATE cardDetails SET balance = @balance WHERE cardNumber = @cardNum";

                            using (var com = new SqliteCommand(updateBal, connection))
                            {

                                com.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                                com.Parameters.AddWithValue("@balance", newBalance);

                                com.ExecuteNonQuery();

                            }

                            TextBoxCustomAmount.Visible = false;

                            ButtonWithdrawCustom.Visible = false;

                            LabelMaxWithdraw.Visible = false;

                            PictureArrow.Visible = true;

                            LabelWithdrawAmount.Text = "Withdrawing Amount. Please Take Cash And Card\nHave A Nice Day!";

                            LabelWithdrawAmount.Left = (this.ClientSize.Width - LabelWithdrawAmount.Width) / 2;

                        }
                        else
                        {

                            LabelMaxWithdraw.Visible = true;

                            LabelMaxWithdraw.Text = "Insufficient Funds. Please Withdraw Lesser Amount";

                        }
                    }
                }
            }
        }

        private void ButtonSubmitLOTTO_Click(object sender, EventArgs e)
        {

            string[] lottoNumbers = { NumberBox1.Text, NumberBox2.Text, NumberBox3.Text, NumberBox4.Text, NumberBox5.Text, NumberBox6.Text };

            //string joinTest = string.Join("", lottoNumbers);

            //MessageBox.Show(joinTest);

            int lottoNumberLength = lottoNumbers.Length;

            for (int numIndex = 0; numIndex < lottoNumberLength; numIndex++)
            {

                string num = lottoNumbers[numIndex];

                //string joinTest2 = string.Join("", num);

                //MessageBox.Show(joinTest2);

                for (int i = 0; i < lottoNumberLength && i != numIndex; i++)
                {

                    if (lottoNumbers[i] == num)
                    {

                        LabelWrongLOTTO.Visible = true;

                        return;

                    }
                }
            }

            LabelWrongLOTTO.Visible = false;

            string submittedLottoNumbers = string.Join(",", lottoNumbers);

            //MessageBox.Show(submittedLottoNumbers);

            using (var connection = new SqliteConnection($"Data Source=cardDatabase.db"))
            {

                connection.Open();

                string getBal = "SELECT balance FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand(getBal, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var balance = command.ExecuteScalar();

                    long newBalance = Convert.ToInt64(balance) - 10;

                    string sql = "UPDATE cardDetails SET lottoNumbers = @lottoNumbers, balance = @balance WHERE cardNumber = @cardNum";

                    using (var com = new SqliteCommand(sql, connection))
                    {
                        com.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                        com.Parameters.AddWithValue("@lottoNumbers", submittedLottoNumbers);

                        com.Parameters.AddWithValue("@balance", newBalance);

                        com.ExecuteNonQuery();
                    }
                }
            }

            LabelWithdrawAmount.Text = "LOTTO NUMBERS SUBMITTED. Only One Submission Per Login\nWinnings Shall Be Shown On Next Login\nGood Luck!";

            LabelWithdrawAmount.Left = (this.ClientSize.Width - LabelWithdrawAmount.Width) / 2;

            ButtonSubmitLOTTO.Enabled = false;

        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {

            ButtonReturn.Enabled = false;

            _form4.Show();

            this.Close();

        }
    }
}



/*private void ButtonSubmitLOTTO_Click(object sender, EventArgs e)
{

    int[] lottoNumbers = { Convert.ToInt32(NumberBox1.Text), Convert.ToInt32(NumberBox2.Text), Convert.ToInt32(NumberBox3.Text),
            Convert.ToInt32(NumberBox4.Text), Convert.ToInt32(NumberBox5.Text), Convert.ToInt32(NumberBox6.Text) };

    string joinTest = string.Join("", lottoNumbers);

    MessageBox.Show(joinTest);

    int lottoNumberLength = lottoNumbers.Length;

    for (int numIndex = 0; numIndex < lottoNumberLength; numIndex++)
    {

        int num = lottoNumbers[numIndex];

        //string joinTest2 = string.Join("", num);

        //MessageBox.Show(joinTest2);

        for (int i = 0; i < lottoNumberLength && i != numIndex; i++)
        {

            if (lottoNumbers[i] == num)
            {

                LabelWrongLOTTO.Visible = true;

                return;

            }
            else
            {

                LabelWrongLOTTO.Visible = false;

                //Continue Cool Stuff Here :))))))))))



            }

        }

    }

}*/

/*using (var connection = new SqliteConnection("Data Source = cardDatabase.db;"))
            {

                connection.Open();

                string sql = "SELECT lottoNumbers FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand (sql, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var lottoNumbers = command.ExecuteScalar();

                    if (lottoNumbers != DBNull.Value)
                    {

                        LabelWinningsLOTTO.Visible = true;

                        int[] winningLottoNumbers = new int[6];

                        outerLoop:
                        for (int i = 0; i < 6;  i++)
                        {

                            Random random = new Random();

                            int min = 1;

                            int max = 50;

                            int randNum = random.Next(min, max);

                            foreach (int num in winningLottoNumbers)
                            {

                                if (randNum == num && i != Array.IndexOf(winningLottoNumbers, num))
                                {

                                    i = i - 1;

                                    goto outerLoop;

                                }

                            }

                            winningLottoNumbers[i] = randNum;

                        }

                        int equalNumbers = 0;

                        string[] submittedLottoNumbers = lottoNumbers.ToString().Split(",");

                        foreach (string subNum in submittedLottoNumbers)
                        {

                            foreach (int winNum in winningLottoNumbers)
                            {

                                if (subNum == winNum.ToString())
                                {

                                    equalNumbers++;

                                    break;

                                }

                            }

                        }

                        int winnings = 0;

                        if (equalNumbers == 0)
                        {

                            winnings = 0;

                        }
                        if (equalNumbers == 1)
                        {

                            winnings = 100;

                        }
                        if (equalNumbers == 2)
                        {

                            winnings = 1000;

                        }
                        if (equalNumbers == 3)
                        {

                            winnings = 10000;

                        }
                        if (equalNumbers == 4)
                        {

                            winnings = 100000;

                        }
                        if (equalNumbers == 5)
                        {

                            winnings = 500000;

                        }
                        if (equalNumbers == 6)
                        {

                            winnings = 1000000;

                        }

                        string winningLottoNumbersString = string.Join(", ", winningLottoNumbers);

                        string submittedLottoNumbersString = string.Join(", ", submittedLottoNumbers);

                        LabelWinningsLOTTO.Text = $"LOTTO Numbers: {winningLottoNumbersString}\nSubmitted Numbers: {submittedLottoNumbersString}\nWinnings: R{winnings}";

                        LabelWinningsLOTTO.Left = (this.ClientSize.Width - LabelWinningsLOTTO.Width) / 2;

                        //MessageBox.Show(string.Join(",", winningLottoNumbers));

                        //MessageBox.Show(string.Join(",", submittedLottoNumbers));

                        //MessageBox.Show(equalNumbers.ToString());

                        if (winnings > 0)
                        {

                            string getBal = "SELECT balance FROM cardDetails WHERE cardNumber = @cardNum";

                            using (var com = new SqliteCommand(getBal, connection))
                            {

                                com.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                                var balance = com.ExecuteScalar();

                                object newBalance = Convert.ToInt64(balance) + Convert.ToInt64(winnings);

                                string updateBal = "UPDATE cardDetails SET balance = @balance WHERE cardNumber = @cardNum";

                                using (var comm = new SqliteCommand(updateBal, connection))
                                {

                                    comm.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                                    comm.Parameters.AddWithValue("@balance", newBalance);

                                    comm.ExecuteNonQuery();

                                }

                            }

                        }

                        string clearLottoNumbers = "UPDATE cardDetails SET lottoNumbers = NULL WHERE cardNumber = @cardNum";

                        using (var comm = new SqliteCommand(clearLottoNumbers, connection))
                        {

                            comm.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                            comm.ExecuteNonQuery();

                        }

                    }

                }

            }*/