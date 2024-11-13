using Microsoft.Data.Sqlite;
using SQLitePCL;
using System.Data;
using System.Windows.Forms;

namespace ATM_Application
{
    public partial class Form1 : Form
    {

        //private string dbPath = "cardDatabase.db";

        public Form1()
        {
            InitializeComponent();

            LabelCardCheck.Visible = false;

            GifCardCheck.Visible = false;

            ComboBoxCards.Visible = false;

            LabelChooseCard.Visible = false;

            SQLitePCL.Batteries.Init();

            CreateDatabase();

            CardReUse();
        }

        private void CreateDatabase()
        {

            if (!File.Exists("cardDatabase.db"))
            {

                //File.Delete("cardDatabase.db");

                using (var connection = new SqliteConnection($"Data Source=cardDatabase.db;"))
                {

                    connection.Open();

                    string createTable = "CREATE TABLE IF NOT EXISTS cardDetails (id INTEGER PRIMARY KEY AUTOINCREMENT, cardNumber INTEGER, cardPIN INTEGER, balance INTEGER, lottoNumbers TEXT)";

                    using (var command = new SqliteCommand(createTable, connection))
                    {

                        command.ExecuteNonQuery();

                    }
                }
            }
        }

        private void CardReUse()
        {

            using (var connection = new SqliteConnection($"Data Source=cardDatabase.db"))
            {

                connection.Open();

                string sql = "SELECT cardNumber, cardPIN FROM cardDetails";

                using (var command = new SqliteCommand(sql, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {

                        ComboBoxCards.Items.Clear();

                        while (reader.Read())
                        {

                            var cardNum = reader["cardNumber"].ToString();

                            var cardPIN = reader["cardPIN"].ToString();

                            ComboBoxCards.Items.Add("Card Number: " + cardNum + " PIN: " + cardPIN + "");

                        }
                    }
                }
            }

            if (ComboBoxCards.Items.Count > 0)
            {

                ComboBoxCards.Visible = true;

                LabelChooseCard.Visible = true;

            }

        }

        public static class GlobalVariables
        {

            public static long cardNum;

        }

        private async void ButtonInsertCard_Click(object sender, EventArgs e)
        {

            if (ComboBoxCards.SelectedItem != null)
            {

                var comboBoxCard = ComboBoxCards.SelectedItem.ToString();

                string cardNumReused = comboBoxCard.Substring(13, 16);

                GlobalVariables.cardNum = long.Parse(cardNumReused);

            }
            else
            {

                CardDetails();

            }

            //DeleteAllRecords();

            //LoadData();

            ButtonInsertCard.Enabled = false;

            LabelCardCheck.Visible = true;

            GifCardCheck.Visible = true;

            await Task.Delay(4000);

            LabelCardCheck.Text = "Card Checking Succesful";

            LabelCardCheck.Left = (this.ClientSize.Width - LabelCardCheck.Width) / 2;

            GifCardCheck.Image = null;

            await Task.Delay(1000);

            Form2 form2 = new Form2(this);

            form2.ShowDialog();

            this.Close();

        }

        private void CardDetails()
        {

            Random random = new Random();

            GlobalVariables.cardNum = random.NextInt64(1000000000000000, 9999999999999999);

            int bal = random.Next(10, 1000000);

            using (var connection = new SqliteConnection("Data Source=cardDatabase.db;"))
            {

                connection.Open();

                string insertQuery = "INSERT INTO cardDetails (cardNumber, balance) VALUES (@cardNum, @bal)";

                using (var command = new SqliteCommand(insertQuery, connection))
                {

                    command.Parameters.AddWithValue("@cardNum", GlobalVariables.cardNum);

                    command.Parameters.AddWithValue("@bal", bal);

                    command.ExecuteNonQuery();

                }
            }
        }

        /*private void LoadData()
        {

            dataGridView1.Visible = true;

            using (var connection = new SqliteConnection("Data Source=cardDatabase.db"))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM cardDetails";

                    using (var command = new SqliteCommand(selectQuery, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();

                            dataTable.Load(reader);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void DeleteAllRecords()
        {
            using (var connection = new SqliteConnection("Data Source=cardDatabase.db"))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM cardDetails";

                    using (var command = new SqliteCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    string resetSequenceQuery = "DELETE FROM sqlite_sequence WHERE name='cardDetails';";

                    using (var resetCommand = new SqliteCommand(resetSequenceQuery, connection))
                    {
                        resetCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }*/

    }
}
