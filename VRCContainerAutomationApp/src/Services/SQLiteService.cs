using Microsoft.Data.Sqlite;
using SQLitePCL;

namespace VRCContainerAutomationApp.Database;
public static class SQLiteService
{
    private static readonly string dbFileName = "vrc_industrial_automation.db";
    private static readonly string dbFolder = Path.Combine("src", "Database");
    private static readonly string dbPath = @"C:\Users\prpel\source\repos\VRCContainerAutomationApp\VRCContainerAutomationApp\src\Database\vrc_industrial_automation.db";
    private static readonly string connectionString = $"Data Source={dbPath}";

    static SQLiteService()
    {
        Batteries_V2.Init();
        if (!Directory.Exists(dbFolder))
        {
            Directory.CreateDirectory(dbFolder);
        }

        if (!File.Exists(dbPath))
        {
            Console.WriteLine("Aguarde... banco de dados sendo criado");
            CreateDatabase();
        }
    }

    public static SqliteConnection GetConnection()
    {
        Console.WriteLine($"[DEBUG] Usando banco em: {dbPath}");
        return new SqliteConnection(connectionString);
    }

    private static void CreateDatabase()
    {
        using var connection = GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = @"CREATE TABLE IF NOT EXISTS test_ping (id INTEGER PRIMARY KEY, msg TEXT)";
        command.ExecuteNonQuery();
    }

    public static int ExecuteCommand(string sql, Dictionary<string, object>? parameters = null)
    {
        using var connection = GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = sql;

        if (parameters != null)
        {
            foreach (var param in parameters)
                command.Parameters.AddWithValue(param.Key, param.Value);
        }

        return command.ExecuteNonQuery();
    }

    public static List<Dictionary<string, object>> ExecuteQuery(string sql, Dictionary<string, object>? parameters = null)
    {
        var results = new List<Dictionary<string, object>>();

        using var connection = GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = sql;

        if (parameters != null)
        {
            foreach (var param in parameters)
                command.Parameters.AddWithValue(param.Key, param.Value);
        }

        using SqliteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            var row = new Dictionary<string, object>();
            for (int i = 0; i < reader.FieldCount; i++)
                row[reader.GetName(i)] = reader.GetValue(i);
            results.Add(row);
        }

        return results;
    }
}
