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
    public partial class Form4 : Form
    {

        private Form2 _form2;

        object newBalance;

        public Form4(Form2 form2)
        {
            InitializeComponent();

            _form2 = form2;

            HideForm();

            LabelInsufficientBalance.Visible = false;

            WinningsLOTTO();
        }

        private async void HideForm()
        {

            await Task.Delay(1);

            _form2.Hide();

        }

        public static class OptionSelector
        {

            public static string option;

            public static string winningLottoNumbersLabel;

            public static string submittedLottoNumbersLabel;

            public static int winningsLabel;

        }

        private void WinningsLOTTO()
        {

            using (var connection = new SqliteConnection("Data Source = cardDatabase.db;"))
            {

                connection.Open();

                string sql = "SELECT lottoNumbers FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand(sql, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var lottoNumbers = command.ExecuteScalar();

                    if (lottoNumbers != DBNull.Value)
                    {

                        int[] winningLottoNumbers = new int[6];

                    outerLoop:
                        for (int i = 0; i < 6; i++)
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

                        OptionSelector.winningLottoNumbersLabel = winningLottoNumbersString;

                        OptionSelector.submittedLottoNumbersLabel = submittedLottoNumbersString;

                        OptionSelector.winningsLabel = winnings;

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
            }
        }

        private void ButtonWithdraw50_Click(object sender, EventArgs e)
        {

            using (var connection = new SqliteConnection("Data Source=cardDatabase.db;"))
            {

                connection.Open();

                string getBal = "SELECT balance FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand(getBal, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var balance = command.ExecuteScalar();

                    if (Convert.ToInt64(balance) > 50)
                    {

                        OptionSelector.option = "withdraw";

                        ButtonWithdraw50.Enabled = false;

                        newBalance = Convert.ToInt64(balance) - 50;

                        //MessageBox.Show(newBalance.ToString());

                        string updateBal = "UPDATE cardDetails SET balance = @balance WHERE cardNumber = @cardNum";

                        using (var com = new SqliteCommand(updateBal, connection))
                        {

                            com.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                            com.Parameters.AddWithValue("@balance", newBalance);

                            com.ExecuteNonQuery();

                        }

                        Form5 form5 = new Form5(this);

                        form5.ShowDialog();

                        this.Close();

                    }
                    else
                    {

                        LabelInsufficientBalance.Visible = true;

                    }
                }
            }
        }

        private void ButtonWithdraw150_Click(object sender, EventArgs e)
        {

            using (var connection = new SqliteConnection("Data Source=cardDatabase.db;"))
            {

                connection.Open();

                string getBal = "SELECT balance FROM cardDetails WHERE cardNumber = @cardNum";

                using (var command = new SqliteCommand(getBal, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                    var balance = command.ExecuteScalar();

                    if (Convert.ToInt64(balance) > 150)
                    {

                        OptionSelector.option = "withdraw";

                        ButtonWithdraw150.Enabled = false;

                        newBalance = Convert.ToInt64(balance) - 150;

                        //MessageBox.Show(newBalance.ToString());

                        string updateBal = "UPDATE cardDetails SET balance = @balance WHERE cardNumber = @cardNum";

                        using (var com = new SqliteCommand(updateBal, connection))
                        {

                            com.Parameters.AddWithValue("@cardNum", Form1.GlobalVariables.cardNum);

                            com.Parameters.AddWithValue("@balance", newBalance);

                            com.ExecuteNonQuery();

                        }

                        Form5 form5 = new Form5(this);

                        form5.ShowDialog();

                        this.Close();

                    }
                    else
                    {

                        LabelInsufficientBalance.Visible = true;

                    }
                }
            }
        }

        private void ButtonChangePIN_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3(this);

            form3.ShowDialog();

        }

        private void ButtonWithdrawCustom_Click(object sender, EventArgs e)
        {

            OptionSelector.option = "custom";

            ButtonWithdrawCustom.Enabled = false;

            Form5 form5 = new Form5(this);

            form5.ShowDialog();

            this.Close();

        }

        private void ButtonCheckBalance_Click(object sender, EventArgs e)
        {

            OptionSelector.option = "balance";

            Form5 form5 = new Form5(this);

            form5.ShowDialog();

        }

        private void ButtonPlayLOTTO_Click(object sender, EventArgs e)
        {

            OptionSelector.option = "lotto";

            Form5 form5 = new Form5(this);

            form5.ShowDialog();

        }
    }
}
