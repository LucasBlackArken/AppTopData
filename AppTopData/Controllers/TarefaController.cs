/*
 * Criado Por: Lucas Freitas
 * Data: 09/07/2024
 */

using AppTopData.Data;
using AppTopData.Models;

namespace AppTopData.Controllers;

public class TarefaController
{
    private TarefaRepository _tarefaRepository;

    public TarefaController()
    {
        _tarefaRepository = new TarefaRepository();
    }

    public List<Tarefa> ListaTarefas()
    {
        return _tarefaRepository.ListaTarefas();
    }

    public void AdicionarTarefa(string descricao)
    {
        var tarefa = new Tarefa { Descricao = descricao, Status = 0 };
        _tarefaRepository.AdicionarTarefa(tarefa);
    }

    public void RemoverTarefa(Tarefa tarefa)
    {
        _tarefaRepository.RemoverTarefa(tarefa);
    }

    public void AtualizarTarefa(Tarefa tarefa)
	{
        tarefa.Status = 1;
        _tarefaRepository.AtualizarTarefa(tarefa);
    }
}
