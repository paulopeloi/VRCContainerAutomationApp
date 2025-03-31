using Microsoft.Data.Sqlite;
using System.Diagnostics;
using VRCContainerAutomationApp.SQLs;

namespace VRCContainerAutomationApp.Database;
public static class SQLiteService
{
    private static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    private static readonly string databasePath = Path.Combine(baseDirectory, "vrc_industrial_automation.db");
    private static readonly string connectionString = $"Data Source={databasePath}";

    static SQLiteService()
    {
        Debug.WriteLine($"[SQLite] Iniciando SQLiteService...");

        if (!File.Exists(databasePath))
        {
            Debug.WriteLine("[SQLite] Banco não encontrado, criando um novo...");
            CreateDatabase();
            Debug.WriteLine("[SQLite] Banco criado com sucesso!");
        }
        
        Debug.WriteLine($"[SQLite] Caminho do banco: {databasePath}");
    }

    public static SqliteConnection GetConnection()
    {
        return new SqliteConnection(connectionString);
    }

    private static void CreateDatabase()
    {
        using var connection = GetConnection();
        connection.Open();

        using var command = connection.CreateCommand();
        command.CommandText = CreateDatabaseSql.CreateDatabase;
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

    public static void ExecuteTransaction(Action<SqliteConnection, SqliteTransaction> action)
    {
        using var connection = GetConnection();
        connection.Open();

        using var transaction = connection.BeginTransaction();

        try
        {
            action(connection, transaction);
            transaction.Commit();
        }
        catch (Exception ex)
        {
            transaction.Rollback();
            Debug.WriteLine($"[SQLite] Falha - Houve Rollback na Transação: {ex.Message}");
            throw;
        }
    }
}
