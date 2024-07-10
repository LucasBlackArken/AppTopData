/*
 * Criado Por: Lucas Freitas
 * Data: 09/07/2024
 */

namespace AppTopData;

	public partial class MainForm : Form
{
    private System.ComponentModel.IContainer components = null;
    private TextBox textBoxDescricao;
    private Button buttonAdicionarTarefa;
    private Button buttonRemoverTarefa;
    private Button buttonAtualizarTarefa;
    private ListBox listBoxTasks;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.textBoxDescricao = new TextBox();
        this.buttonAdicionarTarefa = new Button();
        this.buttonRemoverTarefa = new Button();
        this.buttonAtualizarTarefa = new Button();
        this.listBoxTasks = new ListBox();
        this.SuspendLayout();

        // TextBox
        this.textBoxDescricao.Location = new Point(12, 12);
        this.textBoxDescricao.Name = "Descrição";
        this.textBoxDescricao.Size = new Size(776, 20);
        this.textBoxDescricao.TabIndex = 0;

        // Button Adicionar Tarefa
        this.buttonAdicionarTarefa.Location = new Point(12, 38);
        this.buttonAdicionarTarefa.Name = "buttonAdicionarTarefa";
        this.buttonAdicionarTarefa.Size = new Size(75, 23);
        this.buttonAdicionarTarefa.TabIndex = 1;
        this.buttonAdicionarTarefa.Text = "Adicionar Tarefa";
        this.buttonAdicionarTarefa.UseVisualStyleBackColor = true;
        this.buttonAdicionarTarefa.Click += new EventHandler(this.BotaoAdicionarTarefa_Click);

        // Button Remover Tarefa
        this.buttonRemoverTarefa.Location = new Point(93, 38);
        this.buttonRemoverTarefa.Name = "buttonRemoverTarefa";
        this.buttonRemoverTarefa.Size = new Size(100, 23);
        this.buttonRemoverTarefa.TabIndex = 2;
        this.buttonRemoverTarefa.Text = "Remover Tarefa";
        this.buttonRemoverTarefa.UseVisualStyleBackColor = true;
        this.buttonRemoverTarefa.Click += new EventHandler(this.BotaoRemoverTarefa_Click);

        // Button Atualizar Tarefa
        this.buttonAtualizarTarefa.Location = new Point(199, 38);
        this.buttonAtualizarTarefa.Name = "buttonAtualizarTarefa";
        this.buttonAtualizarTarefa.Size = new Size(150, 23);
        this.buttonAtualizarTarefa.TabIndex = 3;
        this.buttonAtualizarTarefa.Text = "Marcar como Concluída";
        this.buttonAtualizarTarefa.UseVisualStyleBackColor = true;
        this.buttonAtualizarTarefa.Click += new EventHandler(this.BotaoAtualizarTarefa_Click);

        // ListBox
        this.listBoxTasks.FormattingEnabled = true;
        this.listBoxTasks.Location = new Point(12, 67);
        this.listBoxTasks.Name = "Lista";
        this.listBoxTasks.Size = new Size(776, 368);
        this.listBoxTasks.TabIndex = 4;

        // MainForm
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(this.listBoxTasks);
        this.Controls.Add(this.buttonAtualizarTarefa);
        this.Controls.Add(this.buttonRemoverTarefa);
        this.Controls.Add(this.buttonAdicionarTarefa);
        this.Controls.Add(this.textBoxDescricao);
        this.Name = "MainForm";
        this.Text = "Gerenciador de Tarefas";
        this.Load += new EventHandler(this.MainForm_CarregarTarefa);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
