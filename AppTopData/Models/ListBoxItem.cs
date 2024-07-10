/*
 * Criado Por: Lucas Freitas
 * Data: 09/07/2024
 */

namespace AppTopData.Models;

public class ListBoxItem
{
    public Tarefa? Tarefa { get; set; }
    public string? Texto { get; set; }

    public override string ToString()
    {
        return Texto!;
    }
}
