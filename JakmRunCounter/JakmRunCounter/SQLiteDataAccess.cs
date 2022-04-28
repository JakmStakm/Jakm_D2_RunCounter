using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakmRunCounter
{
    public class SQLiteDataAccess
    {
        public static List<d2ItemModel> LoadItems(string profileName)
        {
            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile(profileName)))
            {
                newSqlite.Open();

                var output = newSqlite.Query<d2ItemModel>("select * from d2Items", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void saveProfile(string profileName)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(@"DataSource=.\Profiles.db"))
            {
                cnn.Open();
                SQLiteCommand checkExists = new SQLiteCommand(cnn);
                string cmdText = $"SELECT count(*) FROM settings WHERE profileName='{profileName}'";
                checkExists.CommandText = cmdText;
                Console.WriteLine(cmdText);
                int count = Convert.ToInt32(checkExists.ExecuteScalar());
                if (count == 0)
                {
                    checkExists.CommandText = $"INSERT INTO settings(profileName) VALUES ('{profileName}')";
                    checkExists.ExecuteNonQuery();
                }

            }

            System.IO.File.WriteAllText(@".\lastUsedProfile.txt", profileName);

        }

        private static string currentProfile(string profileName)
        {
            return $@"data source=.\{profileName}.db";
        }

        public static void CreateNewProfile(string profileName) 
        {
            if (!System.IO.File.Exists($@".\{profileName}.db"))
            {
                Console.WriteLine("Creating Database for " + profileName);
                File.Copy(@".\JakmD2ItemDB.db", $@".\{profileName}.db");
                //SQLiteConnection.CreateFile($@".\{profileName}.db3");

                //using (var sqlite2 = new SQLiteConnection($@"data source=.\{profileName}.db"))
                //{
                //    sqlite2.Open();
                //    Console.WriteLine("Database Created");
                //}
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Profile already exists");
            }
        }

        public static void createInitialSettings()
        {
            if (!System.IO.File.Exists(@".\Profiles.db"))
            {

                SQLiteConnection.CreateFile(@".\Profiles.db");
                using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile("Profiles")))
                {
                    newSqlite.Open();

                    string setup = "create table settings (profileName varchar(50))";
                    SQLiteCommand command = new SQLiteCommand(setup, newSqlite);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Database Created");
                }

            }

            if (!System.IO.File.Exists(@".\lastUsedProfile.txt"))
            {
                System.IO.File.WriteAllText(@".\lastUsedProfile.txt", "");
            }
        }

        public static List<profileModel> getProfiles()
        {
            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile("Profiles")))
            {
                newSqlite.Open();

                var output = newSqlite.Query<profileModel>("select * from settings", new DynamicParameters());
                return output.ToList();
            }
        }

        public static Boolean checkIFNewHolyGrail(string profileName, string itemName)
        {

            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile(profileName)))
            {
                newSqlite.Open();
                var sqlCommand = $"select found from d2Items where name like '{itemName}'";
                var output = newSqlite.Query<d2ItemModel>(sqlCommand, new DynamicParameters());
                foreach(d2ItemModel ifFound in output)
                {
                    if (ifFound.found == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                return false;
            }

        }

        public static void addNewItem(string profileName, string itemName, string date)
        {

            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile(profileName)))
            {
                newSqlite.Open();
                SQLiteCommand command = new SQLiteCommand(newSqlite);
                var sqlCommand = $"update d2Items set found = '1' where name = '{itemName}'";
                command.CommandText = sqlCommand;
                command.ExecuteNonQuery();
                sqlCommand = $"update d2Items set date = '{date}' where name = '{itemName}'";
                command.CommandText = sqlCommand;
                command.ExecuteNonQuery();
            }
        }

        public static Boolean checkItemExists(string profileName, string itemName)
        {
            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile(profileName)))
            {
                newSqlite.Open();
                var sqlCommand = $"select count(*) from d2Items where name='{itemName}'";
                SQLiteCommand command = new SQLiteCommand(newSqlite);
                command.CommandText = sqlCommand;
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public static List<d2ItemModel> searchItemNames(string profileName, string sqlCommand)
        {
            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile(profileName)))
            {
                newSqlite.Open();

               var output = newSqlite.Query<d2ItemModel>(sqlCommand, new DynamicParameters());
                return output.ToList();
            }
        }

        public static string CheckDateOfHolyGrail(string profileName, string itemName)
        {

            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile(profileName)))
            {
                newSqlite.Open();
                var sqlCommand = $"select date from d2Items where name like '{itemName}'";
                var output = newSqlite.Query<d2ItemModel>(sqlCommand, new DynamicParameters());
                foreach (d2ItemModel ifFound in output)
                {
                    return ifFound.date;
                }
                return "unknown";
            }

        }

        public static void deleteProfile(string profileName)
        {

            using (SQLiteConnection newSqlite = new SQLiteConnection(currentProfile("Profiles")))
            {
                newSqlite.Open();
                SQLiteCommand command = new SQLiteCommand(newSqlite);
                var sqlCommand = $"delete from settings where profileName = '{profileName}'";
                command.CommandText = sqlCommand;
                command.ExecuteNonQuery();
                Boolean fileExists = false;
                string profilePath = $@"{Directory.GetCurrentDirectory()}" + "\\" + $"{profileName}" + ".db";
                if (File.Exists(profilePath))
                {
                    File.Delete(profilePath);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(profilePath + " NOT FOUND. Please delete manually if not needed");
                }
                
            }
        }

    }
}
