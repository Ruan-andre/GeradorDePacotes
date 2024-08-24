using System.Data;
using System.Data.SQLite;

namespace GeradorDePacotes.Database
{
    public class Database
    {
        public static string pathDb = AppDomain.CurrentDomain.BaseDirectory + @"\db.sqlite";

        public static SQLiteConnection sqliteConnection;

        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=" + pathDb);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CreateDbSQLite()
        {
            try
            {
                if (!File.Exists(pathDb))
                {
                    SQLiteConnection.CreateFile(pathDb);
                    CreateBaseTablesSQLite();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CreateBaseTablesSQLite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS par_keys(" +
                                      "id INT PRIMARY KEY, " +
                                      "par_name VARCHAR(50) NOT NULL, " +
                                      "par_value VARCHAR(50))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS foldersToVerify(" +
                                      "id INT PRIMARY KEY, " +
                                      "nameFolder VARCHAR(50))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS filesToVerify(" +
                                      "id INT PRIMARY KEY, " +
                                      "nameFile VARCHAR(50))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS filesToDelete(" +
                                      "id INT PRIMARY KEY, " +
                                      "nameFile VARCHAR(50), " +
                                      "disconsider INT NOT NULL CHECK (disconsider IN (0, 1)))";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS foldersToDelete(" +
                                      "id INT PRIMARY KEY, " +
                                      "nameFolder VARCHAR(50), " +
                                      "disconsider INT NOT NULL CHECK (disconsider IN (0, 1)))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetConfig()
        {
            return new DataTable() ;
        }

        public static DataTable GetKeysValue()
        {
            throw new NotImplementedException();
        }

        public static void Add()
        {
        }
        public static void Update()
        {
        }

        public static void Delete() { }

        public static void ExecuteQuery(string query)
        {

        }
    }
}
