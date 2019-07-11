using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TxtTesting
{
    public class DatabaseUtility : IDisposable
    {
        private string ConnectionString = "Server=localhost;Database=Maplestory;Trusted_Connection=True;MultipleActiveResultSets=true;";
        private SqlConnection Cnn;

        public DatabaseUtility()
        {
            Cnn = new SqlConnection(ConnectionString);
            Cnn.Open();
        }

        public SqlDataReader SelectItem(string itemName)
        {
            string sqlQuery = "SELECT * FROM Item WHERE Name = @itemName";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@itemName", itemName);

            return command.ExecuteReader();
        }

        public SqlDataReader SelectCharacter(string charName)
        {
            string sqlQuery = "SELECT * FROM Character WHERE CharName = @charName";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@charName", charName);

            return command.ExecuteReader();
        }

        internal SqlDataReader SelectItemStats(int itemId)
        {
            string sqlQuery = "SELECT * FROM ItemStats WHERE ItemId = @itemId";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@itemId", itemId);

            return command.ExecuteReader();
        }

        public SqlDataReader SelectTransaction(int itemId)
        {
            string sqlQuery = "SELECT * FROM Transactions t INNER JOIN ItemStats is ON t.ItemStats = is.Id INNER JOIN Item i ON is.ItemId = i.Id WHERE i.Id = @itemId";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@itemId", itemId);

            return command.ExecuteReader();
        }

        public int InsertItem(string itemName)
        {
            string sqlQuery = "INSERT INTO Item output INSERTED.ID VALUES (@itemName)";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@itemName", itemName);

            return (int)command.ExecuteScalar();
        }

        public int InsertCharacter(string characterName, string discordName)
        {
            string sqlQuery = "INSERT INTO Character output INSERTED.ID VALUES (@characterName, @discordName)";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@characterName", characterName);
            command.Parameters.AddWithValue("@discordName", discordName);

            return (int)command.ExecuteScalar();
        }

        public int InsertItemStats(ItemStats itemStats)
        {
            string sqlQuery = "INSERT INTO ItemStats output INSERTED.ID VALUES (@slots, @str, @dex, @int, @luk, @hp, @mp, @att, @matt, @acc, @upgrades, @itemId)";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@slots", itemStats.Slots);
            command.Parameters.AddWithValue("@str", itemStats.Str);
            command.Parameters.AddWithValue("@dex", itemStats.Dex);
            command.Parameters.AddWithValue("@int", itemStats.Int);
            command.Parameters.AddWithValue("@luk", itemStats.Luk);
            command.Parameters.AddWithValue("@hp", itemStats.Hp);
            command.Parameters.AddWithValue("@mp", itemStats.Mp);
            command.Parameters.AddWithValue("@att", itemStats.Att);
            command.Parameters.AddWithValue("@matt", itemStats.Matt);
            command.Parameters.AddWithValue("@acc", itemStats.Acc);
            command.Parameters.AddWithValue("@upgrades", itemStats.Upgrades);
            command.Parameters.AddWithValue("@itemId", itemStats.ItemId);

            return (int)command.ExecuteScalar();
        }

        public void UpdateDiscordName(string charName, string discName)
        {
            string sqlQuery = "UPDATE Character SET DiscName = @discName WHERE CharName = @charName";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@discName", discName);
            command.Parameters.AddWithValue("@charName", charName);

            command.ExecuteNonQuery();
        }

        public int InsertTransaction(Transaction transaction)
        {
            string sqlQuery = "INSERT INTO [Transaction] output INSERTED.ID VALUES (@type, @time, @channel, @fm, @price, @quantity, @sellerId, @buyerId, @itemStatsId)";

            SqlCommand command = new SqlCommand(sqlQuery, Cnn);
            command.Parameters.AddWithValue("@type", transaction.Type);
            command.Parameters.AddWithValue("@time", transaction.Time);
            command.Parameters.AddWithValue("@channel", transaction.Channel);
            command.Parameters.AddWithValue("@fm", transaction.Fm);
            command.Parameters.AddWithValue("@price", transaction.Price);
            command.Parameters.AddWithValue("@quantity", transaction.Quantity);
            command.Parameters.AddWithValue("@sellerId", transaction.SellerId);
            command.Parameters.AddWithValue("@buyerId", transaction.BuyerId);
            command.Parameters.AddWithValue("@itemStatsId", transaction.ItemStatsId);

            return (int)command.ExecuteScalar();
        }

        public void Dispose()
        {
            Cnn.Close();
        }
    }
}
