using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Globalization;
using System.Data.SqlClient;

namespace TxtTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Ryan\Desktop\Sales.txt");

            string[] sales = Regex.Split(text, @"(?=[\[])");
            sales = sales.Skip(1).ToArray();   //First array element is blank due to split... skip it

            //ParseSales();

            using (DatabaseUtility db = new DatabaseUtility())
            {
                foreach (string sale in sales)
                {
                    int itemId = ParseItem(sale, db);
                    int charId = ParseChar(sale, db, GetCharName(sale), GetDiscName(sale));
                    int buyerId = ParseChar(sale, db, GetBuyerName(sale), "");

                    ItemStats itemStats = new ItemStats();
                    itemStats.ItemId = itemId;
                    itemStats.Slots = GetSlots(sale);
                    itemStats.Str = GetStr(sale);
                    itemStats.Dex = GetDex(sale);
                    itemStats.Int = GetInt(sale);
                    itemStats.Luk = GetLuk(sale);
                    itemStats.Hp = GetHp(sale);
                    itemStats.Mp = GetMp(sale);
                    itemStats.Att = GetAtt(sale);
                    itemStats.Matt = GetMatt(sale);
                    itemStats.Acc = GetAcc(sale);
                    itemStats.Upgrades = GetUpgrades(sale);

                    int itemStatsId = -1;

                    using (var dataReader = db.SelectItemStats(itemId))
                    {
                        if (dataReader.Read())
                            itemStatsId = ItemStatsExists(dataReader, itemStats);
                        if (itemStatsId == -1)
                            itemStatsId = db.InsertItemStats(itemStats);
                    }

                    Transaction transaction = new Transaction();
                    transaction.Time = GetTransactionTime(sale);
                    transaction.Price = GetPrice(sale);
                    transaction.SellerId = charId;
                    transaction.BuyerId = buyerId;
                    transaction.ItemStatsId = itemStatsId;
                    transaction.Channel = GetChannel(sale);
                    transaction.Fm = GetFm(sale);

                    db.InsertTransaction(transaction);
                }
            }
        }

        private static int ItemStatsExists(SqlDataReader dataReader, ItemStats itemStats)
        {
            do
            {
                ItemStats dbItemStats = new ItemStats()
                {
                    Slots = Int32.Parse(dataReader["Slots"].ToString()),
                    Str = Int32.Parse(dataReader["Str"].ToString()),
                    Dex = Int32.Parse(dataReader["Dex"].ToString()),
                    Int = Int32.Parse(dataReader["Int"].ToString()),
                    Luk = Int32.Parse(dataReader["Luk"].ToString()),
                    Hp = Int32.Parse(dataReader["Hp"].ToString()),
                    Mp = Int32.Parse(dataReader["Mp"].ToString()),
                    Att = Int32.Parse(dataReader["Att"].ToString()),
                    Matt = Int32.Parse(dataReader["Matt"].ToString()),
                    Acc = Int32.Parse(dataReader["Acc"].ToString()),
                    Upgrades = Int32.Parse(dataReader["Upgrades"].ToString()),
                    ItemId = Int32.Parse(dataReader["ItemId"].ToString()),
                };

                if (itemStats.Equals(dbItemStats))
                    return Int32.Parse(dataReader["Id"].ToString());
            }
            while (dataReader.Read());

            return -1;
        }

        private static int ParseChar(string sale, DatabaseUtility db, string charName, string discName)
        {
            using (var dataReader = db.SelectCharacter(charName))
            {
                if (!dataReader.Read())
                    return db.InsertCharacter(charName, discName);
                else
                {
                    if (string.IsNullOrWhiteSpace(discName) && string.IsNullOrWhiteSpace(dataReader["DiscName"].ToString()))
                        db.UpdateDiscordName(charName, discName);

                    return Int32.Parse(dataReader["Id"].ToString());
                }
            }
        }

        private static int ParseItem(string sale, DatabaseUtility db)
        {
            string itemName = GetItemName(sale);
            int itemId = -1;
            using (var dataReader = db.SelectItem(itemName))
            {
                if (!dataReader.Read())
                    return db.InsertItem(itemName);
                else
                    return Int32.Parse(dataReader["Id"].ToString());
            }
        }

        private static string GetItemName(string sale)
        {
            return Regex.Match(sale, @"(?<=(n\) ))(.*)(?= to)").ToString();
        }

        private static string GetCharName(string sale)
        {
            return Regex.Match(sale, @"(?<=\] )\w+").ToString();
        }

        private static string GetBuyerName(string sale)
        {
            return Regex.Match(sale, @"(?<=to )\w+").ToString();
        }

        private static string GetDiscName(string sale)
        {
            return Regex.Match(sale, @"(?<=\@).*(?=\#)").ToString();
        }

        private static DateTime GetTransactionTime(string sale)
        {
            return DateTime.ParseExact(Regex.Match(sale, @"(?<=\[).*M(?=\])").ToString(), "dd-MMM-yy hh:mm tt", null);
        }

        private static int GetPrice(string sale)
        {
            return Int32.Parse(Regex.Match(sale, @"(?<=(for ))\d{1,3}(,\d{3})*(\.\d\d)?|\.\d\d").Value, NumberStyles.AllowThousands);
        }

        private static int GetChannel(string sale)
        {
            return Int32.Parse(Regex.Match(sale, @"(?<=l )\d").Value);
        }

        private static int GetFm(string sale)
        {
            return Int32.Parse(Regex.Match(sale, @"(?<=M )\d").Value);
        }

        private static int GetSlots(string sale)
        {
            if (Regex.IsMatch(sale, @"\d+(?= slots)"))
                return Int32.Parse(Regex.Match(sale, @"\d+(?= slots)").ToString());
            else
                return 0;
        }

        private static int GetStr(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=STR \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=STR \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetDex(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=DEX \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=DEX \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetInt(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=INT \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=INT \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetLuk(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=LUK \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=LUK \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetHp(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=HP \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=HP \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetMp(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=( |\()MP \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=( |\()MP \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetAtt(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=ATT \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=ATT \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetMatt(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=M.ATT \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=M.ATT \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetAcc(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=ACC \+)\d+"))
                return Int32.Parse(Regex.Match(sale, @"(?<=ACC \+)\d+").ToString());
            else
                return 0;
        }

        private static int GetUpgrades(string sale)
        {
            if (Regex.IsMatch(sale, @"(?<=\(\+)\d+(?= \|)"))
                return Int32.Parse(Regex.Match(sale, @"(?<=\(\+)\d+(?= \|)").ToString());
            else
                return 0;
        }

        private static void ParseSales()
        {
            //string text = File.ReadAllText(@"C:\Users\Ryan\Desktop\Sales.txt");
            string text = File.ReadAllText(@"C:\Users\Ryan\Desktop\SalesTest.txt");

            string[] sales = Regex.Split(text, @"(?=[\[])");
            sales = sales.Skip(1).ToArray();   //First array element is blank due to split... skip it

            int progressCounter = 0;

            foreach (string sale in sales)
            {
                string date = Regex.Match(sale, @"\[(.*?)\]").ToString();
                string seller = Regex.Match(sale, @"\w+(?=#)").ToString();
                string itemName = Regex.Match(sale, @"(?<=(n\) ))(.*)(?= to)").ToString();
                string price = Regex.Match(sale, @"(?<=(for ))\d{1,3}(,\d{3})*(\.\d\d)?|\.\d\d").ToString();
                string discordName = Regex.Match(sale, @"(?<=\@).*(?=\#)").ToString();
                string channel = Regex.Match(sale, @"(?<=l )\d").ToString();
                string fm = Regex.Match(sale, @"(?<=M )\d").ToString();
                string slots = Regex.Match(sale, @"\d+(?= slots)").ToString();
                string str = Regex.Match(sale, @"(?<=STR \+)\d+").ToString();
                string dex = Regex.Match(sale, @"(?<=DEX \+)\d+").ToString();
                string intelligence = Regex.Match(sale, @"(?<=INT \+)\d+").ToString();
                string luk = Regex.Match(sale, @"(?<=LUK \+)\d+").ToString();
                string hp = Regex.Match(sale, @"(?<=HP \+)\d+").ToString();
                string mp = Regex.Match(sale, @"(?<=( |\()MP \+)\d+").ToString();
                string att = Regex.Match(sale, @"(?<=ATT \+)\d+").ToString();
                string matt = Regex.Match(sale, @"(?<=M.ATT \+)\d+").ToString();
                string acc = Regex.Match(sale, @"(?<=ACC \+)\d+").ToString();
                string upgrades = Regex.Match(sale, @"(?<=\(\+)\d+(?= \|)").ToString();
                string buyerId = Regex.Match(sale, @"(?<=to )\w+").ToString();

                SaveFile(date, itemName, price);

                progressCounter++;
                Console.Write("\rProcessing.... (" + progressCounter * 100 / sales.Length + "%)");
            }

            Console.Write("\rProcessing Complete! Press any key.");
            Console.ReadKey();
        }

        static void SaveFile(string date, string itemName, string price)
        {
            string formattedData = date + " | " + price + Environment.NewLine;

            Regex illegalInFileName = new Regex(@"[\\/:*?""<>|]");
            itemName = illegalInFileName.Replace(itemName, "");

            string filePath = @"C:\Users\Ryan\Desktop\Maplestory_Sales\" + itemName + ".txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, formattedData);
            }
            else
            {
                File.AppendAllText(filePath, formattedData);
            }
        }
    }
}
