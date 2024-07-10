/*
 * Criado Por: Lucas Freitas
 * Data: 09/07/2024
 */

namespace AppTopData.Models;
public class Tarefa
{
    public int? Id { get; set; }
    public string? Descricao { get; set; }
    public int? Status { get; set; } // 0 - Em Andamento, 1 - Concluída
}

