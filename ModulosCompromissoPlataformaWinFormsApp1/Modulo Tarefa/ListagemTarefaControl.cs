using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModulosCompromissoPlataformaWinFormsApp1.Modulo_Tarefa
{
    public partial class ListagemTarefaControl : UserControl
    {
        List<Tarefa> tarefas = new List<Tarefa>();


        public ListagemTarefaControl()
        {
            InitializeComponent();
            tarefas.Add(new Tarefa(1,"lavar carro","alta"));
            tarefas.Add(new Tarefa(2, "lavar cachorro", "alta"));

            foreach (Tarefa tarefa in tarefas)
            {

                listTarefa.Items.Add(tarefa);
            }

        }


    }
}
