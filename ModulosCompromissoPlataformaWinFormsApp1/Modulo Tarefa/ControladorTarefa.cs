using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using ModulosCompromissoPlataformaWinFormsApp1.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.Modulo_Tarefa
{
    public class ControladorTarefa : ControloadorBase
    {
        public override string ToolTipInserir { get { return "inserir nova Tarefa"; } }

        public override string ToolTipEditar { get { return "editar Tarefa"; } }

        public override string ToolTipExcluir { get { return "Excluir Tarefa"; } }

        public override void Inserir()
        {
            TelaTarefaForm1 telaTarefa = new TelaTarefaForm1();

            telaTarefa.ShowDialog();
        }

        public override UserControl ObterListagem()
        {
            return new ListagemTarefaControl();
        }
    }
}
