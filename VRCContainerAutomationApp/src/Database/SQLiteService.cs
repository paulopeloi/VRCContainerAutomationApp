using Microsoft.Data.Sqlite;
using System.Diagnostics;

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
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS containers (
                id                INTEGER PRIMARY KEY
                                          NOT NULL,
                uuid              TEXT    UNIQUE
                                          NOT NULL,
                height            REAL    NOT NULL,
                weight            REAL    NOT NULL,
                id_type           INTEGER REFERENCES containers_types (id) 
                                          NOT NULL,
                id_status         INTEGER REFERENCES containers_status (id) 
                                          NOT NULL,
                id_location       INTEGER REFERENCES warehouse_locations (id) 
                                          NOT NULL,
                received_at       TEXT    NOT NULL
                                          DEFAULT (CURRENT_TIMESTAMP),
                last_operation_at TEXT    DEFAULT (CURRENT_TIMESTAMP) 
            );

            CREATE TABLE IF NOT EXISTS containers_logs (
                id             INTEGER PRIMARY KEY AUTOINCREMENT
                                       NOT NULL,
                id_container   INTEGER REFERENCES containers (id) 
                                       NOT NULL,
                uuid_container TEXT    REFERENCES containers (uuid) 
                                       NOT NULL,
                id_location    INTEGER REFERENCES warehouse_locations (id) 
                                       NOT NULL,
                operation      TEXT    NOT NULL,
                timestamp      TEXT    DEFAULT (CURRENT_TIMESTAMP) 
            );

            CREATE TABLE IF NOT EXISTS containers_status (
                id          INTEGER PRIMARY KEY AUTOINCREMENT
                                    NOT NULL,
                status      TEXT    NOT NULL,
                description TEXT    NOT NULL
            );

            CREATE TABLE IF NOT EXISTS containers_types (
                id          INTEGER PRIMARY KEY AUTOINCREMENT
                                    NOT NULL,
                type        TEXT    NOT NULL,
                description TEXT    NOT NULL
            );

            CREATE TABLE IF NOT EXISTS warehouse_locations (
                id                      INTEGER PRIMARY KEY AUTOINCREMENT
                                                NOT NULL,
                zone                    TEXT    NOT NULL,
                permitted_type          INTEGER REFERENCES containers_types (id) 
                                                NOT NULL,
                max_weight              REAL    NOT NULL,
                max_height              REAL    NOT NULL,
                max_quantity_containers INTEGER NOT NULL,
                container_count         INTEGER NOT NULL
                                                DEFAULT (0),
                last_operation_at       TEXT    DEFAULT (CURRENT_TIMESTAMP) 
            );

            INSERT INTO containers_types (id, type, description)
                 VALUES (1, 'Químico', 'Produtos perigosos ou inflamáveis'),
                        (2, 'Alimentício', 'Produtos perecíveis ou secos'),
                        (3, 'Eletrônico', 'Equipamentos e componentes delicados'),
                        (4, 'Material de Construção', 'Pesados, empilháveis, resistentes'),
                        (5, 'Têxtil', 'Roupas, tecidos, calçados');

            INSERT INTO containers_status (id, status, description)
                 VALUES (1, 'Aguardando Armazenamento', 'Foi cadastrado, mas ainda não foi armazenado fisicamente'),
                        (2, 'Armazenado', 'Está armazenado numa localização válida'),
                        (3, 'Em Movimentação', 'Está sendo movido de um local para outro'),
                        (4, 'Aguardando Despacho', 'Está pronto pra ser despachado, aguardando comando'),
                        (5, 'Despachado', 'Já foi retirado do armazém'),
                        (6, 'Erro', 'Ocorreu alguma falha na operação');

            INSERT INTO warehouse_locations (id, zone, permitted_type, max_weight, max_height, max_quantity_containers)
	            VALUES (1, 'Setor A / Posição 1', 1, 2000, 2.5, 2),
		               (2, 'Setor A / Posição 2', 1, 1000, 2.2, 2),
		               (3, 'Setor B / Posição 1', 2, 1500, 3.0, 2),
		               (4, 'Setor B / Posição 2', 2, 800, 1.8, 2),
		               (5, 'Setor C / Posição 1', 3, 1200, 2.0, 2),
		               (6, 'Setor C / Posição 2', 3, 2500, 2.5, 2),
		               (7, 'Setor D / Posição 1', 4, 500, 2.2, 2),
		               (8, 'Setor D / Posição 2', 4, 1000, 2.5, 2),
		               (9, 'Setor E / Posição 1', 5, 1000, 2.0, 2),
		               (10, 'Setor E / Posição 2', 5, 900, 2.0, 2);
        ";
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
