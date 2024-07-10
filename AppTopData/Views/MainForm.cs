/*
 * Criado Por: Lucas Freitas
 * Data: 09/07/2024
 */

using AppTopData.Controllers;
using AppTopData.Models;

namespace AppTopData;

public partial class MainForm : Form
{
    private TarefaController _tarefaController;

    public MainForm()
    {
        InitializeComponent();
        _tarefaController = new TarefaController();
        CarregarTarefa();
    }

    private void CarregarTarefa()
    {
        var lista = _tarefaController.ListaTarefas();
        listBoxTasks.Items.Clear();
        foreach (var item in lista)
        {
            var status = item.Status == 0 ? "[Em Andamento]" : "[Concluída]";
            listBoxTasks.Items.Add(new ListBoxItem { Tarefa = item, Texto = $"{status} {item.Descricao}" });
        }
    }

    private void BotaoAdicionarTarefa_Click(object sender, EventArgs e)
    {
        var descricao = textBoxDescricao.Text;
        if (!string.IsNullOrWhiteSpace(descricao))
        {
            _tarefaController.AdicionarTarefa(descricao);
            CarregarTarefa();
            textBoxDescricao.Clear();
        }
    }

    private void BotaoRemoverTarefa_Click(object sender, EventArgs e)
    {
        if (listBoxTasks.SelectedItem is ListBoxItem selectedItem)
        {
            _tarefaController.RemoverTarefa(selectedItem.Tarefa!);
            CarregarTarefa();
        }
    }

    private void BotaoAtualizarTarefa_Click(object sender, EventArgs e)
    {
        if (listBoxTasks.SelectedItem is ListBoxItem selectedItem)
        {
            _tarefaController.AtualizarTarefa(selectedItem.Tarefa!);
            CarregarTarefa();
        }
    }

    private void MainForm_CarregarTarefa(object sender, EventArgs e)
    {
        CarregarTarefa();
    }
}


