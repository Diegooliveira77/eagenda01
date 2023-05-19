using ModulosCompromissoPlataformaWinFormsApp1.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulosCompromissoPlataformaWinFormsApp1.Contatos
{
    public class ControladorContato : ControloadorBase
    {
        public override string ToolTipInserir { get { return "inserir novo contato"; } }

        public override string ToolTipEditar { get { return "editar  contato existente "; } }

        public override string ToolTipExcluir { get { return "Excluir contato"; } }

        public override void Inserir()
        {
            TelaContatoForm1 telaContato = new TelaContatoForm1();

            telaContato.ShowDialog();//essa função showDialog ele abre o formulario
        }

        public override UserControl ObterListagem()
        {
            return new ListagemContatosUserControl1();
        }
    }

    }
