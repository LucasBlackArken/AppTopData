/*
 * Criado Por: Lucas Freitas
 * Data: 09/07/2024
 */

using AppTopData.Models;
using AppTopData.Utils;
using System.Data.SQLite;

namespace AppTopData.Data;

public class TarefaRepository
{
    public TarefaRepository()
    {
        InicializarDatabase();
    }

    private void InicializarDatabase()
    {
        using (var connection = new SQLiteConnection(Util.connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand(
                "CREATE TABLE IF NOT EXISTS Tarefas " +
                "(Id INTEGER PRIMARY KEY AUTOINCREMENT" +
                ",Descricao TEXT" +
                ",Status INTEGER)"
                ,connection);
            command.ExecuteNonQuery();
        }
    }

    public List<Tarefa> ListaTarefas()
    {
        var lista = new List<Tarefa>();
        using (var connection = new SQLiteConnection(Util.connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand(
                "SELECT * FROM Tarefas"
                ,connection);
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Tarefa
                    {
                        Id = reader.GetInt32(0),
                        Descricao = reader.GetString(1),
                        Status = reader.GetInt32(2)
                    });
                }
            }
        }
        return lista;
    }

    public void AdicionarTarefa(Tarefa tarefa)
    {
        using (var connection = new SQLiteConnection(Util.connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand(
                "INSERT INTO Tarefas " +
                    " (Descricao, Status)" +
                " VALUES" +
                    " (@Descricao, @Status)"
                    ,connection);
            command.Parameters.AddWithValue("@Descricao", tarefa.Descricao);
            command.Parameters.AddWithValue("@Status", tarefa.Status);
            command.ExecuteNonQuery();
        }
    }

    public void RemoverTarefa(Tarefa tarefa)
    {
        using (var connection = new SQLiteConnection(Util.connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand(
                "DELETE FROM Tarefas" +
                " WHERE Id = @Id"
                ,connection);
            command.Parameters.AddWithValue("@Id", tarefa.Id);
            command.ExecuteNonQuery();
        }
    }

    public void AtualizarTarefa(Tarefa tarefa)
    {
        using (var connection = new SQLiteConnection(Util.connectionString))
        {
            connection.Open();
            var command = new SQLiteCommand(
                "UPDATE Tarefas " +
                " SET Status = @Status" +
                " WHERE Id = @Id"
                ,connection);
            command.Parameters.AddWithValue("@Status", tarefa.Status);
            command.Parameters.AddWithValue("@Id", tarefa.Id);
            command.ExecuteNonQuery();
        }
    }
}
